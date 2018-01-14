using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace QuanLiThuVien.XuliTheDocGia {
	public partial class QuanLiDocGia : Form {
		public QuanLiDocGia() {
			InitializeComponent();
		}

		private void button_lapthedocgia_Click(object sender, EventArgs e) {
			new LapTheDocGia().ShowDialog();
			PopulateListView(GetAll());
			//update listview
		}

		private void button_capnhatdocgia_Click(object sender, EventArgs e) {
			var slvis = listView_docgia.SelectedItems;
			foreach (ListViewItem slvi in slvis) {
				new CapNhatTheDocGia(slvi.SubItems[1].Text).Show();
			}
			PopulateListView(GetAll());
			//get selected item
			//new CapNhatTheDocGia().Show();
			//update listview
		}

		private void button_xoadocgia_Click(object sender, EventArgs e) {
			var slvis = listView_docgia.SelectedItems;
			StringBuilder deleteddocgia = new StringBuilder();
			deleteddocgia.AppendLine("Đã xóa các đọc giả có mã: ");
			foreach (ListViewItem slvi in slvis) {
				DataAccess.Database.RemoveDocGia(slvi.SubItems[1].Text);
				deleteddocgia.AppendLine(slvi.SubItems[1].Text);
			}
			MessageBox.Show(deleteddocgia.ToString());
			PopulateListView(GetAll());
			//get selected item
			//delete from database
			//update listview
		}

		private void button_timdocgia_Click(object sender, EventArgs e) {
			if (textBox_MaDocGia.Text.Length != 10) {
				MessageBox.Show("Mã đọc giả không hợp lệ");
				return;
			}
			PopulateListView(GetQuerry(x => x.MaTheDG == textBox_MaDocGia.Text));
			//generate querry, just querry madg for now
			//update listview
		}

		private void ThaoTacDocGia_Load(object sender, EventArgs e) {
			PopulateListView(GetAll());
		}

		private void PopulateListView(List<ListViewItem> lvis) {
			listView_docgia.Items.Clear();
			foreach (var lvi in lvis) {
				listView_docgia.Items.Add(lvi);
			}
		}

		private List<ListViewItem> GetAll() {
			var lvis = new List<ListViewItem>();
			foreach (var dg in DataAccess.Database.GetAllDocGia()) {
				ListViewItem item = new ListViewItem(lvis.Count.ToString());
				item.SubItems.Add(dg.MaTheDG);
				item.SubItems.Add(dg.HoTen);
				item.SubItems.Add(dg.LoaiDG.TenLoaiDocGia);
				item.SubItems.Add(dg.NgayHetHan.ToShortDateString());
				item.SubItems.Add(dg.TongNo.ToString());
				lvis.Add(item);
			}
			return lvis;
		}

		private List<ListViewItem> GetQuerry(Expression<Func<DataAccess.DataObject.DocGia, bool>> dieukienloc) {
			var lvis = new List<ListViewItem>();
			foreach (var dg in DataAccess.Database.GetDocGias(dieukienloc)) {
				ListViewItem item = new ListViewItem(lvis.Count.ToString());
				item.SubItems.Add(dg.MaTheDG);
				item.SubItems.Add(dg.HoTen);
				item.SubItems.Add(dg.LoaiDG.TenLoaiDocGia);
				item.SubItems.Add(dg.NgayHetHan.ToShortDateString());
				item.SubItems.Add(dg.TongNo.ToString());
				lvis.Add(item);
			}
			return lvis;
		}

		private void listView_docgia_MouseClick(object sender, MouseEventArgs e) {
			if (e.Button == MouseButtons.Right) {
				if (listView_docgia.FocusedItem.Bounds.Contains(e.Location) == true) {
					contextMenuStrip1.Show(Cursor.Position);
				}
			}
		}
	}
}
