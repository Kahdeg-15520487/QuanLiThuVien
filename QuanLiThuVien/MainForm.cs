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

		DataAccess.DataObject.QuyDinh TuoiToithieu;
		DataAccess.DataObject.QuyDinh TuoiToida;
		DataAccess.DataObject.QuyDinh ThoihanThe;
		DataAccess.DataObject.QuyDinh NamXuatban;
		DataAccess.DataObject.QuyDinh SoluongSachDuocMuon;
		DataAccess.DataObject.QuyDinh SoNgaymuonToida;

		private void MainForm_Load(object sender, EventArgs e) {
			TuoiToithieu = DataAccess.Database.GetQuyDinh(x => x.TenQuiDinh == "TuoiToithieu");
			TuoiToida = DataAccess.Database.GetQuyDinh(x => x.TenQuiDinh == "TuoiToida");
			ThoihanThe = DataAccess.Database.GetQuyDinh(x => x.TenQuiDinh == "ThoihanThe");
			NamXuatban = DataAccess.Database.GetQuyDinh(x => x.TenQuiDinh == "NamXuatban");
			SoluongSachDuocMuon = DataAccess.Database.GetQuyDinh(x => x.TenQuiDinh == "SoluongSachDuocMuon");
			SoNgaymuonToida = DataAccess.Database.GetQuyDinh(x => x.TenQuiDinh == "SoNgaymuonToida");

			textBox_tuoitoithieu.Text = TuoiToithieu.NoiDungQuiDinh;
			textBox_tuoitoida.Text = TuoiToida.NoiDungQuiDinh;
			textBox_thoihanthe.Text = ThoihanThe.NoiDungQuiDinh;
			textBox_namxuatban.Text = NamXuatban.NoiDungQuiDinh;
			textBox_slsachtoidadcmuon.Text = SoluongSachDuocMuon.NoiDungQuiDinh;
			textBox_songaymuontoida.Text = SoNgaymuonToida.NoiDungQuiDinh;
		}

		private void button_luuquydinh_Click(object sender, EventArgs e) {
			TuoiToithieu.NoiDungQuiDinh = textBox_tuoitoithieu.Text;
			TuoiToida.NoiDungQuiDinh = textBox_tuoitoida.Text;
			ThoihanThe.NoiDungQuiDinh = textBox_thoihanthe.Text;
			NamXuatban.NoiDungQuiDinh = textBox_namxuatban.Text;
			SoluongSachDuocMuon.NoiDungQuiDinh = textBox_slsachtoidadcmuon.Text;
			SoNgaymuonToida.NoiDungQuiDinh = textBox_songaymuontoida.Text;

			DataAccess.Database.SetQuyDinh(TuoiToithieu);
			DataAccess.Database.SetQuyDinh(TuoiToida);
			DataAccess.Database.SetQuyDinh(ThoihanThe);
			DataAccess.Database.SetQuyDinh(NamXuatban);
			DataAccess.Database.SetQuyDinh(SoluongSachDuocMuon);
			DataAccess.Database.SetQuyDinh(SoNgaymuonToida);
		}

		private void CheckTextboxNumeric(object sender, EventArgs e) {
			var textbox = ((TextBox)sender);
			if (!int.TryParse(textbox.Text, out int t)) {
				textbox.Undo();
			}
		}
	}
}
