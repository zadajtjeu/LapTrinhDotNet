namespace BangCassette
{
    partial class frmQLBang
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTuaDe = new System.Windows.Forms.TextBox();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.txtGiaCa = new System.Windows.Forms.TextBox();
            this.txtThoiLuong = new System.Windows.Forms.TextBox();
            this.txtLoaiDia = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstvDanhSach = new System.Windows.Forms.ListView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHienThi = new System.Windows.Forms.Button();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.erpCheckField = new System.Windows.Forms.ErrorProvider(this.components);
            this.clmTuaDe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmNXB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmGiaCa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmThoiLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmLoaiDia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpCheckField)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tựa Đề";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhà Xuất Bản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giá Cả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(600, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Thời Lượng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(600, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Loại Đĩa";
            // 
            // txtTuaDe
            // 
            this.txtTuaDe.Location = new System.Drawing.Point(182, 41);
            this.txtTuaDe.Name = "txtTuaDe";
            this.txtTuaDe.Size = new System.Drawing.Size(368, 31);
            this.txtTuaDe.TabIndex = 1;
            // 
            // txtNXB
            // 
            this.txtNXB.Location = new System.Drawing.Point(182, 114);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(368, 31);
            this.txtNXB.TabIndex = 3;
            // 
            // txtGiaCa
            // 
            this.txtGiaCa.Location = new System.Drawing.Point(182, 187);
            this.txtGiaCa.Name = "txtGiaCa";
            this.txtGiaCa.Size = new System.Drawing.Size(368, 31);
            this.txtGiaCa.TabIndex = 5;
            // 
            // txtThoiLuong
            // 
            this.txtThoiLuong.Location = new System.Drawing.Point(726, 40);
            this.txtThoiLuong.Name = "txtThoiLuong";
            this.txtThoiLuong.Size = new System.Drawing.Size(368, 31);
            this.txtThoiLuong.TabIndex = 7;
            // 
            // txtLoaiDia
            // 
            this.txtLoaiDia.Location = new System.Drawing.Point(726, 114);
            this.txtLoaiDia.Name = "txtLoaiDia";
            this.txtLoaiDia.Size = new System.Drawing.Size(368, 31);
            this.txtLoaiDia.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtLoaiDia);
            this.groupBox1.Controls.Add(this.txtThoiLuong);
            this.groupBox1.Controls.Add(this.txtGiaCa);
            this.groupBox1.Controls.Add(this.txtNXB);
            this.groupBox1.Controls.Add(this.txtTuaDe);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(52, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1150, 326);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // lstvDanhSach
            // 
            this.lstvDanhSach.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmTuaDe,
            this.clmNXB,
            this.clmGiaCa,
            this.clmThoiLuong,
            this.clmLoaiDia});
            this.lstvDanhSach.GridLines = true;
            this.lstvDanhSach.HideSelection = false;
            this.lstvDanhSach.Location = new System.Drawing.Point(52, 364);
            this.lstvDanhSach.Name = "lstvDanhSach";
            this.lstvDanhSach.Size = new System.Drawing.Size(1292, 351);
            this.lstvDanhSach.TabIndex = 4;
            this.lstvDanhSach.UseCompatibleStateImageBehavior = false;
            this.lstvDanhSach.View = System.Windows.Forms.View.Details;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(327, 251);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(145, 48);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(515, 251);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(145, 48);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(703, 251);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(145, 48);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnHienThi
            // 
            this.btnHienThi.Location = new System.Drawing.Point(1208, 60);
            this.btnHienThi.Name = "btnHienThi";
            this.btnHienThi.Size = new System.Drawing.Size(145, 48);
            this.btnHienThi.TabIndex = 1;
            this.btnHienThi.Text = "Hiển Thị";
            this.btnHienThi.UseVisualStyleBackColor = true;
            this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
            // 
            // btnSapXep
            // 
            this.btnSapXep.Location = new System.Drawing.Point(1208, 139);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(145, 48);
            this.btnSapXep.TabIndex = 2;
            this.btnSapXep.Text = "Sắp xếp";
            this.btnSapXep.UseVisualStyleBackColor = true;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(1208, 221);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(145, 48);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // erpCheckField
            // 
            this.erpCheckField.ContainerControl = this;
            // 
            // clmTuaDe
            // 
            this.clmTuaDe.Text = "Tựa đề";
            this.clmTuaDe.Width = 150;
            // 
            // clmNXB
            // 
            this.clmNXB.Text = "Nhà xuất bản";
            this.clmNXB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmNXB.Width = 150;
            // 
            // clmGiaCa
            // 
            this.clmGiaCa.Text = "Giá cả";
            this.clmGiaCa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmGiaCa.Width = 100;
            // 
            // clmThoiLuong
            // 
            this.clmThoiLuong.Text = "Thời lượng";
            this.clmThoiLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmThoiLuong.Width = 100;
            // 
            // clmLoaiDia
            // 
            this.clmLoaiDia.Text = "Loại đĩa";
            this.clmLoaiDia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmLoaiDia.Width = 150;
            // 
            // frmQLBang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 782);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSapXep);
            this.Controls.Add(this.btnHienThi);
            this.Controls.Add(this.lstvDanhSach);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmQLBang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý băng đĩa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erpCheckField)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTuaDe;
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.TextBox txtGiaCa;
        private System.Windows.Forms.TextBox txtThoiLuong;
        private System.Windows.Forms.TextBox txtLoaiDia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lstvDanhSach;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ErrorProvider erpCheckField;
        private System.Windows.Forms.ColumnHeader clmTuaDe;
        private System.Windows.Forms.ColumnHeader clmNXB;
        private System.Windows.Forms.ColumnHeader clmGiaCa;
        private System.Windows.Forms.ColumnHeader clmThoiLuong;
        private System.Windows.Forms.ColumnHeader clmLoaiDia;
    }
}

