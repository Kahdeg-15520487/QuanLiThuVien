namespace QuanLiThuVien.XuliTheDocGia {
	partial class ThaoTacDocGia {
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
			this.button_lapthedocgia = new System.Windows.Forms.Button();
			this.listView_docgia = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.button_capnhatdocgia = new System.Windows.Forms.Button();
			this.button_xoadocgia = new System.Windows.Forms.Button();
			this.button_timdocgia = new System.Windows.Forms.Button();
			this.textBox_MaDocGia = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button_lapthedocgia
			// 
			this.button_lapthedocgia.Location = new System.Drawing.Point(12, 12);
			this.button_lapthedocgia.Name = "button_lapthedocgia";
			this.button_lapthedocgia.Size = new System.Drawing.Size(95, 32);
			this.button_lapthedocgia.TabIndex = 0;
			this.button_lapthedocgia.Text = "Thêm đọc giả";
			this.button_lapthedocgia.UseVisualStyleBackColor = true;
			this.button_lapthedocgia.Click += new System.EventHandler(this.button_lapthedocgia_Click);
			// 
			// listView_docgia
			// 
			this.listView_docgia.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
			this.listView_docgia.FullRowSelect = true;
			this.listView_docgia.Location = new System.Drawing.Point(12, 88);
			this.listView_docgia.Name = "listView_docgia";
			this.listView_docgia.Size = new System.Drawing.Size(534, 206);
			this.listView_docgia.TabIndex = 6;
			this.listView_docgia.UseCompatibleStateImageBehavior = false;
			this.listView_docgia.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "STT";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Mã đọc giả";
			this.columnHeader2.Width = 87;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Họ tên";
			this.columnHeader3.Width = 119;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Loại đọc giả";
			this.columnHeader4.Width = 73;
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Ngày hết hạn thẻ";
			this.columnHeader5.Width = 97;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Tổng nợ";
			this.columnHeader6.Width = 69;
			// 
			// button_capnhatdocgia
			// 
			this.button_capnhatdocgia.Location = new System.Drawing.Point(113, 12);
			this.button_capnhatdocgia.Name = "button_capnhatdocgia";
			this.button_capnhatdocgia.Size = new System.Drawing.Size(100, 32);
			this.button_capnhatdocgia.TabIndex = 7;
			this.button_capnhatdocgia.Text = "Cập nhật đọc giả";
			this.button_capnhatdocgia.UseVisualStyleBackColor = true;
			this.button_capnhatdocgia.Click += new System.EventHandler(this.button_capnhatdocgia_Click);
			// 
			// button_xoadocgia
			// 
			this.button_xoadocgia.Location = new System.Drawing.Point(219, 12);
			this.button_xoadocgia.Name = "button_xoadocgia";
			this.button_xoadocgia.Size = new System.Drawing.Size(95, 32);
			this.button_xoadocgia.TabIndex = 8;
			this.button_xoadocgia.Text = "Xóa đọc giả";
			this.button_xoadocgia.UseVisualStyleBackColor = true;
			this.button_xoadocgia.Click += new System.EventHandler(this.button_xoadocgia_Click);
			// 
			// button_timdocgia
			// 
			this.button_timdocgia.Location = new System.Drawing.Point(219, 50);
			this.button_timdocgia.Name = "button_timdocgia";
			this.button_timdocgia.Size = new System.Drawing.Size(95, 32);
			this.button_timdocgia.TabIndex = 9;
			this.button_timdocgia.Text = "Tìm đọc giả";
			this.button_timdocgia.UseVisualStyleBackColor = true;
			this.button_timdocgia.Click += new System.EventHandler(this.button_timdocgia_Click);
			// 
			// textBox_MaDocGia
			// 
			this.textBox_MaDocGia.Location = new System.Drawing.Point(113, 57);
			this.textBox_MaDocGia.Name = "textBox_MaDocGia";
			this.textBox_MaDocGia.Size = new System.Drawing.Size(100, 20);
			this.textBox_MaDocGia.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(46, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Mã độc giả";
			// 
			// ThaoTacDocGia
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(558, 306);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox_MaDocGia);
			this.Controls.Add(this.button_timdocgia);
			this.Controls.Add(this.button_xoadocgia);
			this.Controls.Add(this.button_capnhatdocgia);
			this.Controls.Add(this.listView_docgia);
			this.Controls.Add(this.button_lapthedocgia);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "ThaoTacDocGia";
			this.Text = "ThaoTacDocGia";
			this.Load += new System.EventHandler(this.ThaoTacDocGia_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button_lapthedocgia;
		private System.Windows.Forms.ListView listView_docgia;
		private System.Windows.Forms.Button button_capnhatdocgia;
		private System.Windows.Forms.Button button_xoadocgia;
		private System.Windows.Forms.Button button_timdocgia;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.TextBox textBox_MaDocGia;
		private System.Windows.Forms.Label label1;
	}
}