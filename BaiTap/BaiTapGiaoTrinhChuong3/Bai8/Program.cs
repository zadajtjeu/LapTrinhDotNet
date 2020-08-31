using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Phương trình bậc hai ax^2 + bx + c = 0");
            PTBacHai pt = Nhap();
            Console.WriteLine(pt.ToString());
            pt.GiaiPTBacHai();
            Console.ReadKey();
        }
        static PTBacHai Nhap()
        {
            double a, b, c;
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

            return new PTBacHai(a, b, c);
        }
    }
}
