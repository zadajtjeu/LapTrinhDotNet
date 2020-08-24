using DALs;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BULs
{
    public class BenhNhanBUL
    {
        BenhNhanDAL bnDAL = new BenhNhanDAL();

        public List<BenhNhan> DanhSach()
        {
            return bnDAL.DanhSach();
        }
        public bool Them(BenhNhan bn)
        {
            return bnDAL.Them(bn);
        }
        public bool Sua(BenhNhan bn)
        {
            return bnDAL.Sua(bn);
        }
        public bool Xoa(string maBN)
        {
            return bnDAL.Xoa(maBN);
        }
        public List<BenhNhan> Tim(string maBN)
        {
            return bnDAL.Tim(maBN);
        }
    }
}
