using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class Sach
    {
        public string MaSach { get; set; }
        public string TenSach { get; set; }
        public int SoLuongCo { get; set; }
        public string MaTacGia { get; set; }
        public DateTime NgayXuatBan { get; set; }

        public Sach()
        {
        }

        public Sach(string maSach, string tenSach, int soLuongCo, string maTacGia, DateTime ngayXuatBan)
        {
            MaSach = maSach;
            TenSach = tenSach;
            SoLuongCo = soLuongCo;
            MaTacGia = maTacGia;
            NgayXuatBan = ngayXuatBan;
        }
    }
}
