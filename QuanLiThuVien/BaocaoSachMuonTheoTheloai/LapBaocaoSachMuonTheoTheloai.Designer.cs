namespace QuanLiThuVien.BaocaoSachMuonTheoTheloai {
	partial class LapBaocaoSachMuonTheoTheloai {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            this.listView_theloaitheoluotmuon = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_mabaocao = new System.Windows.Forms.TextBox();
            this.dateTimePicker_ngaylapbaocao = new System.Windows.Forms.DateTimePicker();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.label3 = new MaterialSkin.Controls.MaterialLabel();
            this.label4 = new MaterialSkin.Controls.MaterialLabel();
            this.textBox_tongluotmuon = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listView_theloaitheoluotmuon
            // 
            this.listView_theloaitheoluotmuon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView_theloaitheoluotmuon.Location = new System.Drawing.Point(12, 79);
            this.listView_theloaitheoluotmuon.Name = "listView_theloaitheoluotmuon";
            this.listView_theloaitheoluotmuon.Size = new System.Drawing.Size(333, 170);
            this.listView_theloaitheoluotmuon.TabIndex = 0;
            this.listView_theloaitheoluotmuon.UseCompatibleStateImageBehavior = false;
            this.listView_theloaitheoluotmuon.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            this.columnHeader1.Width = 37;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Thể loại";
            this.columnHeader2.Width = 112;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số lượt mượn";
            this.columnHeader3.Width = 112;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tỉ lệ (%)";
            // 
            // textBox_mabaocao
            // 
            this.textBox_mabaocao.Location = new System.Drawing.Point(82, 29);
            this.textBox_mabaocao.Name = "textBox_mabaocao";
            this.textBox_mabaocao.ReadOnly = true;
            this.textBox_mabaocao.Size = new System.Drawing.Size(100, 20);
            this.textBox_mabaocao.TabIndex = 1;
            // 
            // dateTimePicker_ngaylapbaocao
            // 
            this.dateTimePicker_ngaylapbaocao.Enabled = false;
            this.dateTimePicker_ngaylapbaocao.Location = new System.Drawing.Point(82, 53);
            this.dateTimePicker_ngaylapbaocao.Name = "dateTimePicker_ngaylapbaocao";
            this.dateTimePicker_ngaylapbaocao.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_ngaylapbaocao.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã báo cáo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Báo cáo thống kê sách trả trễ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tổng lượt mượn";
            // 
            // textBox_tongluotmuon
            // 
            this.textBox_tongluotmuon.Location = new System.Drawing.Point(245, 255);
            this.textBox_tongluotmuon.Name = "textBox_tongluotmuon";
            this.textBox_tongluotmuon.ReadOnly = true;
            this.textBox_tongluotmuon.Size = new System.Drawing.Size(100, 20);
            this.textBox_tongluotmuon.TabIndex = 9;
            // 
            // LapBaocaoSachMuonTheoTheloai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 286);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_tongluotmuon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker_ngaylapbaocao);
            this.Controls.Add(this.textBox_mabaocao);
            this.Controls.Add(this.listView_theloaitheoluotmuon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LapBaocaoSachMuonTheoTheloai";
            this.Text = "LapBaocaoSachMuonTheoTheloai";
            this.Load += new System.EventHandler(this.LapBaocaoSachMuonTheoTheloai_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listView_theloaitheoluotmuon;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.TextBox textBox_mabaocao;
		private System.Windows.Forms.DateTimePicker dateTimePicker_ngaylapbaocao;
		private MaterialSkin.Controls.MaterialLabel label1;
		private MaterialSkin.Controls.MaterialLabel label2;
		private MaterialSkin.Controls.MaterialLabel label3;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private MaterialSkin.Controls.MaterialLabel label4;
		private System.Windows.Forms.TextBox textBox_tongluotmuon;
	}
}