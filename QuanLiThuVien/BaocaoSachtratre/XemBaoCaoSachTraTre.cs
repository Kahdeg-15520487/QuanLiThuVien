using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiThuVien.BaocaoSachtratre {
	public partial class XemBaoCaoSachTraTre: MaterialSkin.Controls.MaterialForm {
		private string mabaocao;
		public XemBaoCaoSachTraTre(string mabaocao) {
			InitializeComponent();

            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey800, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.LightBlue200, MaterialSkin.TextShade.WHITE);
            this.mabaocao = mabaocao;
		}

		private void XemBaoCaoSachTraTre_Load(object sender, EventArgs e) {
			//lấy số ngày mượn tối đa từ quy định
			var songaymuontoida = int.Parse(DataAccess.Database.GetQuyDinh(x => x.TenQuiDinh == "SoNgaymuonToida").NoiDungQuiDinh);
			//truy xuất báo cáo từ csdl
			textBox_mabaocao.Text = mabaocao;
			var baocao = DataAccess.Database.GetBaocaoThongkeSachTraTre(mabaocao);
			dateTimePicker_ngaylapbaocao.Value = baocao.NgayLapBaoCao;
			//hiển thị thông tin lên listview
			foreach (var ttms in baocao.DanhsachSachTraTre) {
				ListViewItem lvi = new ListViewItem(listView_sachtratre.Items.Count.ToString());
				lvi.SubItems.Add(ttms.Sach.MaSach);
				lvi.SubItems.Add(ttms.DocGia.MaTheDG);
				lvi.SubItems.Add(ttms.NgayMuon.ToShortDateString());
				lvi.SubItems.Add((DateTime.Now - ttms.NgayMuon.AddDays(songaymuontoida)).TotalDays.ToString());
				listView_sachtratre.Items.Add(lvi);
			}
		}

		private void button_inbaocao_Click(object sender, EventArgs e) {
			StringBuilder content = new StringBuilder();
			content.AppendLine("Báo cáo thống kê sách trả trễ");
			content.AppendLine("Ngày " + dateTimePicker_ngaylapbaocao.Value.ToShortDateString());
			content.AppendLine("Mã báo cáo : " + textBox_mabaocao.Text);
			foreach (ListViewItem row in listView_sachtratre.Items) {
				content.Append(row.SubItems[0].Text + ',');
				content.Append(row.SubItems[1].Text + ',');
				content.Append(row.SubItems[2].Text + ',');
				content.Append(row.SubItems[3].Text + ',');
				content.AppendLine(row.SubItems[4].Text);
			}
			MessageBox.Show("saved to " + Printer.Print(content.ToString()));
		}
	}
}
