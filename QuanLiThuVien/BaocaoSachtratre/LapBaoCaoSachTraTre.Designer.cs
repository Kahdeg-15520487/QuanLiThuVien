﻿namespace QuanLiThuVien.BaocaoSachtratre {
	partial class LapBaoCaoSachTraTre {
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
			this.listView_sachtratre = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.textBox_mabaocao = new System.Windows.Forms.TextBox();
			this.dateTimePicker_ngaylapbaocao = new System.Windows.Forms.DateTimePicker();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// listView_sachtratre
			// 
			this.listView_sachtratre.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
			this.listView_sachtratre.Location = new System.Drawing.Point(12, 79);
			this.listView_sachtratre.Name = "listView_sachtratre";
			this.listView_sachtratre.Size = new System.Drawing.Size(473, 170);
			this.listView_sachtratre.TabIndex = 0;
			this.listView_sachtratre.UseCompatibleStateImageBehavior = false;
			this.listView_sachtratre.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "STT";
			this.columnHeader1.Width = 37;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Mã sách";
			this.columnHeader2.Width = 112;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Mã đọc giả mượn";
			this.columnHeader3.Width = 112;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Ngày mượn";
			this.columnHeader4.Width = 98;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Số ngày trả trễ";
			this.columnHeader5.Width = 98;
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
			// LapBaoCaoSachTraTre
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(497, 261);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dateTimePicker_ngaylapbaocao);
			this.Controls.Add(this.textBox_mabaocao);
			this.Controls.Add(this.listView_sachtratre);
			this.Name = "LapBaoCaoSachTraTre";
			this.Text = "LapBaoCaoSachTraTre";
			this.Load += new System.EventHandler(this.LapBaoCaoSachTraTre_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listView_sachtratre;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.TextBox textBox_mabaocao;
		private System.Windows.Forms.DateTimePicker dateTimePicker_ngaylapbaocao;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ColumnHeader columnHeader3;
	}
}