using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class HocSinh
    {
        string _HoTen;
        string _GioiTinh;
        double _Van;
        double _Toan;
        double _NgoaiNgu;

        public string HoTen { get => _HoTen; set => _HoTen = value; }
        public string GioiTinh { get => _GioiTinh; set => _GioiTinh = value; }
        public double Van { get => _Van; set => _Van = value; }
        public double Toan { get => _Toan; set => _Toan = value; }
        public double NgoaiNgu { get => _NgoaiNgu; set => _NgoaiNgu = value; }

        public HocSinh() { }
        public HocSinh(string hoTen, string gioiTinh, double van, double toan, double ngoaiNgu)
        {
            this.HoTen = hoTen;
            this.GioiTinh = gioiTinh;
            this.Van = van;
            this.Toan = toan;
            this.NgoaiNgu = ngoaiNgu;
        }

        public double DiemThapNhat()
        {
            double min = this.Toan;
            if (this.Van < min)
                min = this.Van;
            if (this.NgoaiNgu < min)
                min = this.NgoaiNgu;
            return min;
        }
        public double DiemThem()
        {
            double diemThem = 0;
            if (this.GioiTinh == "Nữ")
                diemThem = 0.5;
            return diemThem;
        }

        public double diemKetQua()
        {
            double kq = this.Van * 2 + this.Toan * 2 + this.NgoaiNgu + DiemThem();
            return kq;
        }

        public string XepLoai()
        {
            string xepLoai = "";
            if (diemKetQua() >= 40 && DiemThapNhat() >= 7)
                xepLoai = "Giỏi";
            else if (diemKetQua() >= 35 && DiemThapNhat() >= 6)
                xepLoai = "Khá";
            else if (diemKetQua() >= 25 && DiemThapNhat() >= 5)
                xepLoai = "Trung Bình";
            else
                xepLoai = "Yếu";

            return xepLoai;
        }
    }
}
