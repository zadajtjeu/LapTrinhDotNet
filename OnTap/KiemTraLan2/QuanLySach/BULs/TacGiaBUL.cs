using DALs;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BULs
{
    public class TacGiaBUL
    {
        TacGiaDAL tgDAL = new TacGiaDAL();

        public List<TacGia> DanhSach()
        {
            return tgDAL.DanhSach();
        }
    }
}
