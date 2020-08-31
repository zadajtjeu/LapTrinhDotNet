using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13
{
    class PERSON
    {
        private string _hoTen;
        private string _gioiTinh;
        private int _namSinh;
        private string _diaChi;
        public string HoTen { get => _hoTen; set => _hoTen = value; }
        public string GioiTinh { get => _gioiTinh; set => _gioiTinh = value; }
        public int NamSinh { get => _namSinh; set => _namSinh = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }


        public PERSON() { }
        public PERSON(string hoten, string gioitinh, int namsinh, string diachi)
        {
            this.HoTen = hoten;
            this.GioiTinh = gioitinh;
            this.NamSinh = namsinh;
            this.DiaChi = diachi;
        }

        public override string ToString()
        {
            return string.Format("{0} \t {1} \t {2} \t {3}", this.HoTen, this.GioiTinh, this.NamSinh, this.DiaChi);
        }
    }
}
