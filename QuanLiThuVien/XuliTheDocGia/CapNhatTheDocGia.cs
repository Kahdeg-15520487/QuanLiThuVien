using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DataAccess;

namespace QuanLiThuVien.XuliTheDocGia {
	public partial class CapNhatTheDocGia : Form {
		public CapNhatTheDocGia() {
			InitializeComponent();
		}

		private void textBox_MaDocGia_TextChanged(object sender, EventArgs e) {
			if (textBox_MaDocGia.Text.Length == 10) {
				//querry database
			}
		}

		private void button_LapThe_Click(object sender, EventArgs e) {

		}

		private void button_Huy_Click(object sender, EventArgs e) {
			Close();
		}
	}
}
