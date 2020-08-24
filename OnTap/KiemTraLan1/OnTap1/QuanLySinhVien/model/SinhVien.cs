using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.model
{
    class SinhVien
    {
        private string _MaSV;

        public string maSV
        {
            get { return _MaSV; }
            set { _MaSV = value; }
        }

        private string _TenSV;

        public string tenSV
        {
            get { return _TenSV; }
            set { _TenSV = value; }
        }

        private DateTime _NgaySinh;

        public DateTime ngaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }

        private bool _GioiTinh;

        public bool gioiTinh
        {
            get { return _GioiTinh; }
            set { _GioiTinh = value; }
        }

        private LopHoc _LopHoc;

        public LopHoc lopHoc
        {
            get { return _LopHoc; }
            set { _LopHoc = value; }
        }

        public SinhVien() {}

        public SinhVien(string maSV, string tenSV, DateTime ngay, bool gioiTinh, LopHoc lop)
        {
            this.maSV = maSV;
            this.tenSV = tenSV;
            this.ngaySinh = ngay;
            this.gioiTinh = gioiTinh;
            this.lopHoc = lop;
        }

        public override string ToString()
        {
            return this.tenSV;
        }
    }
}
