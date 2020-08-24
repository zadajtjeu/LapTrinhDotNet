using DALs;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BULs
{
    public class DanhMucBUL
    {
        static DanhMucDAL dm = new DanhMucDAL();
        public List<DanhMucDTO> DanhSach()
        {
            return dm.DanhSach();
        }
    }
}
