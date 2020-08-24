using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong3Bai2
{
    class NhanVienQuanLy:NhanVien
    {
        private double _HSPhuCap;

        public double hsPhuCap
        {
            get { return _HSPhuCap; }
            set { _HSPhuCap = value; }
        }

        public NhanVienQuanLy() { }

        public NhanVienQuanLy(string maNV, string tenNV,
            double tienLuong1Gio, double soGioLV, double hsPhuCap)
            :base(maNV,tenNV,tienLuong1Gio,soGioLV)
        {
            this.hsPhuCap = hsPhuCap;
        }

        public override double TinhLuong()
        {
            return base.TinhLuong() * (1 + this.hsPhuCap);
        }

        public override string ToString()
        {
            return String.Format("{0,-10} {1,-20} {2,10} {3,10} {4,10} {5,10}",
                 this.maNV, this.tenNV, this.tienLuong1Gio,
                 this.soGioLV, this.hsPhuCap, this.TinhLuong());
        }

    }
}
