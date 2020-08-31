using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class TinhTong
    {
        private int _N;

        public int n
        {
            get { return _N; }
            set { _N = value; }
        }

        public TinhTong()
        {
            n = 0;
        }
        public TinhTong(int so)
        {
            n = so;
        }
        public int Tong()
        {
            int tong = 0;
            for(int i = 1; i <= n; i++ )
            {
                tong += i;
            }
            return tong;
        }
    }
}
