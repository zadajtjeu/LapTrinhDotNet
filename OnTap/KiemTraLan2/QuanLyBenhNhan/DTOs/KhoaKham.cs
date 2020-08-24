using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class KhoaKham
    {
        public string MaKhoa { get; set; }
        public string TenKhoa { get; set; }

        public KhoaKham()
        {
        }

        public KhoaKham(string maKhoa, string tenKhoa)
        {
            MaKhoa = maKhoa;
            TenKhoa = tenKhoa;
        }
    }
}
