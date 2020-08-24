using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class SinhVien
    {
        public string MaSinhVien { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string MaLop { get; set; }

        public SinhVien() {}

        public SinhVien(string maSinhVien, string hoTen, DateTime ngaySinh, string gioiTinh, string maLop)
        {
            MaSinhVien = maSinhVien;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            MaLop = maLop;
        }
    }
}
