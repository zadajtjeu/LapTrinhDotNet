using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Tính tổng các số nguyên từ 1 đến n");
            TinhTong so = new TinhTong();
            so.Nhap();
            Console.WriteLine("Tổng các số từ 1 đến {0} là: {1}", so.N, so.Tong());
            Console.ReadKey();
        }
    }
}
