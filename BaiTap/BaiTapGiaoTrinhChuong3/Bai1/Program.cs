using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Phương trình bậc nhất bx + c = 0");
            PhuongTrinhBacNhat pt = new PhuongTrinhBacNhat();
            pt.NhapHeSo();
            pt.ShowPhuongTrinh();
            pt.GiaiPhuongTrinhBacNhat();
            Console.ReadKey();
        }
    }
}
