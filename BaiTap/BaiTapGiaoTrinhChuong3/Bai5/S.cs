using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class S
    {
        private int n;
        private double x;
        public S()
        {
            n = 0;
            x = 0;
        }
        public S(int n, double x)
        {
            this.n = n;
            this.x = x;
        }
        public double Tinh()
        {
            double tong = 0;
            for(int i = 1; i <= n; i++)
            {
                tong += i * Math.Pow(x, i);
            }
            return tong;
        }

    }
}
