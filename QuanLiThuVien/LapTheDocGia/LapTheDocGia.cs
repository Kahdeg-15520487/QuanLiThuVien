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

namespace QuanLiThuVien {
	public partial class LapTheDocGia : Form {
		public LapTheDocGia() {
			InitializeComponent();
		}

		private void LapTheDocGia_Load(object sender, EventArgs e) {
			textBox_MaDocGia.Text = RandomIdGenerator.GetBase36(10);
			//groupBox_LoaiDocGia.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
		}
	}
}
