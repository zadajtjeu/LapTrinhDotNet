using DALs;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BULs
{
    public class NhacBUL
    {
        NhacDAL songDAL = new NhacDAL();
        public List<Nhac> DanhSach()
        {
            return songDAL.DanhSach();
        }

        public bool ThemNhac(Nhac song)
        {
            return songDAL.ThemNhac(song);
        }
        public bool SuaNhac(Nhac song)
        {
            return songDAL.SuaNhac(song);
        }
        public bool XoaNhac(string maBH)
        {
            return songDAL.XoaNhac(maBH);
        }
        public List<Nhac> TimNhac(string maBH)
        {
            return songDAL.TimNhac(maBH);
        }
    }
}
