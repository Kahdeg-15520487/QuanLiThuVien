﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DataAccess;

namespace QuanLiThuVien {
	public partial class LapTheDocGia : Form {
		public LapTheDocGia() {
			InitializeComponent();
		}

		private void LapTheDocGia_Load(object sender, EventArgs e) {
			textBox_MaDocGia.Text = RandomIdGenerator.GetBase36(10);
			//groupBox_LoaiDocGia.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
		}

		private void button_LapThe_Click(object sender, EventArgs e) {
			if (CheckInfo()) {
				MessageBox.Show("lapthe");
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

			return true;

f:
			return false;
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
	}
}