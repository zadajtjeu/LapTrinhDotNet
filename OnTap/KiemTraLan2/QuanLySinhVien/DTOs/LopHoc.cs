using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class LopHoc
    {
        public string MaLop { get; set; }
        public string TenLop { get; set; }
        public int SiSo { get; set; }
        public string MaKhoa { get; set; }

        public LopHoc()
        {
        }

        public LopHoc(string maLop, string tenLop, int siSo, string maKhoa)
        {
            MaLop = maLop;
            TenLop = tenLop;
            SiSo = siSo;
            MaKhoa = maKhoa;
        }
    }
}
