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
            S s = new S();
            s.input();
            Console.WriteLine("S = {0}", s.Tinh());
            Console.ReadKey();
        }
    }
}
