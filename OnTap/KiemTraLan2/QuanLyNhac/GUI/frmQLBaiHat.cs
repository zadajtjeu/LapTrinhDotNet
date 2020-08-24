using BULs;
using DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmQLBaiHat : Form
    {
        public frmQLBaiHat()
        {
            InitializeComponent();
        }

        private void frmQLBaiHat_Load(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void ResetFields()
        {
            txtMaBH.Text = "";
            txtTenBH.Text = "";
            txtAlbum.Text = "";
            dtpNgay.Value = DateTime.Now;
            ShowComboBox();
            ShowDGVBaiHat();

            txtMaBH.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

        }
        private void ShowComboBox()
        {
            CaSiBUL csBUL = new CaSiBUL();
            cboCaSi.DataSource = csBUL.DanhSach();
            cboCaSi.DisplayMember = "TenCaSi";
            cboCaSi.ValueMember = "MaCaSi";
        }

        private void ShowDGVBaiHat()
        {
            NhacBUL songBUL = new NhacBUL();
            dgvBaiHat.DataSource = songBUL.DanhSach();
            dgvBaiHat.PerformLayout();
        }

        private void dgvBaiHat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMaBH.Text = dgvBaiHat.Rows[index].Cells["MaBaiHat"].Value.ToString();
                txtTenBH.Text = dgvBaiHat.Rows[index].Cells["TenBaiHat"].Value.ToString();
                txtAlbum.Text = dgvBaiHat.Rows[index].Cells["Album"].Value.ToString();
                dtpNgay.Value = DateTime.Parse(dgvBaiHat.Rows[index].Cells["NgayRaMat"].Value.ToString());
                cboCaSi.SelectedValue = dgvBaiHat.Rows[index].Cells["MaCaSi"].Value.ToString();

                txtMaBH.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maBH = txtMaBH.Text;
            string tenBH = txtTenBH.Text;
            string album = txtAlbum.Text;
            DateTime date = dtpNgay.Value;
            string maCaSi = cboCaSi.SelectedValue.ToString();

            Nhac song = new Nhac(maBH, tenBH, album, date, maCaSi);
            NhacBUL songBUL = new NhacBUL();

            if (songBUL.ThemNhac(song))
            {
                MessageBox.Show("Thêm thành công!");
                ResetFields();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!");
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maBH = txtMaBH.Text;
            string tenBH = txtTenBH.Text;
            string album = txtAlbum.Text;
            DateTime date = dtpNgay.Value;
            string maCaSi = cboCaSi.SelectedValue.ToString();

            Nhac song = new Nhac(maBH, tenBH, album, date, maCaSi);
            NhacBUL songBUL = new NhacBUL();

            if (songBUL.SuaNhac(song))
            {
                MessageBox.Show("Sửa thành công!");
                ResetFields();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maBH = txtMaBH.Text;
            NhacBUL songBUL = new NhacBUL();

            DialogResult rs = MessageBox.Show("Bạn muốn xóa bài hát này?",
                "Xác nhận xóa", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                if (songBUL.XoaNhac(maBH))
                {
                    MessageBox.Show("Xóa thành công!");
                    ResetFields();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!");
                } 
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string maBH = txtMaBH.Text;
            NhacBUL songBUL = new NhacBUL();

            List<Nhac> dsNhac = songBUL.TimNhac(maBH);
            if (dsNhac.Count > 0)
            {
                MessageBox.Show("Tìm thấy bản ghi!");
                dgvBaiHat.DataSource = dsNhac;
                dgvBaiHat.PerformLayout();

            }
            else
            {
                MessageBox.Show("Không tìm thấy!");
                ResetFields();
            }
        }
    }
}
