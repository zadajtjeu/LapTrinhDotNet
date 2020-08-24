using DALs;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BULs
{
    public class KhoaBUL
    {
        KhoaDAL khoaDAL = new KhoaDAL();

        public List<Khoa> DanhSach()
        {
            return khoaDAL.DanhSach();
        }
        public Khoa TimKhoaTheoLop(string maLop)
        {
            return khoaDAL.TimKhoaTheoLop(maLop);
        }
    }
}
