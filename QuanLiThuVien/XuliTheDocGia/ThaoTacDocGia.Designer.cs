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
			System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "1",
            "2",
            "3"}, -1);
			this.button_lapthedocgia = new System.Windows.Forms.Button();
			this.listView1 = new System.Windows.Forms.ListView();
			this.button_capnhatdocgia = new System.Windows.Forms.Button();
			this.button_xoadocgia = new System.Windows.Forms.Button();
			this.button_timdocgia = new System.Windows.Forms.Button();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem5});
			this.listView1.Location = new System.Drawing.Point(12, 108);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(779, 186);
			this.listView1.TabIndex = 6;
			this.listView1.UseCompatibleStateImageBehavior = false;
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
			this.button_timdocgia.Location = new System.Drawing.Point(519, 70);
			this.button_timdocgia.Name = "button_timdocgia";
			this.button_timdocgia.Size = new System.Drawing.Size(95, 32);
			this.button_timdocgia.TabIndex = 9;
			this.button_timdocgia.Text = "Tìm đọc giả";
			this.button_timdocgia.UseVisualStyleBackColor = true;
			this.button_timdocgia.Click += new System.EventHandler(this.button_timdocgia_Click);
			// 
			// ThaoTacDocGia
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(803, 306);
			this.Controls.Add(this.button_timdocgia);
			this.Controls.Add(this.button_xoadocgia);
			this.Controls.Add(this.button_capnhatdocgia);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.button_lapthedocgia);
			this.Name = "ThaoTacDocGia";
			this.Text = "ThaoTacDocGia";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button_lapthedocgia;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button button_capnhatdocgia;
		private System.Windows.Forms.Button button_xoadocgia;
		private System.Windows.Forms.Button button_timdocgia;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
	}
}