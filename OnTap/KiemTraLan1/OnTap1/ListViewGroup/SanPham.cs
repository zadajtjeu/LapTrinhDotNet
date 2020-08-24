using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewGroup
{
    public class SanPham
    {
        private string _MaSP;

        public string maSP
        {
            get { return _MaSP; }
            set { _MaSP = value; }
        }

        private string _TenSP;

        public string tenSP
        {
            get { return _TenSP; }
            set { _TenSP = value; }
        }

        private int _Gia;

        public int gia
        {
            get { return _Gia; }
            set { _Gia = value; }
        }

        private DanhMuc _DanhMuc;

        public DanhMuc danhMuc
        {
            get { return _DanhMuc; }
            set { _DanhMuc = value; }
        }

        public SanPham() { }

        public SanPham(string maSP, string tenSP, int gia, DanhMuc dm)
        {
            this.maSP = maSP;
            this.tenSP = tenSP;
            this.gia = gia;
            this.danhMuc = dm;
        }
    }
}
