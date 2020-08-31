using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai11
{
    class HocSinh:IComparable
    {
        private string _HoTen;

        public string hoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }
        private int _Tuoi;

        public int tuoi
        {
            get { return _Tuoi; }
            set { _Tuoi = value; }
        }
        private int _DiemT;

        public int diemT
        {
            get { return _DiemT; }
            set { _DiemT = value; }
        }
        private int _DIemL;

        public int diemL
        {
            get { return _DIemL; }
            set { _DIemL = value; }
        }
        private int _DiemH;

        public int diemH
        {
            get { return _DiemH; }
            set { _DiemH = value; }
        }

        public HocSinh() {}

        public HocSinh(string hoTen, int tuoi, int diemT, int diemL, int diemH)
        {
            this.hoTen = hoTen;
            this.tuoi = tuoi;
            this.diemT = diemT;
            this.diemL = diemL;
            this.diemH = diemH;
        }
        public double AVGDiem()
        {
            return (diemT + diemL + diemH) / 3.0;
        }

        public override string ToString()
        {
            return string.Format("{0} \t {1} \t {2} \t {3} \t {4} \t {5} ",
                this.hoTen, this.tuoi, this.diemT, this.diemH, this.diemL, this.AVGDiem());
        }

        public int CompareTo(object obj)
        {
            HocSinh hs = obj as HocSinh;
            return this.AVGDiem().CompareTo(hs.AVGDiem());
        }
    }
}
