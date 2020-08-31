using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
    class TheSinhVien
    {
        private string maSV, hoTenSV, lop;
        private int namHoc;

        public TheSinhVien()
        {
            maSV = hoTenSV = lop = null;
            namHoc = 0;
        }
        public TheSinhVien(string maSV, string hoTenSV, string lop, int namHoc)
        {
            this.maSV = maSV;
            this.hoTenSV = hoTenSV;
            this.lop = lop;
            this.namHoc = namHoc;
        }

        public override string ToString()
        {
            return string.Format("{0,-10}{1,-20}{2,-10}{3,10}", maSV, hoTenSV, lop, namHoc);
        }
    }
}
