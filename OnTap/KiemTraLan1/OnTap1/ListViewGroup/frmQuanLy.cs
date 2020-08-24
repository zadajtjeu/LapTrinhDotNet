using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewGroup
{
    public partial class frmQuanLy : Form
    {
        public frmQuanLy()
        {
            InitializeComponent();
        }

        List<DanhMuc> khoHang = new List<DanhMuc>();

        private void HienThi()
        {
//
            cbDanhMuc.Items.Clear();
            lvSanPham.Items.Clear();
            foreach (DanhMuc dm in khoHang)
            {
                //Đưa danh mục vào commobox
                cbDanhMuc.Items.Add(dm);
                //Đưa sản phẩm vào listview

                //- Tạo group
                System.Windows.Forms.ListViewGroup LVG = new System.Windows.Forms.ListViewGroup(dm.tenDM, System.Windows.Forms.HorizontalAlignment.Left);
                lvSanPham.Groups.Add(LVG);
                foreach (SanPham sp in dm.sanPhams)
                {
                    //Tạo dòng listview item
                    ListViewItem item = new ListViewItem(sp.maSP);
                    item.SubItems.Add(sp.tenSP);
                    item.SubItems.Add(sp.gia+"");
                    item.Group = LVG;
                    lvSanPham.Items.Add(item);
                }

            }  
        }
        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            DanhMuc bia = new DanhMuc();
            bia.maDM = "Bia";
            bia.tenDM = "Nhóm Bia";
            khoHang.Add(bia);

            SanPham biaHNiken = new SanPham();
            biaHNiken.maSP = "sp1";
            biaHNiken.tenSP = "Heneiken";
            biaHNiken.gia = 150;
            bia.ThemSanPham(biaHNiken);
            SanPham bia33 = new SanPham();
            bia33.maSP = "sp2";
            bia33.tenSP = "333";
            bia33.gia = 250;
            bia.ThemSanPham(bia33);



            DanhMuc ruou = new DanhMuc();
            ruou.maDM = "Ruou";
            ruou.tenDM = "Nhóm Rượu";
            khoHang.Add(ruou);

            SanPham ruouDe = new SanPham();
            ruouDe.maSP = "s3";
            ruouDe.tenSP = "Rượu Đế";
            ruouDe.gia = 50;
            ruou.ThemSanPham(ruouDe);
            SanPham ruouNep = new SanPham();
            ruouNep.maSP = "sp4";
            ruouNep.tenSP = "Rượu Nếp";
            ruouNep.gia = 100;
            ruou.ThemSanPham(ruouNep);

            HienThi();

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSP = txtMaSP.Text;
            string tenSP = txtTenSP.Text;
            int giaSP = int.Parse(txtGia.Text);
            DanhMuc danhmuc = (DanhMuc)cbDanhMuc.SelectedItem;
            SanPham spThem = new SanPham(maSP, tenSP, giaSP, danhmuc);
            danhmuc.ThemSanPham(spThem);
            HienThi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count > 0)
            {

                foreach (ListViewItem item in lvSanPham.SelectedItems)
                {
                    lvSanPham.Items.Remove(item);
                } 
            }
        }

        private void lvSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count > 0)
            {
                ListViewItem item = lvSanPham.SelectedItems[0];
                txtMaSP.Text = item.SubItems[0].Text;
                txtTenSP.Text = item.SubItems[1].Text;
                txtGia.Text = item.SubItems[2].Text;

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lvSanPham.SelectedItems.Count > 0)
            {
                string maSP = txtMaSP.Text;
                string tenSP = txtTenSP.Text;
                int giaSP = int.Parse(txtGia.Text);
                DanhMuc danhmuc = (DanhMuc)cbDanhMuc.SelectedItem;
                int index = lvSanPham.Items.IndexOf(lvSanPham.SelectedItems[0]);
                //khoHang[khoHang.IndexOf(danhmuc)].sanPhams[]

            }
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            txtTenSP.Text = txtTenSP.Text = txtTenSP.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn muốn thoát?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res== DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
