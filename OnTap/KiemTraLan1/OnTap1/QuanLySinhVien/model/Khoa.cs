using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien.model
{
    class Khoa
    {
        private string _MaKhoa;

        public string maKhoa
        {
            get { return _MaKhoa; }
            set { _MaKhoa = value; }
        }

        private string _TenKhoa;

        public string tenKhoa
        {
            get { return _TenKhoa; }
            set { _TenKhoa = value; }
        }

        private List<LopHoc> _dsLop;

        public List<LopHoc> dsLop
        {
            get { return _dsLop; }
            set { _dsLop = value; }
        }

        public Khoa()
        {
            this.maKhoa = this.tenKhoa = String.Empty;
            this.dsLop = new List<LopHoc>();
        }

        public Khoa(string maKhoa, string tenKhoa)
        {
            this.maKhoa = maKhoa;
            this.tenKhoa = tenKhoa;
            this.dsLop = new List<LopHoc>();
        }

        public Khoa(string maKhoa, string tenKhoa, List<LopHoc> dsLop)
        {
            this.maKhoa = maKhoa;
            this.tenKhoa = tenKhoa;
            this.dsLop = dsLop;
        }

        public override string ToString()
        {
            return tenKhoa;
        }
    }
}
