namespace Chuong4Bai3
{
    partial class frmTMV
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkTrangDiem = new System.Windows.Forms.CheckBox();
            this.chkLamToc = new System.Windows.Forms.CheckBox();
            this.chkLamMong = new System.Windows.Forms.CheckBox();
            this.chkMatXa = new System.Windows.Forms.CheckBox();
            this.rad0 = new System.Windows.Forms.RadioButton();
            this.rad10 = new System.Windows.Forms.RadioButton();
            this.rad20 = new System.Windows.Forms.RadioButton();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblGiamGia = new System.Windows.Forms.Label();
            this.lblTongTra = new System.Windows.Forms.Label();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkMatXa);
            this.groupBox1.Controls.Add(this.chkLamMong);
            this.groupBox1.Controls.Add(this.chkLamToc);
            this.groupBox1.Controls.Add(this.chkTrangDiem);
            this.groupBox1.Location = new System.Drawing.Point(86, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dịch vụ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rad20);
            this.groupBox2.Controls.Add(this.rad10);
            this.groupBox2.Controls.Add(this.rad0);
            this.groupBox2.Location = new System.Drawing.Point(455, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 248);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giảm giá";
            // 
            // chkTrangDiem
            // 
            this.chkTrangDiem.AutoSize = true;
            this.chkTrangDiem.Location = new System.Drawing.Point(35, 39);
            this.chkTrangDiem.Name = "chkTrangDiem";
            this.chkTrangDiem.Size = new System.Drawing.Size(220, 29);
            this.chkTrangDiem.TabIndex = 0;
            this.chkTrangDiem.Text = "Trang điểm ($125)";
            this.chkTrangDiem.UseVisualStyleBackColor = true;
            this.chkTrangDiem.CheckedChanged += new System.EventHandler(this.chkTrangDiem_CheckedChanged);
            // 
            // chkLamToc
            // 
            this.chkLamToc.AutoSize = true;
            this.chkLamToc.Location = new System.Drawing.Point(35, 93);
            this.chkLamToc.Name = "chkLamToc";
            this.chkLamToc.Size = new System.Drawing.Size(176, 29);
            this.chkLamToc.TabIndex = 0;
            this.chkLamToc.Text = "Làm tóc ($60)";
            this.chkLamToc.UseVisualStyleBackColor = true;
            this.chkLamToc.CheckedChanged += new System.EventHandler(this.chkLamToc_CheckedChanged);
            // 
            // chkLamMong
            // 
            this.chkLamMong.AutoSize = true;
            this.chkLamMong.Location = new System.Drawing.Point(35, 147);
            this.chkLamMong.Name = "chkLamMong";
            this.chkLamMong.Size = new System.Drawing.Size(200, 29);
            this.chkLamMong.TabIndex = 0;
            this.chkLamMong.Text = "Làm móng ($35)";
            this.chkLamMong.UseVisualStyleBackColor = true;
            this.chkLamMong.CheckedChanged += new System.EventHandler(this.chkLamMong_CheckedChanged);
            // 
            // chkMatXa
            // 
            this.chkMatXa.AutoSize = true;
            this.chkMatXa.Location = new System.Drawing.Point(35, 201);
            this.chkMatXa.Name = "chkMatXa";
            this.chkMatXa.Size = new System.Drawing.Size(177, 29);
            this.chkMatXa.TabIndex = 0;
            this.chkMatXa.Text = "Mát xa ($200)";
            this.chkMatXa.UseVisualStyleBackColor = true;
            this.chkMatXa.CheckedChanged += new System.EventHandler(this.chkMatXa_CheckedChanged);
            // 
            // rad0
            // 
            this.rad0.AutoSize = true;
            this.rad0.Checked = true;
            this.rad0.Location = new System.Drawing.Point(58, 49);
            this.rad0.Name = "rad0";
            this.rad0.Size = new System.Drawing.Size(74, 29);
            this.rad0.TabIndex = 0;
            this.rad0.TabStop = true;
            this.rad0.Text = "0%";
            this.rad0.UseVisualStyleBackColor = true;
            // 
            // rad10
            // 
            this.rad10.AutoSize = true;
            this.rad10.Location = new System.Drawing.Point(58, 115);
            this.rad10.Name = "rad10";
            this.rad10.Size = new System.Drawing.Size(86, 29);
            this.rad10.TabIndex = 0;
            this.rad10.Text = "10%";
            this.rad10.UseVisualStyleBackColor = true;
            // 
            // rad20
            // 
            this.rad20.AutoSize = true;
            this.rad20.Location = new System.Drawing.Point(58, 181);
            this.rad20.Name = "rad20";
            this.rad20.Size = new System.Drawing.Size(86, 29);
            this.rad20.TabIndex = 0;
            this.rad20.Text = "20%";
            this.rad20.UseVisualStyleBackColor = true;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(220, 368);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(102, 25);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Tổng tiền";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(225, 430);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(97, 25);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Giảm giá";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(183, 492);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(139, 25);
            this.lbl3.TabIndex = 1;
            this.lbl3.Text = "Tổng phải trả";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoEllipsis = true;
            this.lblTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTongTien.ForeColor = System.Drawing.Color.Tomato;
            this.lblTongTien.Location = new System.Drawing.Point(387, 368);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(150, 30);
            this.lblTongTien.TabIndex = 1;
            // 
            // lblGiamGia
            // 
            this.lblGiamGia.AutoEllipsis = true;
            this.lblGiamGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGiamGia.ForeColor = System.Drawing.Color.Tomato;
            this.lblGiamGia.Location = new System.Drawing.Point(387, 430);
            this.lblGiamGia.Name = "lblGiamGia";
            this.lblGiamGia.Size = new System.Drawing.Size(150, 30);
            this.lblGiamGia.TabIndex = 1;
            // 
            // lblTongTra
            // 
            this.lblTongTra.AutoEllipsis = true;
            this.lblTongTra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTongTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTra.ForeColor = System.Drawing.Color.Tomato;
            this.lblTongTra.Location = new System.Drawing.Point(387, 492);
            this.lblTongTra.Name = "lblTongTra";
            this.lblTongTra.Size = new System.Drawing.Size(150, 30);
            this.lblTongTra.TabIndex = 1;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(134, 562);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(130, 45);
            this.btnTinh.TabIndex = 2;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(317, 562);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(130, 45);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(500, 562);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(130, 45);
            this.btnThoat.TabIndex = 2;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmTMV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 643);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lblTongTra);
            this.Controls.Add(this.lblGiamGia);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTMV";
            this.Text = "Thẩm mỹ viện Marry";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkMatXa;
        private System.Windows.Forms.CheckBox chkLamMong;
        private System.Windows.Forms.CheckBox chkLamToc;
        private System.Windows.Forms.CheckBox chkTrangDiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rad20;
        private System.Windows.Forms.RadioButton rad10;
        private System.Windows.Forms.RadioButton rad0;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Label lblGiamGia;
        private System.Windows.Forms.Label lblTongTra;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
    }
}

