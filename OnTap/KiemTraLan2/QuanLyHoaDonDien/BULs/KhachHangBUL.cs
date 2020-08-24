using DALs;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BULs
{
    public class KhachHangBUL
    {
        static KhachHangDAL khDAL = new KhachHangDAL();

        public List<KhachHang> DanhSach()
        {
            return khDAL.DanhSach();
        }
    }
}
