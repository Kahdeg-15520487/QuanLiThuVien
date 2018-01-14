using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThuVien.BaocaoSachMuonTheoTheloai {
	public partial class XemBaocaoSachMuonTheoTheloai : Form {
		private string mabaocao;
		public XemBaocaoSachMuonTheoTheloai(string mabaocao) {
			InitializeComponent();
			this.mabaocao = mabaocao;
		}

		private void XemBaocaoSachMuonTheoTheloai_Load(object sender, EventArgs e) {
			//truy xuất báo cáo từ csdl
			textBox_mabaocao.Text = mabaocao;
			var baocao = DataAccess.Database.GetBaocaoSachMuonTheoTheloai(mabaocao);
			dateTimePicker_ngaylapbaocao.Value = baocao.NgayLapBaoCao;
			textBox_tongluotmuon.Text = baocao.TongSoluotMuon.ToString();
			//hiển thị thông tin lên listview
			foreach (var ttms in baocao.DanhsachSachMuonTheoTheloai) {
				ListViewItem lvi = new ListViewItem(listView_theloaitheoluotmuon.Items.Count.ToString());
				lvi.SubItems.Add(ttms.TheLoai.TenTheLoai);
				lvi.SubItems.Add(ttms.SoLuotMuon.ToString());
				lvi.SubItems.Add(ttms.TiLe.ToString());
				listView_theloaitheoluotmuon.Items.Add(lvi);
			}
		}

		private void button_inbaocao_Click(object sender, EventArgs e) {
			StringBuilder content = new StringBuilder();
			content.AppendLine("Báo cáo thống kê sách trả trễ");
			content.AppendLine("Ngày " + dateTimePicker_ngaylapbaocao.Value.ToShortDateString());
			content.AppendLine("Mã báo cáo : " + textBox_mabaocao.Text);
			foreach (ListViewItem row in listView_theloaitheoluotmuon.Items) {
				content.Append(row.SubItems[0].Text + ',');
				content.Append(row.SubItems[1].Text + ',');
				content.Append(row.SubItems[2].Text + ',');
				content.AppendLine(row.SubItems[3].Text);
			}
			MessageBox.Show("saved to " + Printer.Print(content.ToString()));
		}
	}
}
