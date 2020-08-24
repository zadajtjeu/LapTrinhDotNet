using QuanLySinhVien.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class fromQLSinhVien : Form
    {
        public fromQLSinhVien()
        {
            InitializeComponent();
        }

        List<Khoa> DataBase = new List<Khoa>();

        private void HienThiTreeView()
        {
            tvKhoaLop.Nodes.Clear();
            foreach (Khoa khoa in DataBase)
            {
                TreeNode nodeKhoa = new TreeNode(khoa.tenKhoa);
                nodeKhoa.Tag = khoa;
                tvKhoaLop.Nodes.Add(nodeKhoa);

                foreach(LopHoc lop in khoa.dsLop)
                {
                    TreeNode nodeLop = new TreeNode(lop.tenLop);
                    nodeLop.Tag = lop;
                    nodeKhoa.Nodes.Add(nodeLop);
                }    
            }
            tvKhoaLop.ExpandAll();
        }

        private void DuLieuMau()
        {
            //Tạo thông tin khoa
            Khoa cntt = new Khoa("CNTT", "Công Nghệ Thông Tin");
            Khoa dientu = new Khoa("DIEN", "Điện Tử");
            Khoa kt = new Khoa("KT", "Kinh Tế");
            Khoa dl = new Khoa("DL", "Du Lịch");
            //Thên khoa vào danh sách
            DataBase.Add(cntt);
            DataBase.Add(dientu);
            DataBase.Add(kt);
            DataBase.Add(dl);

            //Tạo các lớp học khoa CNTT
            LopHoc lopcntt = new LopHoc("CNTT", "Công Nghệ Thông Tin", "Trần Mai Linh");
            lopcntt.khoaChuQuan = cntt;
            LopHoc lopktpm = new LopHoc("KTPM", "Kỹ Thuật Phần Mềm", "Trần Mai Linh");
            lopktpm.khoaChuQuan = cntt;
            LopHoc lopkhmt = new LopHoc("KHMT", "Khoa Học Máy Tính", "Vũ Thị Mai");
            lopktpm.khoaChuQuan = cntt;
            //Têm lớp vào khoa
            cntt.dsLop.Add(lopcntt);
            cntt.dsLop.Add(lopktpm);
            cntt.dsLop.Add(lopkhmt);

            //Tạo lớp khoa điện
            LopHoc lopdien = new LopHoc("DIEN", "Điện Công Nghiệp", "Trần Đông A");
            lopdien.khoaChuQuan = dientu;
            LopHoc lopdtth = new LopHoc("DTTT", "Điện Tử Truyền Thông", "Trần ABC");
            lopdtth.khoaChuQuan = dientu;
            //Thêm lớp
            dientu.dsLop.Add(lopdien);
            dientu.dsLop.Add(lopdtth);

            //Tạo lớp khoa du lịch
            LopHoc lopluhanh = new LopHoc("LH", "Lữ Hành", "ABC");
            lopluhanh.khoaChuQuan = dl;
            LopHoc lopks = new LopHoc("KS", "Khách Sạn", "Trần ABC");
            lopks.khoaChuQuan = dl;
            //Thêm lớp
            dl.dsLop.Add(lopluhanh);
            dl.dsLop.Add(lopks);


            /* Thêm Học Sinh */
            List<SinhVien> dssv = new List<SinhVien>();
            //Sinh Viên lớp CNTT
            dssv.Add(new SinhVien("SV1","Nguyễn Hoàng Anh", new DateTime(2000,03,10), true, lopcntt));
            dssv.Add(new SinhVien("SV2", "Phạm Đông A", new DateTime(2000, 11, 21), true, lopcntt));
            dssv.Add(new SinhVien("SV3", "Tiểu Bá Quý", new DateTime(2000, 6, 1), true, lopcntt));
            dssv.Add(new SinhVien("SV4", "Ngô Văn Dân", new DateTime(2000, 09, 12), true, lopcntt));
            dssv.Add(new SinhVien("SV5", "Nguyền Phước Toàn", new DateTime(2000, 12, 11), true, lopcntt));
            dssv.Add(new SinhVien("SV6", "Nguyễn Vân Vân", new DateTime(2000, 2, 28), false, lopcntt));

            lopcntt.dsSinhVien = dssv;
            //Sinh Viên lớp KTPM
            List<SinhVien> dssv1 = new List<SinhVien>();
            dssv1.Add(new SinhVien("SV7", "Hồ Quang Đại", new DateTime(2000, 06, 19), true, lopktpm));
            dssv1.Add(new SinhVien("SV8", "Nhâm Văn Tuất", new DateTime(2000, 7, 28), true, lopktpm));
            dssv1.Add(new SinhVien("SV9", "Nguyền Thi Nụ", new DateTime(2000, 8, 2), false, lopktpm));
            lopktpm.dsSinhVien = dssv1;
        }

        private void fromQLSinhVien_Load(object sender, EventArgs e)
        {
            DuLieuMau();
            HienThiTreeView();
            HienThiCommoBoxKhoa();
        }

        private void tvKhoaLop_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if(e.Node != null)
            {
                if (e.Node.Level == 1)
                {
                    LopHoc lp = e.Node.Tag as LopHoc;
                    HienThilvDSSV(lp);
                }
                else
                {
                    lvSinhVien.Items.Clear();
                }
            }    
        }

        private void HienThilvDSSV(LopHoc lp)
        {
            lvSinhVien.Items.Clear();
            foreach (SinhVien sv in lp.dsSinhVien)
            {
                ListViewItem svView = new ListViewItem(sv.maSV);
                svView.SubItems.Add(sv.tenSV);
                svView.SubItems.Add(sv.ngaySinh.ToString("dd/MM/yyyy"));
                svView.SubItems.Add(sv.gioiTinh == true ? "Nam" : "Nữ");
                svView.Tag = sv;
                lvSinhVien.Items.Add(svView);
            }
        }

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvSinhVien.SelectedItems.Count > 0)
            {
                SinhVien sv = lvSinhVien.SelectedItems[0].Tag as SinhVien;
                txtMaSV.Text = sv.maSV;
                txtTenSV.Text = sv.tenSV;
                dateTimePickerNS.Value = sv.ngaySinh;
                cbKhoa.SelectedItem = sv.lopHoc.khoaChuQuan;
                cbLop.SelectedItem = sv.lopHoc;
            }    
        }

        private void HienThiCommoBoxKhoa()
        {
            cbKhoa.Items.Clear();
            //Đổ dữ liệu commobox
            foreach (Khoa itemKhoa in DataBase)
            {
                cbKhoa.Items.Add(itemKhoa);
            }
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbKhoa.SelectedItem != null)
            {
                Khoa iKhoa = cbKhoa.SelectedItem as Khoa;
                cbLop.Items.Clear();
                foreach (LopHoc lop in iKhoa.dsLop)
                {
                    cbLop.Items.Add(lop);
                }
            }
            else
            {
                cbLop.Items.Clear();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maSV = txtMaSV.Text;

            string tenSV = txtTenSV.Text;
            DateTime ngaySinh = dateTimePickerNS.Value;
            bool gioiTinh = true;
            if (radNam.Checked == true)
                gioiTinh = true;
            else if (radNu.Checked == true)
                gioiTinh = false;
            LopHoc lop = cbLop.SelectedItem as LopHoc;
            Khoa khoa = cbKhoa.SelectedItem as Khoa;

            SinhVien sv = new SinhVien(maSV, tenSV, ngaySinh, gioiTinh, lop);
            lop.dsSinhVien.Add(sv);
            ClearAll();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvSinhVien.SelectedItems.Count > 0)
            {
                SinhVien sv = lvSinhVien.SelectedItems[0].Tag as SinhVien;
                LopHoc lop = sv.lopHoc;
                lop.dsSinhVien.Remove(sv);
                HienThilvDSSV(lop); 
            }
            ClearAll();
        }

        // Xóa rỗng
        private void ClearAll()
        {
            txtMaSV.Text = txtTenSV.Text = String.Empty;
            dateTimePickerNS.Value = DateTime.Now;
            cbLop.SelectedItem = null;
            cbKhoa.SelectedItem = null;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn muốn thoát?", "Thoát",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
                Close();
        }
    }
}
