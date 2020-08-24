using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    class PTBacHai
    {
        private double a, b, c;
        public PTBacHai()
        {
            a = b = c;
        }
        public PTBacHai(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void Nhap()
        {
            //xử lý nhập a
            do
            {
                Console.Write("a = ");
            } while (double.TryParse(Console.ReadLine(), out a) == false && a <= 0);
            //xử lý nhập b
            do
            {
                Console.Write("b = ");
            } while (double.TryParse(Console.ReadLine(), out b) == false && b <= 0);
            //xử lý nhập c
            do
            {
                Console.Write("c = ");
            } while (double.TryParse(Console.ReadLine(), out c) == false && c <= 0);
        }
        public void GiaiPhuongTrinhBacNhat()
        {
            if (b == 0)
            {
                if (c != 0)
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
                Console.WriteLine("Phương trình có nghiệm x = {0}", -c / b);
            }
        }
        public void GiaiPTBacHai()
        {
            if (a == 0)
                GiaiPhuongTrinhBacNhat();
            else
            {
                double delta = b * b - 4 * a * c;
                if(delta == 0)
                    Console.WriteLine("Phương trình có nghiệm kép x1 = x2 = {0,0:N2}", -b/(2*a));
                else if(delta > 0)
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b- Math.Sqrt(delta)) / (2 * a);
                    Console.WriteLine("Phương trình có 2 nghiệm phân biệt:" +
                        "\n- x1 = {0,0:N2}" +
                        "\n- x2 = {1,0:N2}",
                        x1, x2);
                }
                else
                    Console.WriteLine("Phương trình vô nghiệm");
            }    
        }
        public override string ToString()
        {
            return string.Format("{0}x^2 + {1}x + {2} = 0",a,b,c);
        }

    }
}
