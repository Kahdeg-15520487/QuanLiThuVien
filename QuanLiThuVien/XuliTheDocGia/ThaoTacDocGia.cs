using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThuVien.XuliTheDocGia {
	public partial class ThaoTacDocGia : Form {
		public ThaoTacDocGia() {
			InitializeComponent();
		}

		private void button_lapthedocgia_Click(object sender, EventArgs e) {
			new LapTheDocGia().ShowDialog();
		}

		private void button_capnhatdocgia_Click(object sender, EventArgs e) {
			new CapNhatTheDocGia().ShowDialog();
		}

		private void button_xoadocgia_Click(object sender, EventArgs e) {
			throw new NotImplementedException();
		}

		private void button_timdocgia_Click(object sender, EventArgs e) {
			throw new NotImplementedException();
		}

		private void ThaoTacDocGia_Load(object sender, EventArgs e) {
			int count = 0;
			foreach (var dg in DataAccess.Database.GetAllDocGia()) {
				ListViewItem item = new ListViewItem(count++.ToString());
				item.SubItems.Add(dg.MaTheDG);
				item.SubItems.Add(dg.HoTen);
				item.SubItems.Add(dg.LoaiDG.TenLoaiDocGia);
				item.SubItems.Add(dg.NgayHetHan.ToShortDateString());
				item.SubItems.Add(dg.TongNo.ToString());
				listView_docgia.Items.Add(item);
			}
		}
	}
}
