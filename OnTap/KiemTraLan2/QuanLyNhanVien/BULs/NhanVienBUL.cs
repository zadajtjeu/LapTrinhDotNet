using DALs;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BULs
{
    public class NhanVienBUL
    {
        static NhanVienDAL nvDAL = new NhanVienDAL();

        public List<NhanVien> DanhSach()
        {
            return nvDAL.DanhSach();
        }

        public bool ThemNhanVien(NhanVien nv)
        {
            return nvDAL.ThemNhanVien(nv);
        }

        public bool SuaNhanVien(NhanVien nv)
        {
            return nvDAL.SuaNhanVien(nv);
        }

        public bool XoaNhanVien(string maNV)
        {
            return nvDAL.XoaNhanVien(maNV);
        }

        public List<NhanVien> TimNhanVien(string maNV)
        {
            return nvDAL.TimNhanVien(maNV);
        }

    }
}
