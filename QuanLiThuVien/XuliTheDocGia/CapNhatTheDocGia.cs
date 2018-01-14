using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DataAccess;

namespace QuanLiThuVien.XuliTheDocGia {
	public partial class CapNhatTheDocGia : Form {
		private string mathedocgia;
		private DataAccess.DataObject.DocGia docgia;

		public CapNhatTheDocGia(string mathedocgia) {
			InitializeComponent();
			this.mathedocgia = mathedocgia;
		}

		private void CapNhatTheDocGia_Load(object sender, EventArgs e) {
			docgia = Database.GetDocGia(mathedocgia);
			textBox_MaDocGia.Text = mathedocgia;

			if (docgia.LoaiDG.TenLoaiDocGia == "X") {
				radioButton_X.Checked = true;
				radioButton_Y.Checked = false;
			}
			else {
				radioButton_X.Checked = false;
				radioButton_Y.Checked = true;
			}
			textBox_TenLoaiDocGia.Text = docgia.LoaiDG.TenLoaiDocGia;

			textBox_HoTen.Text = docgia.HoTen;
			dateTimePicker_NgaySinh.Value = docgia.NgaySinh;
			textBox_DiaChi.Text = docgia.DiaChi;
			textBox_Email.Text = docgia.Email;
			dateTimePicker_NgayLapThe.Value = docgia.NgayLapThe;
			textBox_tongno.Text = docgia.TongNo.ToString();
		}

		private void dateTimePicker_NgayLapThe_ValueChanged(object sender, EventArgs e) {
			dateTimePicker_NgayHetHan.Value = dateTimePicker_NgayLapThe.Value.AddMonths(6);
		}

		private void radioButton_X_CheckedChanged(object sender, EventArgs e) {
			if (radioButton_X.Checked) {
				textBox_TenLoaiDocGia.Text = "X";
			}
		}

		private void radioButton_Y_CheckedChanged(object sender, EventArgs e) {
			if (radioButton_Y.Checked) {
				textBox_TenLoaiDocGia.Text = "Y";
			}
		}

		private void button_CapNhatThe_Click(object sender, EventArgs e) {
			if (CheckInfo()) {
				docgia.LoaiDG.TenLoaiDocGia = textBox_TenLoaiDocGia.Text;
				docgia.HoTen = textBox_HoTen.Text;
				docgia.NgaySinh = dateTimePicker_NgaySinh.Value;
				docgia.DiaChi = textBox_DiaChi.Text;
				docgia.Email = textBox_Email.Text;
				docgia.NgayLapThe = dateTimePicker_NgayLapThe.Value;
				docgia.NgayHetHan = dateTimePicker_NgayHetHan.Value;
				docgia.TongNo = int.Parse(textBox_tongno.Text);
				Database.SetDocGia(docgia);
			}
		}

		private void button_Huy_Click(object sender, EventArgs e) {
			Close();
		}

		private bool CheckInfo() {

			if (string.IsNullOrWhiteSpace(textBox_HoTen.Text)) {
				MessageBox.Show("Họ tên không thể để trống");
				goto f;
			}

			var tuoi = DateTime.Today.Year - dateTimePicker_NgaySinh.Value.Year;
			if (tuoi < 18 || tuoi > 55) {
				MessageBox.Show("Tuổi đọc giả phải từ 18 tới 55");
				goto f;
			}

			if (string.IsNullOrWhiteSpace(textBox_DiaChi.Text)) {
				MessageBox.Show("Địa chỉ không thể để trống");
				goto f;
			}

			if (!int.TryParse(textBox_tongno.Text, out int tongno)) {
				MessageBox.Show("Tổng nợ không hợp lệ");
				goto f;
			}

			return true;

f:
			return false;
		}
	}
}
