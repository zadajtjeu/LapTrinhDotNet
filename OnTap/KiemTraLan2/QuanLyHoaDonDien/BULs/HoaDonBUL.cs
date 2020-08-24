using DALs;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BULs
{
    public class HoaDonBUL
    {
        static HoaDonDAL hdDAL = new HoaDonDAL();

        public List<HoaDon> DanhSach()
        {
            return hdDAL.DanhSach();
        }
        public bool ThemHoaDon(HoaDon hd)
        {
            return hdDAL.ThemHoaDon(hd);
        }
        public bool SuaHoaDon(HoaDon hd)
        {
            return hdDAL.SuaHoaDon(hd);
        }
        public bool XoaHoaDon(string maHD)
        {
            return hdDAL.XoaHoaDon(maHD);
        }
        public List<HoaDon> Tim(string maHD)
        {
            return hdDAL.Tim(maHD);
        }
    }
}
