using DALs;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BULs
{
    public class SinhVienBUL
    {
        SinhVienDAL svDAL = new SinhVienDAL();

        public List<SinhVien> DanhSach()
        {
            return svDAL.DanhSach();
        }
        public List<SinhVien> TimTheoMa(string maSV)
        {
            return svDAL.TimTheoMa(maSV);
        }

        public bool XoaSinhVien(string maSV)
        {
            if (maSV == String.Empty)
                return false;
            return svDAL.XoaSinhVien(maSV);
        }

        public bool ThemSinhVien(SinhVien sv)
        {
            if (sv == null)
                return false;
            return svDAL.ThemSinhVien(sv);
        }

        public bool SuaThongTin(SinhVien sv)
        {
            if (sv == null)
                return false;
            return svDAL.SuaThongTin(sv);
        }
    }
}
