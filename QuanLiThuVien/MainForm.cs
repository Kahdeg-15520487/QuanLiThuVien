using System;
using System.Windows.Forms;

using QuanLiThuVien.BaocaoSachtratre;
using QuanLiThuVien.XuliTheDocGia;

namespace QuanLiThuVien {
	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();
		}

		private void button_docgia_Click(object sender, EventArgs e) {
			new QuanLiDocGia().ShowDialog();
		}

		private void button_sach_Click(object sender, EventArgs e) {

		}

		private void button_muonsach_Click(object sender, EventArgs e) {

		}

		private void button_trasach_Click(object sender, EventArgs e) {

		}

		private void button_baocao_Click(object sender, EventArgs e) {
			new QuanliBaocaoThongkeSachTratre().ShowDialog();
		}

		private void button6_Click(object sender, EventArgs e) {
			new QuanliBaocaoSachMuonTheoTheloai().ShowDialog();
		}
	}
}
