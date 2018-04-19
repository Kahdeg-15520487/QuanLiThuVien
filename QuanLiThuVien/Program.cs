using System;
using System.Windows.Forms;
using System.Xml;
using DataAccess;

namespace QuanLiThuVien
{
    static class Program
    {

        class config
        {
            public readonly string database;
            public readonly string secret;

            public config(string db, string se)
            {
                database = db;
                secret = se;
            }

            public static config GetConfig()
            {
                XmlDocument xml = new XmlDocument();
                xml.Load("config.xml");
                XmlNode db = xml.DocumentElement.SelectSingleNode("/config/database");
                XmlNode se = xml.DocumentElement.SelectSingleNode("/config/secret");

                return new config(db.InnerText.Trim(), se.InnerText.Trim());
            }

        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            config config = config.GetConfig();

            //setup database
            Database.InitDatabase(config.database, config.secret);

            //setup crash handler
            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException += CurrentDomain_UnhandledException;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception ex = (Exception)e.ExceptionObject;
            string message = new string('=', 20) + Environment.NewLine +
                ex.Message + Environment.NewLine +
                ex.StackTrace + Environment.NewLine +
                ex.TargetSite;
            string logfilename = "crashlog_" + DateTime.Now.ToString(@"dd_MM_yyyy_HH_mm") + ".txt";
            try
            {
                System.IO.File.WriteAllText(logfilename, message);
            }
            catch (Exception exx)
            {
                throw exx;
            }
        }
    }
}
