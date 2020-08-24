using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class HoaDon
    {
        public string MaHoaDon { get; set; }
        public string MaKhachHang { get; set; }
        public int ChiSoCu { get; set; }
        public DateTime NgayCu { get; set; }
        public int ChiSoMoi { get; set; }
        public DateTime NgayDo { get; set; }

        public HoaDon()
        {
        }

        public HoaDon(string maHoaDon, string maKhachHang, int chiSoCu, DateTime ngayCu, int chiSoMoi, DateTime ngayDo)
        {
            MaHoaDon = maHoaDon;
            MaKhachHang = maKhachHang;
            ChiSoCu = chiSoCu;
            NgayCu = ngayCu;
            ChiSoMoi = chiSoMoi;
            NgayDo = ngayDo;
        }
    }
}
