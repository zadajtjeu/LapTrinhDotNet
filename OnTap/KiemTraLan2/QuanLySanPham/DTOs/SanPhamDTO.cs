using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class SanPhamDTO
    {
        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public double DonGia { get; set; }
        public int SoLuong { get; set; }
        public string MaDanhMuc { get; set; }

        public SanPhamDTO() { }

        public SanPhamDTO(string MaSanPham, string TenSanPham,
            double DonGia, int SoLuong, string MaDanhMuc)
        {
            this.MaSanPham = MaSanPham;
            this.TenSanPham = TenSanPham;
            this.DonGia = DonGia;
            this.SoLuong = SoLuong;
            this.MaDanhMuc = MaDanhMuc;
        }
    }
}
