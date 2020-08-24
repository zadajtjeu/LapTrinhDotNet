using DALs;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BULs
{
    public class SanPhamBUL
    {
        SanPhamDAL spDAL = new SanPhamDAL();
        public List<SanPhamDTO> DanhSach()
        {
            return spDAL.DanhSach();
        }

        public bool InsertSanPham(SanPhamDTO sp)
        {
            return spDAL.insertSanPham(sp);
        }
        public bool DeleteSanPham(string maSP)
        {
            return spDAL.DeleteSanPham(maSP);
        }
        public bool ModifySanPham(SanPhamDTO sp)
        {
            return spDAL.ModifySanPham(sp);
        }
        public List<SanPhamDTO> FindSanPham(string maSP)
        {
            return spDAL.FindSanPham(maSP);
        }
    }
}
