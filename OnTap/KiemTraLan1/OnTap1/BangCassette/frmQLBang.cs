using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BangCassette
{
    public partial class frmQLBang : Form
    {
        private List<BANG> lstBang = new List<BANG>();
        public frmQLBang()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            bool checkFailed = false;
            string tuaDe = txtTuaDe.Text;
            if(tuaDe == String.Empty)
            {
                erpCheckField.SetError(txtTuaDe, "Trường này không được để trống!");
                checkFailed = true;
            }

            string NXB = txtNXB.Text;
            if (NXB == String.Empty)
            {
                erpCheckField.SetError(txtNXB, "Trường này không được để trống!");
                checkFailed = true;
            }

            ulong giaCa = 0;
            if(txtGiaCa.Text == "" || ulong.TryParse(txtGiaCa.Text, out giaCa) == false || giaCa < 0)
            {
                erpCheckField.SetError(txtGiaCa, "Giá cả phải là số dương, vd: 100000.");
                checkFailed = true;
            }

            uint thoiLuong = 0;
            if (txtThoiLuong.Text == "" || uint.TryParse(txtThoiLuong.Text, out thoiLuong) == false || thoiLuong < 0)
            {
                erpCheckField.SetError(txtThoiLuong, "Thời lượng phải là số dương, vd: 120 = 2 tiếng.");
                checkFailed = true;
            }

            string loaiDia = txtLoaiDia.Text;
            if (loaiDia == String.Empty || (loaiDia.ToUpper() != "DVD" && loaiDia.ToUpper() != "CD") )
            {
                erpCheckField.SetError(txtLoaiDia, "Trường này không được để trống! Phải là đĩa DVD hoặc đĩa CD.");
                checkFailed = true;
            }

            if(checkFailed == false)
            {
                BANG diaMoi = new BANG(tuaDe, NXB, giaCa, thoiLuong, loaiDia);
                lstBang.Add(diaMoi);
                fnClear();
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            fnClear();
        }
        private void fnClear()
        {
            txtTuaDe.Text = txtNXB.Text = txtGiaCa.Text =
                txtThoiLuong.Text = txtLoaiDia.Text = String.Empty;
            txtTuaDe.Focus();
        }

        private void HienThiDanhSach()
        {
            lstvDanhSach.Items.Clear();
            foreach (BANG item in lstBang)
            {
                ListViewItem itemview = new ListViewItem();
                itemview.Text = item.tuaDe;
                itemview.SubItems.Add(item.nhaXuatBan);
                itemview.SubItems.Add(item.giaCa.ToString());
                itemview.SubItems.Add(item.thoiLuong.ToString());
                itemview.SubItems.Add(item.loaiDia);
                lstvDanhSach.Items.Add(itemview);
            }
        }
        private void btnHienThi_Click(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            lstBang.Sort();
            HienThiDanhSach();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn muốn thoát?", "Exit!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rs == DialogResult.Yes)
                Close();
        }
    }
}
