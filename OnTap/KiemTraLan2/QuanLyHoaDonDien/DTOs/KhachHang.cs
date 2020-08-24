using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class KhachHang
    {
        public string MaKhachHang { get; set; }
        public string TenKhachHang { get; set; }

        public KhachHang()
        {
        }

        public KhachHang(string maKhachHang, string tenKhachHang)
        {
            MaKhachHang = maKhachHang;
            TenKhachHang = tenKhachHang;
        }
    }
}
