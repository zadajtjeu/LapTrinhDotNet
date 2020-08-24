using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class BenhNhan
    {
        public string MaBenhNhan { get; set; }
        public string TenBenhNhan { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string MaBHXH { get; set; }
        public string MaKhoa { get; set; }

        public BenhNhan()
        {
        }

        public BenhNhan(string maBenhNhan, string tenBenhNhan, DateTime ngaySinh, string gioiTinh, string maBHXH, string maKhoa)
        {
            MaBenhNhan = maBenhNhan;
            TenBenhNhan = tenBenhNhan;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            MaBHXH = maBHXH;
            MaKhoa = maKhoa;
        }
    }
}
