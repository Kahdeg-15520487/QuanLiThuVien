using System;

namespace QuanLiThuVien {
	static class Printer {
		public static string Print(string content) {
			string filename = "print_" + DateTime.Now.ToString(@"dd_MM_yyyy_HH_mm") + ".txt";
			System.IO.File.WriteAllText(filename, content);
			return filename;
		}
	}
}
