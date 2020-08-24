using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangCassette
{
    class BANG:ANPHAM,IComparable<ANPHAM>
    {
        private uint _ThoiLuong;

        public uint thoiLuong
        {
            get { return _ThoiLuong; }
            set { _ThoiLuong = value; }
        }

        private string _LoaiDia;

        public string loaiDia
        {
            get { return _LoaiDia; }
            set { _LoaiDia = value; }
        }

        public BANG() { }

        public BANG(uint thoiLuong, string loaiDia)
        {
            this.thoiLuong = thoiLuong;
            this.loaiDia = loaiDia;
        }

        public BANG(string tuaDe, string NXB, ulong giaCa, 
            uint thoiLuong, string loaiDia):base(tuaDe,NXB,giaCa)
        {
            this.thoiLuong = thoiLuong;
            this.loaiDia = loaiDia;
        }

        public override string ToString()
        {
            return String.Format("{0,-15} {1,-15} {2,10} {3,10} {4,-10}",
                this.tuaDe, this.nhaXuatBan, this.giaCa,
                this.thoiLuong, this.loaiDia);
        }

        public int CompareTo(ANPHAM obj)
        {
            return this.tuaDe.CompareTo(obj.tuaDe);
        }
    }
}
