using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Windows.Forms;
using QuanLiThuVien.BaocaoSachMuonTheoTheloai;

namespace QuanLiThuVien {
	public partial class QuanliBaocaoSachMuonTheoTheloai : Form {
		public QuanliBaocaoSachMuonTheoTheloai() {
			InitializeComponent();
		}

		private void QuanliBaocaoSachMuonTheoTheloai_Load(object sender, EventArgs e) {
			PopulateListView(GetAll());
		}

		private void button_lapbaocao_Click(object sender, EventArgs e) {
			new LapBaocaoSachMuonTheoTheloai().ShowDialog();
			PopulateListView(GetAll());
		}

		private void button_xembaocao_Click(object sender, EventArgs e) {
			if (listView_baocao.SelectedItems.Count == 0) {
				return;
			}
			var sbc = listView_baocao.SelectedItems[0];
			new XemBaocaoSachMuonTheoTheloai(sbc.SubItems[1].Text).ShowDialog();
		}

		private void button_timbaocao_Click(object sender, EventArgs e) {
			if (textBox_mabaocao.Text.Length != 10) {
				MessageBox.Show("Mã báo cáo không hợp lệ");
				return;
			}
			PopulateListView(GetQuerry(x => x.MaBaoCao == textBox_mabaocao.Text));
		}

		private void PopulateListView(List<ListViewItem> lvis) {
			listView_baocao.Items.Clear();
			foreach (var lvi in lvis) {
				listView_baocao.Items.Add(lvi);
			}
		}

		private List<ListViewItem> GetAll() {
			var lvis = new List<ListViewItem>();
			foreach (var bc in DataAccess.Database.GetAllBaocaoSachMuonTheoTheloai()) {
				ListViewItem item = new ListViewItem(lvis.Count.ToString());
				item.SubItems.Add(bc.MaBaoCao);
				item.SubItems.Add(bc.NgayLapBaoCao.ToShortDateString());
				item.SubItems.Add(bc.DanhsachSachMuonTheoTheloai.Count.ToString());
				lvis.Add(item);
			}
			return lvis;
		}

		private List<ListViewItem> GetQuerry(Expression<Func<DataAccess.DataObject.BaocaoSachMuonTheoTheloai, bool>> dieukienloc) {
			var lvis = new List<ListViewItem>();
			foreach (var bc in DataAccess.Database.GetBaocaoSachMuonTheoTheloais(dieukienloc)) {
				ListViewItem item = new ListViewItem(lvis.Count.ToString());
				item.SubItems.Add(bc.MaBaoCao);
				item.SubItems.Add(bc.NgayLapBaoCao.ToShortDateString());
				item.SubItems.Add(bc.DanhsachSachMuonTheoTheloai.Count.ToString());
				lvis.Add(item);
			}
			return lvis;
		}
	}
}
