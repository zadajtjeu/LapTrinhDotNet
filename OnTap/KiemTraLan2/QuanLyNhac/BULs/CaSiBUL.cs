using DALs;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BULs
{
    public class CaSiBUL
    {
        CaSiDAL csDAL = new CaSiDAL();
        public List<CaSi> DanhSach()
        {
            return csDAL.DanhSach();
        }
    }
}
