using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangCassette
{
    class ANPHAM
    {
        private string _TuaDe;

        public string tuaDe
        {
            get { return _TuaDe; }
            set { _TuaDe = value; }
        }

        private string _NhaXuatBan;

        public string nhaXuatBan
        {
            get { return _NhaXuatBan; }
            set { _NhaXuatBan = value; }
        }

        private ulong _GiaCa;

        public ulong giaCa
        {
            get { return _GiaCa; }
            set { _GiaCa = value; }
        }

        public ANPHAM()
        {
            this.tuaDe = this.nhaXuatBan = String.Empty;
            this.giaCa = 0;
        }

        public ANPHAM(string tuaDe, string NXB, ulong giaCa)
        {
            this.tuaDe = tuaDe;
            this.nhaXuatBan = NXB;
            this.giaCa = giaCa;
        }

        public override string ToString()
        {
            return String.Format("{0,-15} {1,-15} {2,10}",
                this.tuaDe, this.nhaXuatBan, this.giaCa);
        }

    }
}
