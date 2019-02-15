namespace DocFactory
{
    partial class DocFactoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbInputFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowseInput = new System.Windows.Forms.Button();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblTemplate = new System.Windows.Forms.Label();
            this.btnBrowseTemplate = new System.Windows.Forms.Button();
            this.txbTemplateFilePath = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnBrowseOutput = new System.Windows.Forms.Button();
            this.txbOutputFolderPath = new System.Windows.Forms.TextBox();
            this.btnCreateFiles = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslblMessage = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnOpenOutputFolder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnOpenLogFile = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbInputFilePath
            // 
            this.txbInputFilePath.Location = new System.Drawing.Point(89, 14);
            this.txbInputFilePath.Name = "txbInputFilePath";
            this.txbInputFilePath.Size = new System.Drawing.Size(291, 20);
            this.txbInputFilePath.TabIndex = 3;
            // 
            // btnBrowseInput
            // 
            this.btnBrowseInput.Location = new System.Drawing.Point(386, 12);
            this.btnBrowseInput.Name = "btnBrowseInput";
            this.btnBrowseInput.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseInput.TabIndex = 6;
            this.btnBrowseInput.Text = "Browse...";
            this.btnBrowseInput.UseVisualStyleBackColor = true;
            this.btnBrowseInput.Click += new System.EventHandler(this.BtnBrowseInput_Click);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(12, 17);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(58, 13);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "Input data:";
            // 
            // lblTemplate
            // 
            this.lblTemplate.AutoSize = true;
            this.lblTemplate.Location = new System.Drawing.Point(12, 46);
            this.lblTemplate.Name = "lblTemplate";
            this.lblTemplate.Size = new System.Drawing.Size(73, 13);
            this.lblTemplate.TabIndex = 1;
            this.lblTemplate.Text = "Doc template:";
            // 
            // btnBrowseTemplate
            // 
            this.btnBrowseTemplate.Location = new System.Drawing.Point(386, 41);
            this.btnBrowseTemplate.Name = "btnBrowseTemplate";
            this.btnBrowseTemplate.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseTemplate.TabIndex = 7;
            this.btnBrowseTemplate.Text = "Browse...";
            this.btnBrowseTemplate.UseVisualStyleBackColor = true;
            this.btnBrowseTemplate.Click += new System.EventHandler(this.BtnBrowseTemplate_Click);
            // 
            // txbTemplateFilePath
            // 
            this.txbTemplateFilePath.Location = new System.Drawing.Point(89, 43);
            this.txbTemplateFilePath.Name = "txbTemplateFilePath";
            this.txbTemplateFilePath.Size = new System.Drawing.Size(291, 20);
            this.txbTemplateFilePath.TabIndex = 4;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(12, 75);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(71, 13);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = "Output folder:";
            // 
            // btnBrowseOutput
            // 
            this.btnBrowseOutput.Location = new System.Drawing.Point(386, 70);
            this.btnBrowseOutput.Name = "btnBrowseOutput";
            this.btnBrowseOutput.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseOutput.TabIndex = 8;
            this.btnBrowseOutput.Text = "Browse...";
            this.btnBrowseOutput.UseVisualStyleBackColor = true;
            this.btnBrowseOutput.Click += new System.EventHandler(this.BtnBrowseOutput_Click);
            // 
            // txbOutputFolderPath
            // 
            this.txbOutputFolderPath.Location = new System.Drawing.Point(89, 72);
            this.txbOutputFolderPath.Name = "txbOutputFolderPath";
            this.txbOutputFolderPath.Size = new System.Drawing.Size(291, 20);
            this.txbOutputFolderPath.TabIndex = 5;
            // 
            // btnCreateFiles
            // 
            this.btnCreateFiles.Location = new System.Drawing.Point(386, 98);
            this.btnCreateFiles.Name = "btnCreateFiles";
            this.btnCreateFiles.Size = new System.Drawing.Size(75, 23);
            this.btnCreateFiles.TabIndex = 9;
            this.btnCreateFiles.Text = "Create files";
            this.btnCreateFiles.UseVisualStyleBackColor = true;
            this.btnCreateFiles.Click += new System.EventHandler(this.BtnCreateFiles_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblMessage,
            this.toolStripSeparator1,
            this.tsbtnOpenOutputFolder,
            this.toolStripSeparator2,
            this.tsbtnOpenLogFile});
            this.toolStrip1.Location = new System.Drawing.Point(0, 136);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(481, 25);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslblMessage
            // 
            this.tslblMessage.Name = "tslblMessage";
            this.tslblMessage.Size = new System.Drawing.Size(75, 22);
            this.tslblMessage.Text = "tslblMessage";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator1.Visible = false;
            // 
            // tsbtnOpenOutputFolder
            // 
            this.tsbtnOpenOutputFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnOpenOutputFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnOpenOutputFolder.Name = "tsbtnOpenOutputFolder";
            this.tsbtnOpenOutputFolder.Size = new System.Drawing.Size(113, 22);
            this.tsbtnOpenOutputFolder.Text = "Open output folder";
            this.tsbtnOpenOutputFolder.Visible = false;
            this.tsbtnOpenOutputFolder.Click += new System.EventHandler(this.TsbtnOpenOutputFolder_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator2.Visible = false;
            // 
            // tsbtnOpenLogFile
            // 
            this.tsbtnOpenLogFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnOpenLogFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnOpenLogFile.Name = "tsbtnOpenLogFile";
            this.tsbtnOpenLogFile.Size = new System.Drawing.Size(79, 22);
            this.tsbtnOpenLogFile.Text = "Open log file";
            this.tsbtnOpenLogFile.Visible = false;
            this.tsbtnOpenLogFile.Click += new System.EventHandler(this.TsbtnOpenLogFile_Click);
            // 
            // DocFactoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 161);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnCreateFiles);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnBrowseOutput);
            this.Controls.Add(this.txbOutputFolderPath);
            this.Controls.Add(this.lblTemplate);
            this.Controls.Add(this.btnBrowseTemplate);
            this.Controls.Add(this.txbTemplateFilePath);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.btnBrowseInput);
            this.Controls.Add(this.txbInputFilePath);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DocFactoryForm";
            this.Text = "Doc Factory";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbInputFilePath;
        private System.Windows.Forms.Button btnBrowseInput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblTemplate;
        private System.Windows.Forms.Button btnBrowseTemplate;
        private System.Windows.Forms.TextBox txbTemplateFilePath;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnBrowseOutput;
        private System.Windows.Forms.TextBox txbOutputFolderPath;
        private System.Windows.Forms.Button btnCreateFiles;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslblMessage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnOpenOutputFolder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnOpenLogFile;
    }
}

