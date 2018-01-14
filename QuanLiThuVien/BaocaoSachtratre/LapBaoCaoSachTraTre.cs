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
	public partial class LapBaoCaoSachTraTre : Form {
		public LapBaoCaoSachTraTre() {
			InitializeComponent();
		}

		private void LapBaoCaoSachTraTre_Load(object sender, EventArgs e) {
			//tạo mã báo cáo
			textBox_mabaocao.Text = DataAccess.RandomIdGenerator.GetBase36(10);
			dateTimePicker_ngaylapbaocao.Value = DateTime.Now;
			//lấy số ngày mượn tối đa từ quy định
			var songaymuontoida = int.Parse(DataAccess.Database.GetQuyDinh(x => x.TenQuiDinh == "SoNgaymuonToida").NoiDungQuiDinh);
			//querry những lượt mượn sách mà có số ngày mượn lớn hơn số ngày mượn tối đa
			var danhsacthongtinmuonsach = DataAccess.Database.GetThongTinMuonSachs
				(x => DateTime.Now.AddDays(songaymuontoida) > x.NgayMuon).ToList();
			//hiển thị thông tin lên listview
			foreach (var ttms in danhsacthongtinmuonsach) {
				ListViewItem lvi = new ListViewItem(listView_sachtratre.Items.Count.ToString());
				lvi.SubItems.Add(ttms.Sach.MaSach);
				lvi.SubItems.Add(ttms.DocGia.MaTheDG);
				lvi.SubItems.Add(ttms.NgayMuon.ToShortDateString());
				lvi.SubItems.Add((DateTime.Now - ttms.NgayMuon.AddDays(songaymuontoida)).TotalDays.ToString());
				listView_sachtratre.Items.Add(lvi);
			}
			//tạo báo cáo để lưu vào csdl
			var baocao = new DataAccess.DataObject.BaocaoThongkeSachTraTre() {
				MaBaoCao = textBox_mabaocao.Text,
				NgayLapBaoCao = dateTimePicker_ngaylapbaocao.Value,
				DanhsachSachTraTre = danhsacthongtinmuonsach
			};
			//insert vao csdl
			DataAccess.Database.AddBaocaoThongkeSachTraTre(baocao);
		}
	}
}
