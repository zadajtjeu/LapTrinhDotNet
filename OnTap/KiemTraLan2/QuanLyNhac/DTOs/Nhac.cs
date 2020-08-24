using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class Nhac
    {
        public string MaBaiHat { get; set; }
        public string TenBaiHat { get; set; }
        public string Album { get; set; }
        public DateTime NgayRaMat { get; set; }
        public string MaCaSi { get; set; }

        public Nhac()
        {
        }

        public Nhac(string maBaiHat, string tenBaiHat, string album, DateTime ngayRaMat, string maCaSi)
        {
            MaBaiHat = maBaiHat;
            TenBaiHat = tenBaiHat;
            Album = album;
            NgayRaMat = ngayRaMat;
            MaCaSi = maCaSi;
        }
    }
}
