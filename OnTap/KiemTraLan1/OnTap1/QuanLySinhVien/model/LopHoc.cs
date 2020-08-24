using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.model
{
    class LopHoc
    {
        private string _MaLop;

        public string maLop
        {
            get { return _MaLop; }
            set { _MaLop = value; }
        }

        private string _TenLop;

        public string tenLop
        {
            get { return _TenLop; }
            set { _TenLop = value; }
        }

        private string _GiaoVienChuNhiem;

        public string gvChuNhiem
        {
            get { return _GiaoVienChuNhiem; }
            set { _GiaoVienChuNhiem = value; }
        }

        private List<SinhVien> _dsSinhVien;

        public List<SinhVien> dsSinhVien
        {
            get { return _dsSinhVien; }
            set { _dsSinhVien = value; }
        }

        private Khoa _KhoaChuQuan;

        public Khoa khoaChuQuan
        {
            get { return _KhoaChuQuan; }
            set { _KhoaChuQuan = value; }
        }


        public LopHoc()
        {
            this.maLop = this.tenLop = this.gvChuNhiem = String.Empty;
            this.dsSinhVien = new List<SinhVien>();
        }

        public LopHoc(string maLop, string tenLop, string chuNhiem)
        {
            this.maLop = maLop;
            this.tenLop = tenLop;
            this.dsSinhVien = new List<SinhVien>();
            this.gvChuNhiem = chuNhiem;
        }

        public LopHoc(string maLop, string tenLop, string chuNhiem, List<SinhVien> dsSV, Khoa khoaChuQuan)
        {
            this.maLop = maLop;
            this.tenLop = tenLop;
            this.dsSinhVien = dsSV;
            this.gvChuNhiem = chuNhiem;
            this.khoaChuQuan = khoaChuQuan;
        }

        public override string ToString()
        {
            return this.tenLop;
        }
    }
}
