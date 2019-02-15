using System;
using System.Windows.Forms;
using log4net;

namespace DocFactory
{

    static class Program
    {
        /// <summary>
        /// Logger field.
        /// </summary> 
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Property providing access to log.
        /// </summary>
        public static ILog Log => log;

        /// <summary>
        /// Log file path.
        /// </summary>
        private static string _LogPath;

        /// <summary>
        /// Property providing access to log path field.
        /// </summary>
        public static string LogPath { get => _LogPath; set => _LogPath = value; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            LogPath = System.IO.Path.GetTempPath() + "\\DocFactory.log";
            GlobalContext.Properties["LogName"] = LogPath;
            log4net.Config.XmlConfigurator.Configure();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DocFactoryForm());
        }
    }
}
