namespace Chuong4Bai1
{
    partial class frmMessage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtThongBao = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radDen = new System.Windows.Forms.RadioButton();
            this.radDo = new System.Windows.Forms.RadioButton();
            this.radVang = new System.Windows.Forms.RadioButton();
            this.radXanh = new System.Windows.Forms.RadioButton();
            this.chkHienThi = new System.Windows.Forms.CheckBox();
            this.lblHienThi = new System.Windows.Forms.Label();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.picBig = new System.Windows.Forms.PictureBox();
            this.picSmall = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBig)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSmall)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtThongBao);
            this.groupBox1.Controls.Add(this.txtTen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(45, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thông báo";
            // 
            // txtTen
            // 
            this.txtTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTen.Location = new System.Drawing.Point(175, 35);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(473, 31);
            this.txtTen.TabIndex = 2;
            // 
            // txtThongBao
            // 
            this.txtThongBao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtThongBao.Location = new System.Drawing.Point(175, 83);
            this.txtThongBao.Name = "txtThongBao";
            this.txtThongBao.Size = new System.Drawing.Size(473, 31);
            this.txtThongBao.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radXanh);
            this.groupBox2.Controls.Add(this.radVang);
            this.groupBox2.Controls.Add(this.radDo);
            this.groupBox2.Controls.Add(this.radDen);
            this.groupBox2.Location = new System.Drawing.Point(45, 266);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 222);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Màu";
            // 
            // radDen
            // 
            this.radDen.AutoSize = true;
            this.radDen.Checked = true;
            this.radDen.Location = new System.Drawing.Point(43, 43);
            this.radDen.Name = "radDen";
            this.radDen.Size = new System.Drawing.Size(82, 29);
            this.radDen.TabIndex = 0;
            this.radDen.TabStop = true;
            this.radDen.Text = "Đen";
            this.radDen.UseVisualStyleBackColor = true;
            this.radDen.CheckedChanged += new System.EventHandler(this.radDen_CheckedChanged);
            // 
            // radDo
            // 
            this.radDo.AutoSize = true;
            this.radDo.ForeColor = System.Drawing.Color.Red;
            this.radDo.Location = new System.Drawing.Point(43, 86);
            this.radDo.Name = "radDo";
            this.radDo.Size = new System.Drawing.Size(70, 29);
            this.radDo.TabIndex = 1;
            this.radDo.Text = "Đỏ";
            this.radDo.UseVisualStyleBackColor = true;
            this.radDo.CheckedChanged += new System.EventHandler(this.radDo_CheckedChanged);
            // 
            // radVang
            // 
            this.radVang.AutoSize = true;
            this.radVang.ForeColor = System.Drawing.Color.Gold;
            this.radVang.Location = new System.Drawing.Point(43, 129);
            this.radVang.Name = "radVang";
            this.radVang.Size = new System.Drawing.Size(93, 29);
            this.radVang.TabIndex = 2;
            this.radVang.Text = "Vàng";
            this.radVang.UseVisualStyleBackColor = true;
            this.radVang.CheckedChanged += new System.EventHandler(this.radVang_CheckedChanged);
            // 
            // radXanh
            // 
            this.radXanh.AutoSize = true;
            this.radXanh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.radXanh.Location = new System.Drawing.Point(43, 172);
            this.radXanh.Name = "radXanh";
            this.radXanh.Size = new System.Drawing.Size(93, 29);
            this.radXanh.TabIndex = 3;
            this.radXanh.Text = "Xanh";
            this.radXanh.UseVisualStyleBackColor = true;
            this.radXanh.CheckedChanged += new System.EventHandler(this.radXanh_CheckedChanged);
            // 
            // chkHienThi
            // 
            this.chkHienThi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkHienThi.AutoSize = true;
            this.chkHienThi.Checked = true;
            this.chkHienThi.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHienThi.Location = new System.Drawing.Point(295, 296);
            this.chkHienThi.Name = "chkHienThi";
            this.chkHienThi.Size = new System.Drawing.Size(219, 29);
            this.chkHienThi.TabIndex = 2;
            this.chkHienThi.Text = "Hiển thị thông báo";
            this.chkHienThi.UseVisualStyleBackColor = true;
            this.chkHienThi.CheckedChanged += new System.EventHandler(this.chkHienThi_CheckedChanged);
            // 
            // lblHienThi
            // 
            this.lblHienThi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHienThi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHienThi.Location = new System.Drawing.Point(273, 356);
            this.lblHienThi.Name = "lblHienThi";
            this.lblHienThi.Size = new System.Drawing.Size(263, 132);
            this.lblHienThi.TabIndex = 3;
            this.lblHienThi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHienThi
            // 
            this.btnHienThi.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHienThi.Location = new System.Drawing.Point(145, 532);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(138, 44);
            this.btnHienThi.TabIndex = 4;
            this.btnHienThi.Text = "Hiển thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXoa.Location = new System.Drawing.Point(339, 532);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(138, 44);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThoat.Location = new System.Drawing.Point(534, 532);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(138, 44);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // picBig
            // 
            this.picBig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBig.Image = global::Chuong4Bai1.Properties.Resources.coalabig;
            this.picBig.Location = new System.Drawing.Point(562, 286);
            this.picBig.Name = "picBig";
            this.picBig.Size = new System.Drawing.Size(187, 201);
            this.picBig.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBig.TabIndex = 6;
            this.picBig.TabStop = false;
            this.picBig.Click += new System.EventHandler(this.picBig_Click);
            // 
            // picSmall
            // 
            this.picSmall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picSmall.Image = global::Chuong4Bai1.Properties.Resources.coalasmall;
            this.picSmall.Location = new System.Drawing.Point(585, 323);
            this.picSmall.Name = "picSmall";
            this.picSmall.Size = new System.Drawing.Size(135, 118);
            this.picSmall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSmall.TabIndex = 5;
            this.picSmall.TabStop = false;
            this.picSmall.Click += new System.EventHandler(this.picSmall_Click);
            // 
            // frmMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 601);
            this.Controls.Add(this.picBig);
            this.Controls.Add(this.picSmall);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.lblHienThi);
            this.Controls.Add(this.chkHienThi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message Formatter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBig)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSmall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtThongBao;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radXanh;
        private System.Windows.Forms.RadioButton radVang;
        private System.Windows.Forms.RadioButton radDo;
        private System.Windows.Forms.RadioButton radDen;
        private System.Windows.Forms.CheckBox chkHienThi;
        private System.Windows.Forms.Label lblHienThi;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.PictureBox picSmall;
        private System.Windows.Forms.PictureBox picBig;
    }
}

