using DALs;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BULs
{
    public class ChucVuBUL
    {
        static ChucVuDAL cvDAL = new ChucVuDAL();

        public List<ChucVu> DanhSach()
        {
            return cvDAL.DanhSach();
        }
    }
}
