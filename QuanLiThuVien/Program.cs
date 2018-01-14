using System;
using System.Windows.Forms;

using DataAccess;

namespace QuanLiThuVien {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
			//setup database
			Database.InitDatabase("thuvien.db", "secret");

			//setup crash handler
			AppDomain currentDomain = AppDomain.CurrentDomain;
			currentDomain.UnhandledException += CurrentDomain_UnhandledException;

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}

		private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e) {
			Exception ex = (Exception)e.ExceptionObject;
			string message = new string('=', 20) + Environment.NewLine +
				ex.Message + Environment.NewLine +
				ex.StackTrace + Environment.NewLine +
				ex.TargetSite;
			string logfilename = "crashlog_" + DateTime.Now.ToString(@"dd_MM_yyyy_HH_mm") + ".txt";
			try {
				System.IO.File.WriteAllText(logfilename, message);
			}
			catch (Exception exx) {
				throw exx;
			}
		}
	}
}
