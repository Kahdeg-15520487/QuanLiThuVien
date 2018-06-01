namespace QuanLiThuVien.XuliSach {
	partial class QuanLiSach {
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
            this.components = new System.ComponentModel.Container();
            this.button_lapthedocgia = new MaterialSkin.Controls.MaterialRaisedButton();
            this.listView_danhsachsach = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_capnhatdocgia = new MaterialSkin.Controls.MaterialRaisedButton();
            this.button_xoadocgia = new MaterialSkin.Controls.MaterialRaisedButton();
            this.button_timdocgia = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textBox_MaDocGia = new System.Windows.Forms.TextBox();
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_copyMaSach = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_lapthedocgia
            // 
            this.button_lapthedocgia.Depth = 0;
            this.button_lapthedocgia.Location = new System.Drawing.Point(12, 66);
            this.button_lapthedocgia.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_lapthedocgia.Name = "button_lapthedocgia";
            this.button_lapthedocgia.Primary = true;
            this.button_lapthedocgia.Size = new System.Drawing.Size(95, 39);
            this.button_lapthedocgia.TabIndex = 1;
            this.button_lapthedocgia.Text = "Thêm sách";
            this.button_lapthedocgia.UseVisualStyleBackColor = true;
            this.button_lapthedocgia.Click += new System.EventHandler(this.button_lapthedocgia_Click);
            // 
            // listView_danhsachsach
            // 
            this.listView_danhsachsach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView_danhsachsach.FullRowSelect = true;
            this.listView_danhsachsach.HideSelection = false;
            this.listView_danhsachsach.Location = new System.Drawing.Point(12, 149);
            this.listView_danhsachsach.Name = "listView_danhsachsach";
            this.listView_danhsachsach.Size = new System.Drawing.Size(534, 206);
            this.listView_danhsachsach.TabIndex = 5;
            this.listView_danhsachsach.UseCompatibleStateImageBehavior = false;
            this.listView_danhsachsach.View = System.Windows.Forms.View.Details;
            this.listView_danhsachsach.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_docgia_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Mã sách";
            this.columnHeader2.Width = 87;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên sách";
            this.columnHeader3.Width = 119;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thể loại";
            this.columnHeader4.Width = 73;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tác giả";
            this.columnHeader5.Width = 97;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tình trạng";
            this.columnHeader6.Width = 69;
            // 
            // button_capnhatdocgia
            // 
            this.button_capnhatdocgia.Depth = 0;
            this.button_capnhatdocgia.Location = new System.Drawing.Point(113, 66);
            this.button_capnhatdocgia.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_capnhatdocgia.Name = "button_capnhatdocgia";
            this.button_capnhatdocgia.Primary = true;
            this.button_capnhatdocgia.Size = new System.Drawing.Size(100, 39);
            this.button_capnhatdocgia.TabIndex = 2;
            this.button_capnhatdocgia.Text = "Cập nhật sách";
            this.button_capnhatdocgia.UseVisualStyleBackColor = true;
            this.button_capnhatdocgia.Click += new System.EventHandler(this.button_capnhatdocgia_Click);
            // 
            // button_xoadocgia
            // 
            this.button_xoadocgia.Depth = 0;
            this.button_xoadocgia.Location = new System.Drawing.Point(219, 66);
            this.button_xoadocgia.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_xoadocgia.Name = "button_xoadocgia";
            this.button_xoadocgia.Primary = true;
            this.button_xoadocgia.Size = new System.Drawing.Size(95, 39);
            this.button_xoadocgia.TabIndex = 3;
            this.button_xoadocgia.Text = "Xóa sách";
            this.button_xoadocgia.UseVisualStyleBackColor = true;
            this.button_xoadocgia.Click += new System.EventHandler(this.button_xoadocgia_Click);
            // 
            // button_timdocgia
            // 
            this.button_timdocgia.Depth = 0;
            this.button_timdocgia.Location = new System.Drawing.Point(219, 111);
            this.button_timdocgia.MouseState = MaterialSkin.MouseState.HOVER;
            this.button_timdocgia.Name = "button_timdocgia";
            this.button_timdocgia.Primary = true;
            this.button_timdocgia.Size = new System.Drawing.Size(95, 32);
            this.button_timdocgia.TabIndex = 4;
            this.button_timdocgia.Text = "Tìm sách";
            this.button_timdocgia.UseVisualStyleBackColor = true;
            this.button_timdocgia.Click += new System.EventHandler(this.button_timdocgia_Click);
            // 
            // textBox_MaDocGia
            // 
            this.textBox_MaDocGia.Location = new System.Drawing.Point(113, 118);
            this.textBox_MaDocGia.Name = "textBox_MaDocGia";
            this.textBox_MaDocGia.Size = new System.Drawing.Size(100, 20);
            this.textBox_MaDocGia.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 119);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã sách";
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_copyMaSach});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(150, 26);
            // 
            // toolStripMenuItem_copyMaSach
            // 
            this.toolStripMenuItem_copyMaSach.Name = "toolStripMenuItem_copyMaSach";
            this.toolStripMenuItem_copyMaSach.Size = new System.Drawing.Size(149, 22);
            this.toolStripMenuItem_copyMaSach.Text = "Copy mã sách";
            this.toolStripMenuItem_copyMaSach.Click += new System.EventHandler(this.toolStripMenuItem_copyMaSach_Click);
            // 
            // QuanLiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 367);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_MaDocGia);
            this.Controls.Add(this.button_timdocgia);
            this.Controls.Add(this.button_xoadocgia);
            this.Controls.Add(this.button_capnhatdocgia);
            this.Controls.Add(this.listView_danhsachsach);
            this.Controls.Add(this.button_lapthedocgia);
            this.Name = "QuanLiSach";
            this.Text = "Thao tac sach";
            this.Load += new System.EventHandler(this.ThaoTacDocGia_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private MaterialSkin.Controls.MaterialRaisedButton button_lapthedocgia;
		private System.Windows.Forms.ListView listView_danhsachsach;
		private MaterialSkin.Controls.MaterialRaisedButton button_capnhatdocgia;
		private MaterialSkin.Controls.MaterialRaisedButton button_xoadocgia;
		private MaterialSkin.Controls.MaterialRaisedButton button_timdocgia;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.TextBox textBox_MaDocGia;
		private MaterialSkin.Controls.MaterialLabel label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_copyMaSach;
    }
}