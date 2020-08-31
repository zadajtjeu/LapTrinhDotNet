namespace Bai2
{
    partial class Form1
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
            this.lbSob = new System.Windows.Forms.Label();
            this.lbSoc = new System.Windows.Forms.Label();
            this.txtSob = new System.Windows.Forms.TextBox();
            this.txtSoc = new System.Windows.Forms.TextBox();
            this.btnGiai = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.Label();
            this.lbNghiem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSob
            // 
            this.lbSob.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSob.Location = new System.Drawing.Point(22, 25);
            this.lbSob.Name = "lbSob";
            this.lbSob.Size = new System.Drawing.Size(146, 24);
            this.lbSob.TabIndex = 0;
            this.lbSob.Text = "Nhập hệ số b";
            // 
            // lbSoc
            // 
            this.lbSoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoc.Location = new System.Drawing.Point(22, 76);
            this.lbSoc.Name = "lbSoc";
            this.lbSoc.Size = new System.Drawing.Size(146, 24);
            this.lbSoc.TabIndex = 1;
            this.lbSoc.Text = "Nhập hệ số c";
            // 
            // txtSob
            // 
            this.txtSob.Location = new System.Drawing.Point(174, 29);
            this.txtSob.Name = "txtSob";
            this.txtSob.Size = new System.Drawing.Size(172, 20);
            this.txtSob.TabIndex = 2;
            // 
            // txtSoc
            // 
            this.txtSoc.Location = new System.Drawing.Point(174, 76);
            this.txtSoc.Name = "txtSoc";
            this.txtSoc.Size = new System.Drawing.Size(172, 20);
            this.txtSoc.TabIndex = 3;
            // 
            // btnGiai
            // 
            this.btnGiai.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGiai.Location = new System.Drawing.Point(27, 120);
            this.btnGiai.Name = "btnGiai";
            this.btnGiai.Size = new System.Drawing.Size(93, 36);
            this.btnGiai.TabIndex = 4;
            this.btnGiai.Text = "Giải";
            this.btnGiai.UseVisualStyleBackColor = true;
            this.btnGiai.Click += new System.EventHandler(this.btnGiai_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(140, 120);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(93, 36);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(253, 120);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(93, 36);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lb1
            // 
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(23, 179);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(97, 24);
            this.lb1.TabIndex = 7;
            this.lb1.Text = "Nghiệm là";
            // 
            // lbNghiem
            // 
            this.lbNghiem.BackColor = System.Drawing.Color.Snow;
            this.lbNghiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbNghiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNghiem.Location = new System.Drawing.Point(136, 179);
            this.lbNghiem.Name = "lbNghiem";
            this.lbNghiem.Size = new System.Drawing.Size(210, 24);
            this.lbNghiem.TabIndex = 8;
            // 
            // FormBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(388, 229);
            this.Controls.Add(this.lbNghiem);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnGiai);
            this.Controls.Add(this.txtSoc);
            this.Controls.Add(this.txtSob);
            this.Controls.Add(this.lbSoc);
            this.Controls.Add(this.lbSob);
            this.Name = "FormBai2";
            this.Text = "Giải phương trình bậc nhất";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSob;
        private System.Windows.Forms.Label lbSoc;
        private System.Windows.Forms.TextBox txtSob;
        private System.Windows.Forms.TextBox txtSoc;
        private System.Windows.Forms.Button btnGiai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lbNghiem;
    }
}

