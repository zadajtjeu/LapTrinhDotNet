using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    class ThuVien
    {
        private string _TuaDe;

        public string tuaDe
        {
            get { return _TuaDe; }
            set { _TuaDe = value; }
        }
        private string _TacGia;

        public string tacGia
        {
            get { return _TacGia; }
            set { _TacGia = value; }
        }
        private int _SoLuong;

        public int soLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }

        public ThuVien() {}

        public ThuVien(string tuaDe, string tacGia, int soLuong)
        {
            this.tuaDe = tuaDe;
            this.tacGia = tacGia;
            this.soLuong = soLuong;
        }

        public override string ToString()
        {
            return string.Format("{0} \t {1} \t {2}",
                this.tuaDe, this.tacGia, this.soLuong);
        }
    }
}
