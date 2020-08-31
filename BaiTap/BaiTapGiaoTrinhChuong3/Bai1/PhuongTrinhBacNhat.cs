using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    //PTBN bx + c = 0
    class PhuongTrinhBacNhat
    {
        private static double b;
        private static double c;
        public PhuongTrinhBacNhat()
        {
            b = c = 0;
        }
        public PhuongTrinhBacNhat(double hs1, double hs2)
        {
            b = hs1;
            c = hs2;
        }


        public void ShowPhuongTrinh()
        {
            Console.WriteLine("{0}x + {1} = 0",b,c);
        }

        public void GiaiPhuongTrinhBacNhat()
        {
            if(b == 0)
            {
                if(c != 0)
                {
                    Console.WriteLine("Phương trình vô nghiệm!");
                }    
                else
                {
                    Console.WriteLine("Phương trình vô số nghiệm");
                }    
            }
            else
            {
                Console.WriteLine("Phương trình có nghiệm x = {0}", -c/b);
            }    
        }
    }
}
