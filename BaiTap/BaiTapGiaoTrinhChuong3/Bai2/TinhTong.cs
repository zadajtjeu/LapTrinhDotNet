using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class TinhTong
    {
        private static int n;
        public int N { get { return n; } }
        public TinhTong()
        {
            n = 0;
        }
        public TinhTong(int so)
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
            for(int i = 1; i <= n; i++ )
            {
                tong += i;
            }
            return tong;
        }
    }
}
