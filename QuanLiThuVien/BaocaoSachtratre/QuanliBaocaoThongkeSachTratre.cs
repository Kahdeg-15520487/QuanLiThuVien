using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThuVien.BaocaoSachtratre {
	public partial class QuanliBaocaoThongkeSachTratre : Form {
		public QuanliBaocaoThongkeSachTratre() {
			InitializeComponent();
		}

		private void button_lapbaocao_Click(object sender, EventArgs e) {
			new LapBaoCaoSachTraTre().ShowDialog();
			PopulateListView(GetAll());
		}

		private void button_xembaocao_Click(object sender, EventArgs e) {
			var sbc = listView_baocao.SelectedItems[0];
			new XemBaoCaoSachTraTre(sbc.SubItems[1].Text);
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
			foreach (var bc in DataAccess.Database.GetAllBaocaoThongkeSachTraTre()) {
				ListViewItem item = new ListViewItem(lvis.Count.ToString());
				item.SubItems.Add(bc.MaBaoCao);
				item.SubItems.Add(bc.NgayLapBaoCao.ToShortDateString());
				item.SubItems.Add(bc.DanhsachSachTraTre.Count.ToString());
				lvis.Add(item);
			}
			return lvis;
		}

		private List<ListViewItem> GetQuerry(Expression<Func<DataAccess.DataObject.BaocaoThongkeSachTraTre, bool>> dieukienloc) {
			var lvis = new List<ListViewItem>();
			foreach (var bc in DataAccess.Database.GetBaocaoThongkeSachTraTres(dieukienloc)) {
				ListViewItem item = new ListViewItem(lvis.Count.ToString());
				item.SubItems.Add(bc.MaBaoCao);
				item.SubItems.Add(bc.NgayLapBaoCao.ToShortDateString());
				item.SubItems.Add(bc.DanhsachSachTraTre.Count.ToString());
				lvis.Add(item);
			}
			return lvis;
		}
	}
}
