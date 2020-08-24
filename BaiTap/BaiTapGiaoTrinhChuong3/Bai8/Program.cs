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
            PTBacHai pt = new PTBacHai();
            pt.Nhap();
            Console.WriteLine(pt.ToString());
            pt.GiaiPTBacHai();
            Console.ReadKey();
        }
    }
}
