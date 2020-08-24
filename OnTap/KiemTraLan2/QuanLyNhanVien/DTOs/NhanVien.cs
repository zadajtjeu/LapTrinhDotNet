using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class NhanVien
    {
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public DateTime NgaySinh { get; set; }
        public double LuongCanBan { get; set; }
        public int NgayCong { get; set; }
        public double PhuCap { get; set; }
        public string MaChucVu { get; set; }

        public NhanVien()
        {
        }

        public NhanVien(string maNhanVien, string tenNhanVien, DateTime ngaySinh, double luongCanBan, int ngayCong, double phuCap, string maChucVu)
        {
            MaNhanVien = maNhanVien;
            TenNhanVien = tenNhanVien;
            NgaySinh = ngaySinh;
            LuongCanBan = luongCanBan;
            NgayCong = ngayCong;
            PhuCap = phuCap;
            MaChucVu = maChucVu;
        }
    }
}
