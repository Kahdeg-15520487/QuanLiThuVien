namespace QuanLiThuVien {
	partial class MainForm {
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
			this.button_docgia = new System.Windows.Forms.Button();
			this.button_sach = new System.Windows.Forms.Button();
			this.button_baocao = new System.Windows.Forms.Button();
			this.button_muonsach = new System.Windows.Forms.Button();
			this.button_trasach = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button_docgia
			// 
			this.button_docgia.Location = new System.Drawing.Point(12, 12);
			this.button_docgia.Name = "button_docgia";
			this.button_docgia.Size = new System.Drawing.Size(97, 51);
			this.button_docgia.TabIndex = 0;
			this.button_docgia.Text = "Thao tác thẻ đọc giả";
			this.button_docgia.UseVisualStyleBackColor = true;
			this.button_docgia.Click += new System.EventHandler(this.button_docgia_Click);
			// 
			// button_sach
			// 
			this.button_sach.Location = new System.Drawing.Point(115, 12);
			this.button_sach.Name = "button_sach";
			this.button_sach.Size = new System.Drawing.Size(97, 51);
			this.button_sach.TabIndex = 1;
			this.button_sach.Text = "Thao tác sách";
			this.button_sach.UseVisualStyleBackColor = true;
			this.button_sach.Click += new System.EventHandler(this.button_sach_Click);
			// 
			// button_baocao
			// 
			this.button_baocao.Location = new System.Drawing.Point(424, 12);
			this.button_baocao.Name = "button_baocao";
			this.button_baocao.Size = new System.Drawing.Size(97, 51);
			this.button_baocao.TabIndex = 2;
			this.button_baocao.Text = "Báo cáo thống kê sách trả trễ";
			this.button_baocao.UseVisualStyleBackColor = true;
			this.button_baocao.Click += new System.EventHandler(this.button_baocao_Click);
			// 
			// button_muonsach
			// 
			this.button_muonsach.Location = new System.Drawing.Point(218, 12);
			this.button_muonsach.Name = "button_muonsach";
			this.button_muonsach.Size = new System.Drawing.Size(97, 51);
			this.button_muonsach.TabIndex = 3;
			this.button_muonsach.Text = "Mượn sách";
			this.button_muonsach.UseVisualStyleBackColor = true;
			this.button_muonsach.Click += new System.EventHandler(this.button_muonsach_Click);
			// 
			// button_trasach
			// 
			this.button_trasach.Location = new System.Drawing.Point(321, 12);
			this.button_trasach.Name = "button_trasach";
			this.button_trasach.Size = new System.Drawing.Size(97, 51);
			this.button_trasach.TabIndex = 4;
			this.button_trasach.Text = "Trả sách";
			this.button_trasach.UseVisualStyleBackColor = true;
			this.button_trasach.Click += new System.EventHandler(this.button_trasach_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(527, 12);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(97, 51);
			this.button6.TabIndex = 5;
			this.button6.Text = "Báo cáo thống kê thể loại theo lượt mượn";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(640, 261);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button_trasach);
			this.Controls.Add(this.button_muonsach);
			this.Controls.Add(this.button_baocao);
			this.Controls.Add(this.button_sach);
			this.Controls.Add(this.button_docgia);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button button_docgia;
		private System.Windows.Forms.Button button_sach;
		private System.Windows.Forms.Button button_baocao;
		private System.Windows.Forms.Button button_muonsach;
		private System.Windows.Forms.Button button_trasach;
		private System.Windows.Forms.Button button6;
	}
}