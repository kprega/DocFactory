using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Xceed.Words.NET;

namespace DocFactory
{
    public partial class DocFactoryForm : Form
    {
        /// <summary>
        /// Data table loaded from input file.
        /// </summary>
        private InputTable InputTable { get; set; }

        /// <summary>
        /// Doc Factory form.
        /// </summary>
        public DocFactoryForm()
        {
            InitializeComponent();
            this.tslblMessage.Text = "Ready";
        }

        /// <summary>
        /// Opens input data selection dialog.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBrowseInput_Click(object sender, EventArgs e)
        {
            SelectFileDialog(sender);
        }

        /// <summary>
        /// Opens doc template selection dialog.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBrowseTemplate_Click(object sender, EventArgs e)
        {
            SelectFileDialog(sender);
        }

        /// <summary>
        /// Opens dialog for selecting output folder.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnBrowseOutput_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                this.txbOutputFolderPath.Text = fbd.SelectedPath;
                this.txbOutputFolderPath.Focus();
            }
        }

        /// <summary>
        /// Executes file creation procedure.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCreateFiles_Click(object sender, EventArgs e)
        {
            try
            {
                Program.Log.Info("Starting operation...");
                this.tslblMessage.Text = "Processing, please wait...";
                if (this.toolStripSeparator1.Visible)
                {
                    ToggleToolStripControlsVisibility();
                }

                Task t = Task.Factory.StartNew(() =>
                {
                    CreateFilesInOutputFolder();
                    ReplaceTagsInDocuments(new DirectoryInfo(this.txbOutputFolderPath.Text));
                });
                t.Wait();
            }
            catch (Exception exc)
            {
                Program.Log.Error("Exception error occured:", exc);
            }
            finally
            {
                Program.Log.Info("Operation finished.");
                this.tslblMessage.Text = "Ready";
                ToggleToolStripControlsVisibility();
            }
        }

        /// <summary>
        /// Opens file selection dialog.
        /// </summary>
        /// <param name="sender"></param>
        private void SelectFileDialog(object sender)
        {
            var filter = string.Empty;
            var target = new TextBox();

            if (sender.Equals(this.btnBrowseInput))
            {
                filter = "XLSX files (*.xlsx)|*.xlsx";
                target = this.txbInputFilePath;
            }

            if (sender.Equals(this.btnBrowseTemplate))
            {
                filter = "DOCX files (*.docx)|*.docx";
                target = this.txbTemplateFilePath;
            }

            var ofd = new OpenFileDialog
            {
                Filter = filter
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                target.Text = ofd.FileName;
                target.Focus();
            }
        }

        /// <summary>
        /// Opens log file.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsbtnOpenLogFile_Click(object sender, EventArgs e)
        {
            if (File.Exists(Program.LogPath))
            {
                System.Diagnostics.Process.Start("notepad.exe", Program.LogPath);
            }
            else
            {
                tslblMessage.Text = "Cannot find log file.";
            }
        }

        /// <summary>
        /// Opens output folder.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TsbtnOpenOutputFolder_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(this.txbOutputFolderPath.Text))
            {
                System.Diagnostics.Process.Start("explorer.exe", this.txbOutputFolderPath.Text);
            }
            else
            {
                tslblMessage.Text = "Cannot find specified directory.";
            }
        }

        /// <summary>
        /// Copies doc template into output folder and renames files according to data provided in data template.
        /// </summary>
        private void CreateFilesInOutputFolder()
        {
            this.InputTable = new InputTable(this.txbInputFilePath.Text);
            var filenameColumnIndex = 0;

            if (!this.InputTable.GetRows()[0].Contains("<Filename>"))
            {
                Program.Log.Error("Input data table does not contain <Filename> column. Please check input data file.");
                return;
            }
            else
            {
                var rowEnumerator = this.InputTable.GetRows()[0].GetEnumerator();
                while (rowEnumerator.MoveNext())
                {
                    if (rowEnumerator.Current.ToString() == "<Filename>")
                    {
                        break;
                    }
                    filenameColumnIndex++;
                }
            }

            for (int i = 1; i < this.InputTable.GetRows().Count; i++)
            {
                var row = this.InputTable.GetRows()[i];
                if (this.InputTable.IsRowDataComplete(row))
                {
                    File.Copy(txbTemplateFilePath.Text, txbOutputFolderPath.Text + "\\" + row.ElementAt(filenameColumnIndex).ToString(), true);
                }
                else
                {
                    Program.Log.Warn($"Skipping row {i + 1} because of missing value(s).");
                }
            }
        }

        /// <summary>
        /// Replaces tags with values in all files within specified directory.
        /// </summary>
        /// <param name="di">DirectoryInfo providing path to output folder.</param>
        private void ReplaceTagsInDocuments(DirectoryInfo di)
        {
            var files = di.GetFiles();
            System.Threading.Tasks.Parallel.ForEach
            (
                files,
                currentFile =>
                {
                    //check if file is present in table first - this bypasses temporary files in output folder
                    if (InputTable.GetRows().Any(row => row.Contains(currentFile.Name)))
                    {
                        using (DocX doc = DocX.Load(currentFile.FullName))
                        {
                            var row = this.InputTable.GetRows().Find(r => r.Contains(currentFile.Name));
                            var tags = this.InputTable.Tags;

                            for (int i = 0; i < row.Length; i++)
                            {
                                if (tags[i] == "<Filename>") continue;
                                if (row[i] is DateTime)
                                {
                                    doc.ReplaceText(tags[i].ToString(), DateTime.Parse(row[i].ToString()).ToString("yyyy/MM/dd"));
                                }
                                else
                                {
                                    doc.ReplaceText(tags[i].ToString(), row[i].ToString());
                                }
                            }
                            doc.Save();
                        }
                    }
                }
            );
        }

        /// <summary>
        /// Changes visibility state of toolstrip controls.
        /// </summary>
        private void ToggleToolStripControlsVisibility()
        {
            this.toolStripSeparator1.Visible = !this.toolStripSeparator1.Visible;
            this.toolStripSeparator2.Visible = !this.toolStripSeparator2.Visible;
            this.tsbtnOpenLogFile.Visible = !this.tsbtnOpenLogFile.Visible;
            this.tsbtnOpenOutputFolder.Visible = !this.tsbtnOpenOutputFolder.Visible;
        }
    }
}
