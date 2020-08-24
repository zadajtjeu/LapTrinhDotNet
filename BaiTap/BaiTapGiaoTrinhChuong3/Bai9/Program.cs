using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("THẺ SINH VIÊN");
            TheSinhVien sv = new TheSinhVien();
            sv.Nhap();
            Console.WriteLine(sv.ToString());
            Console.ReadLine();
        }
    }
}
