using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13
{
    class CONGNHAN:PERSON
    {
        string _tenCongTy;
        DateTime _ngayVaoLamViec;
        double _heSoLuong;

        public string TenCongTy { get => _tenCongTy; set => _tenCongTy = value; }
        public DateTime NgayVaoLamViec { get => _ngayVaoLamViec; set => _ngayVaoLamViec = value; }
        public double HeSoLuong { get => _heSoLuong; set => _heSoLuong = value; }

        public CONGNHAN() { }
        public CONGNHAN(string hoten, string gioitinh, int namsinh, string diachi,
            string tenCongTy, DateTime ngayVaoLamViec, double heSoLuong) : base(hoten, gioitinh, namsinh, diachi)
        {
            this.TenCongTy = tenCongTy;
            this.NgayVaoLamViec = ngayVaoLamViec;
            this.HeSoLuong = heSoLuong;
        }
        public override string ToString()
        {
            return string.Format("{0} \t {1} \t {2} \t {3} \t {4} \t {5} \t {6}",
                this.HoTen, this.GioiTinh, this.NamSinh, this.DiaChi, this.TenCongTy, this.NgayVaoLamViec, this.HeSoLuong);
        }
        //Công nhân có hệ số lương lớn nhất
        public static void MaxHsLuong(List<CONGNHAN> arr)
        {
            double max = arr[0].HeSoLuong;
            for (int i = 1; i < arr.Count; i++)
            {
                if (arr[i].HeSoLuong > max)
                    max = arr[i].HeSoLuong;
            }
            foreach (CONGNHAN item in arr)
            {
                if (item.HeSoLuong == max)
                    Console.WriteLine(item.ToString());
            }
        }
    }
}
