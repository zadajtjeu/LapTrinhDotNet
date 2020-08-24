using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewGroup
{
    public class DanhMuc
    {
        private string _MaDM;

        public string maDM
        {
            get { return _MaDM; }
            set { _MaDM = value; }
        }

        private string _TenDM;

        public string tenDM
        {
            get { return _TenDM; }
            set { _TenDM = value; }
        }

        private List<SanPham> _SanPhams;

        public List<SanPham> sanPhams
        {
            get { return _SanPhams; }
            set { _SanPhams = value; }
        }

        public DanhMuc()
        {
            this.maDM = this.tenDM = "";
            sanPhams = new List<SanPham>();
        }

        public DanhMuc(string maDM, string tenDM, List<SanPham> listSP)
        {
            this.maDM = maDM;
            this.tenDM = tenDM;
            this.sanPhams = listSP;
        }
        public void ThemSanPham(SanPham sp)
        {

            this._SanPhams.Add(sp);
            sp.danhMuc = this;
        }

        public override string ToString()
        {
            return tenDM;
        }

    }
}
