using DALs;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BULs
{
    public class SachBUL
    {
        static SachDAL sachDAL = new SachDAL();

        public List<Sach> DanhSach()
        {
            return sachDAL.DanhSach();
        }

        public bool ThemSach(Sach info)
        {
            return sachDAL.ThemSach(info);
        }
        public bool SuaSach(Sach info)
        {
            return sachDAL.SuaSach(info);
        }
        public bool XoaSach(string maSach)
        {
            return sachDAL.XoaSach(maSach);
        }

        public List<Sach> TimSach(string maSach)
        {
            return sachDAL.TimSach(maSach);
        }

    }
}
