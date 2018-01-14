using QuanLiThuVien.XuliTheDocGia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThuVien {
	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();
		}

		private void button_docgia_Click(object sender, EventArgs e) {
			new ThaoTacDocGia().ShowDialog();
		}

		private void button_sach_Click(object sender, EventArgs e) {

		}

		private void button_baocao_Click(object sender, EventArgs e) {

		}

		private void button_muonsach_Click(object sender, EventArgs e) {

		}

		private void button_trasach_Click(object sender, EventArgs e) {

		}
	}
}
