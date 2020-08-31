using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double so1, so2;

        private void btnTru_Click(object sender, EventArgs e)
        {
            double value;
            //Kiểm tra giá trị nhập vào
            if (double.TryParse(txtSo2.Text, out value) && double.TryParse(txtSo1.Text, out value))
            {
                so1 = double.Parse(txtSo1.Text);
                so2 = double.Parse(txtSo2.Text);
                lblKetQua.Text = (so1 - so2).ToString();
            }
            else
                lblKetQua.Text = "Nhập đúng các hệ số";
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            double value;
            //Kiểm tra giá trị nhập vào
            if (double.TryParse(txtSo2.Text, out value) && double.TryParse(txtSo1.Text, out value))
            {
                so1 = double.Parse(txtSo1.Text);
                so2 = double.Parse(txtSo2.Text);
                lblKetQua.Text = (so1 * so2).ToString();
            }
            else
                lblKetQua.Text = "Nhập đúng các hệ số";
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            double value;
            //Kiểm tra giá trị nhập vào
            if (double.TryParse(txtSo2.Text, out value) && double.TryParse(txtSo1.Text, out value))
            {
                so1 = double.Parse(txtSo1.Text);
                so2 = double.Parse(txtSo2.Text);
                if (so2 != 0)
                    lblKetQua.Text = (so1 / so2).ToString();
                else
                {
                    lblKetQua.Text = "Hệ số 2 = 0, Nhập lại";//thay bằng messagebox
                    txtSo2.Clear();
                    txtSo2.Focus();
                }

            }
            else
                lblKetQua.Text = "Nhập đúng các hệ số";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtSo1.Clear();
            txtSo2.Clear();
            lblKetQua.Text = "";
            txtSo1.Focus();
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn kết thúc chương trình ?", "This is CapTion",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                this.Close();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            double value;
            //Kiểm tra giá trị nhập vào
            if (double.TryParse(txtSo2.Text, out value) && double.TryParse(txtSo1.Text, out value))
            {
                so1 = double.Parse(txtSo1.Text);
                so2 = double.Parse(txtSo2.Text);
                lblKetQua.Text = (so1 + so2).ToString();
            }
            else
                lblKetQua.Text = "Nhập đúng các hệ số";
        }
    }
}
