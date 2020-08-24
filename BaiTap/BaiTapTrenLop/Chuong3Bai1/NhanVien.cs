using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong3Bai1
{
    class NhanVien
    {
        private string _MaNV;
        public string maNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }

        private string _TenNV;

        public string tenNV
        {
            get { return _TenNV; }
            set { _TenNV = value; }
        }

        private double _TienLuong1Gio;

        public double tienLuong1Gio
        {
            get { return _TienLuong1Gio; }
            set { _TienLuong1Gio = value; }
        }

        private double _SoGioLV;

        public double soGioLV
        {
            get { return _SoGioLV; }
            set { _SoGioLV = value; }
        }

        public NhanVien() { }

        public NhanVien(string maNV, string tenNV, 
            double tienLuong1Gio, double soGioLV)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.tienLuong1Gio = tienLuong1Gio;
            this.soGioLV = soGioLV;
        }
        public double TinhLuong()
        {
            return this.tienLuong1Gio * this.soGioLV;
        }
        public override string ToString()
        {
            return String.Format("{0,-10} {1,-20} {2,10} {3,10} {4,10}",
                this.maNV, this.tenNV, this.tienLuong1Gio, 
                this.soGioLV, this.TinhLuong());
        }
    }
}
