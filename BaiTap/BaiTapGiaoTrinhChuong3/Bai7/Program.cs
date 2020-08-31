using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("HÌNH TRỤ TRÒN");
            Cylinder H = input();
            Console.WriteLine("Thể tích V = {0,0:N2}\nDiện tích toàn phần A = {1,0:N2}", H.Volume(), H.SurfaceArea());
            Console.ReadKey();
        }
        static Cylinder input()
        {
            double radius, height;
            //xử lý nhập radius
            do
            {
                Console.Write("Bán kính r = ");
            } while (double.TryParse(Console.ReadLine(), out radius) == false && radius <= 0);
            //xử lý nhập height
            do
            {
                Console.Write("Chiều cao h = ");
            } while (double.TryParse(Console.ReadLine(), out height) == false && height <= 0);

            return new Cylinder(radius, height);
        }
    }
}
