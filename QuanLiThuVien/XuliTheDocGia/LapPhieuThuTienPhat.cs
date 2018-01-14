using System;
using System.Windows.Forms;

namespace QuanLiThuVien.XuliTheDocGia {
	public partial class LapPhieuThuTienPhat : Form {
		private DataAccess.DataObject.DocGia docgia;

		public LapPhieuThuTienPhat(string madocgia) {
			InitializeComponent();
			docgia = DataAccess.Database.GetDocGia(madocgia);
			textBox_sotienthu.Focus();
		}

		private void LapPhieuThuTien_Load(object sender, EventArgs e) {

			textBox_madocgia.Text = docgia.MaTheDG;
			textBox_hoten.Text = docgia.HoTen;
			textBox_tongno.Text = docgia.TongNo.ToString();
			textBox_sotienthu.Text = "0";
		}

		private void button_lapphieuthutienphat_Click(object sender, EventArgs e) {
			var sotienthu = int.Parse(textBox_sotienthu.Text);
			if (sotienthu == 0) {
				MessageBox.Show(string.Format("Không thể thu {0} VND", sotienthu));
				return;
			}

			var phieuthutienphat = new DataAccess.DataObject.PhieuThuTienPhat() {
				MaPhieuThuTienPhat = DataAccess.RandomIdGenerator.GetBase36(10),
				DocGia = docgia,
				SoTienThu = sotienthu
			};
			DataAccess.Database.AddPhieuThuTienPhat(phieuthutienphat);
			docgia.TongNo -= sotienthu;
			DataAccess.Database.SetDocGia(docgia);

			var isprint = MessageBox.Show("Đã tạo phiếu thu tiền phạt" + Environment.NewLine + "Bạn có muốn in ra?", "", MessageBoxButtons.YesNo);
			if (isprint == DialogResult.Yes) {
				Printer.Print(phieuthutienphat.ToString());
			}
			Close();
		}

		private void button_huy_Click(object sender, EventArgs e) {
			Close();
		}

		private void textBox_sotienthu_TextChanged(object sender, EventArgs e) {
			if (int.TryParse(textBox_sotienthu.Text, out int sotienthu)) {
				if (sotienthu < 0) {
					textBox_sotienthu.Undo();
					return;
				}
				if (sotienthu > docgia.TongNo) {
					textBox_sotienthu.Text = docgia.TongNo.ToString();
					return;
				}
				textBox_noconlai.Text = (docgia.TongNo - sotienthu).ToString();
			}
			else {
				textBox_sotienthu.Undo();
			}
		}
	}
}
