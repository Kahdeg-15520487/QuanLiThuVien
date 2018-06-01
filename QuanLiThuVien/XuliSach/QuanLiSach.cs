using QuanLiThuVien.XuliTheDocGia;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace QuanLiThuVien.XuliSach
{
    public partial class QuanLiSach: MaterialSkin.Controls.MaterialForm
    {
        public QuanLiSach()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey800, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.LightBlue200, MaterialSkin.TextShade.WHITE);
        }

        private void button_lapthedocgia_Click(object sender, EventArgs e)
        {
            new LapSach().ShowDialog();
            PopulateListView(GetAll());
            //update listview
        }

        private void button_capnhatdocgia_Click(object sender, EventArgs e)
        {
            var slvis = listView_danhsachsach.SelectedItems;
            foreach (ListViewItem slvi in slvis)
            {
                var masach = slvi.SubItems[1].Text;
                new CapNhatSach(masach).ShowDialog();
            }
            PopulateListView(GetAll());
            //get selected item
            //new CapNhatTheDocGia().Show();
            //update listview
        }

        private void button_xoadocgia_Click(object sender, EventArgs e)
        {
            var slvis = listView_danhsachsach.SelectedItems;
            var danhsachsachcanxoa = new List<string>();
            foreach (ListViewItem slvi in slvis)
            {
                danhsachsachcanxoa.Add(slvi.SubItems[1].Text);
            }

            var result = MessageBox.Show("Bạn có muốn xóa những sách sau?\n" + string.Join("\n", danhsachsachcanxoa), "Xóa sách", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }

            StringBuilder deletedsach = new StringBuilder();
            deletedsach.AppendLine("Đã xóa các sách có mã: ");
            foreach (var masach in danhsachsachcanxoa)
            {
                DataAccess.Database.RemoveSach(masach);
                deletedsach.AppendLine(masach);
            }
            MessageBox.Show(deletedsach.ToString());
            PopulateListView(GetAll());
            //get selected item
            //delete from database
            //update listview
        }

        private void button_timdocgia_Click(object sender, EventArgs e)
        {
            if (textBox_MaDocGia.Text.Length != 10)
            {
                MessageBox.Show("Mã đọc giả không hợp lệ");
                return;
            }
            PopulateListView(GetQuerry(x => x.MaSach == textBox_MaDocGia.Text));
            //generate querry, just querry madg for now
            //update listview
        }

        private void ThaoTacDocGia_Load(object sender, EventArgs e)
        {
            PopulateListView(GetAll());
        }

        private void PopulateListView(List<ListViewItem> lvis)
        {
            listView_danhsachsach.Items.Clear();
            foreach (var lvi in lvis)
            {
                listView_danhsachsach.Items.Add(lvi);
            }
        }

        private List<ListViewItem> GetAll()
        {
            var lvis = new List<ListViewItem>();
            foreach (var dg in DataAccess.Database.GetAllSach())
            {
                ListViewItem item = new ListViewItem(lvis.Count.ToString());
                item.SubItems.Add(dg.MaSach);
                item.SubItems.Add(dg.TenSach);
                item.SubItems.Add(dg.TheLoai.TenTheLoai);
                item.SubItems.Add(dg.TacGia.TenTacGia);
                item.SubItems.Add(dg.TinhTrang);
                lvis.Add(item);
            }
            return lvis;
        }

        private List<ListViewItem> GetQuerry(Expression<Func<DataAccess.DataObject.Sach, bool>> dieukienloc)
        {
            var lvis = new List<ListViewItem>();
            foreach (var dg in DataAccess.Database.GetSachs(dieukienloc))
            {
                ListViewItem item = new ListViewItem(lvis.Count.ToString());
                item.SubItems.Add(dg.MaSach);
                item.SubItems.Add(dg.TenSach);
                item.SubItems.Add(dg.TheLoai.TenTheLoai);
                item.SubItems.Add(dg.TacGia.TenTacGia);
                item.SubItems.Add(dg.TinhTrang);
                lvis.Add(item);
            }
            return lvis;
        }

        private void listView_docgia_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView_danhsachsach.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    contextMenuStrip.Show(Cursor.Position);
                }
            }
        }

        private void toolStripMenuItem_copyMaSach_Click(object sender, EventArgs e)
        {
            var masach = listView_danhsachsach.SelectedItems[0].SubItems[1].Text;
            Clipboard.SetText(masach);
        }
    }
}
