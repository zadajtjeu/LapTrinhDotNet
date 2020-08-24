using DALs;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BULs
{
    public class KhoaKhamBUL
    {
        KhoaKhamDAL khoaDAL = new KhoaKhamDAL();

        public List<KhoaKham> DanhSach()
        {
            return khoaDAL.DanhSach();
        }
    }
}
