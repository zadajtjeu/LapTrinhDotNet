using DALs;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BULs
{
    public class LopHocBUL
    {
        LopHocDAL lopDAL = new LopHocDAL();

        public List<LopHoc> DanhSach()
        {
            return lopDAL.DanhSach();
        }
        public List<LopHoc> DanhSach(string maKhoa)
        {
            return lopDAL.DanhSach(maKhoa);
        }
    }
}
