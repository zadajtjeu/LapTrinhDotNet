using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class TongSoNguyen
    {
        private int _N;

        public int n
        {
            get { return _N; }
            set { _N = value; }
        }


        public TongSoNguyen()
        {
            n = 0;
        }
        public TongSoNguyen(int so)
        {
            n = so;
        }

        public int Tong()
        {
            int tong = 0;
            for (int i = 2; i <= n; i=i+2)
            {
                tong += i;
            }
            return tong;
        }
    }
}
