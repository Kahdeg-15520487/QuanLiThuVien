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

		}

		private void button_xoadocgia_Click(object sender, EventArgs e) {

		}

		private void button_timdocgia_Click(object sender, EventArgs e) {
			throw new NotImplementedException();
		}
	}
}
