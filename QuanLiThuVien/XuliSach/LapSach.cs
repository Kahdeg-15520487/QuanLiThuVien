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

namespace QuanLiThuVien.XuliSach {
	public partial class LapSach: MaterialSkin.Controls.MaterialForm {

		public LapSach() {
			InitializeComponent();

            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey800, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.LightBlue200, MaterialSkin.TextShade.WHITE);
        }

		private void CapNhatTheDocGia_Load(object sender, EventArgs e) {
			textBox_masach.Text = RandomIdGenerator.GetBase36(10);

			var theloais = Database.GetAllTheLoai();
			var tacgias = Database.GetAllTacGia();

			foreach (var tl in theloais) {
				comboBox_theloai.Items.Add(tl.TenTheLoai);
			}
			comboBox_theloai.SelectedIndex = 0;
			foreach (var tg in tacgias) {
				comboBox_tacgia.Items.Add(tg.TenTacGia);
			}
			comboBox_tacgia.SelectedIndex = 0;
			dateTimePicker_ngaynhap.Value = DateTime.Now;
		}

		private void button_CapNhatThe_Click(object sender, EventArgs e) {
			if (CheckInfo()) {
				DataAccess.DataObject.Sach sach = new DataAccess.DataObject.Sach();
				sach.MaSach = textBox_masach.Text;
				sach.TheLoai = new DataAccess.DataObject.TheLoai() { TenTheLoai = comboBox_theloai.SelectedText };
				sach.TenSach = textBox_tensach.Text;
				sach.NgayNhap = dateTimePicker_ngaynhap.Value;
				sach.NamXB = int.Parse(textBox_namxb.Text);
				sach.NXB = textBox_nxb.Text;
				sach.TacGia = new DataAccess.DataObject.TacGia() { TenTacGia = comboBox_tacgia.SelectedText };
				sach.TinhTrang = textBox_tinhtrang.Text;
				Database.AddSach(sach);
				MessageBox.Show("Đã thêm sách vào database");
				Close();
			}
		}

		private void button_Huy_Click(object sender, EventArgs e) {
			Close();
		}

		private bool CheckInfo() {

			if (string.IsNullOrWhiteSpace(textBox_tensach.Text)) {
				MessageBox.Show("Tên sách không thể để trống");
				goto f;
			}

			var namxb = DateTime.Today.Year - int.Parse(textBox_namxb.Text);
			var namxbtoithieu = int.Parse(Database.GetQuyDinh(x => x.TenQuiDinh == "NamXuatban").NoiDungQuiDinh);
			if (namxb > namxbtoithieu) {
				MessageBox.Show("Sách phải được xuất bản trong vòng " + namxbtoithieu + " trở lại đây");
				goto f;
			}

			if (string.IsNullOrWhiteSpace(textBox_nxb.Text)) {
				MessageBox.Show("Nhà xuất bản không thể để trống");
				goto f;
			}

			return true;

f:
			return false;
		}

		private void textBox_namxb_TextChanged(object sender, EventArgs e) {
			int t = 0;
			if (!int.TryParse(textBox_namxb.Text, out t)) {
				textBox_namxb.Undo();
			}
		}
	}
}
