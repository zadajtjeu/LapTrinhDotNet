using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Tính tổng S = x + 2x^2 + 3x^3 + ... nx^n");
            S s = input();
            Console.WriteLine("S = {0}", s.Tinh());
            Console.ReadKey();
        }
        static S input()
        {
            int n;
            double x;
            //xử lý nhập n
            string inputLine = null;
            do
            {
                Console.Write("n = ");
                inputLine = Console.ReadLine();
            } while (int.TryParse(inputLine, out n) == false && n <= 0);
            //xử lý nhập x
            inputLine = null;
            do
            {
                Console.Write("x = ");
                inputLine = Console.ReadLine();
            } while (double.TryParse(inputLine, out x) == false);

            return new S(n, x);
        }
    }
}
