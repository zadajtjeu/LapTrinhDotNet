using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    class TongSoNguyen
    {
        private static int n;
        public int N { get { return n; } }

        public TongSoNguyen()
        {
            n = 0;
        }
        public TongSoNguyen(int so)
        {
            n = so;
        }
        public void Nhap()
        {
            string inputLine = null;
            do
            {
                Console.Write("n = ");
                inputLine = Console.ReadLine();
            } while (int.TryParse(inputLine, out n) == false && n <= 0);
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
