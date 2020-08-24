using System;
using System.Text;

namespace Chuong2Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Giải phương trình bậc nhất ax + b = 0
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Giải phương trình bậc nhất ax + b = 0");
            Console.Write("Nhập hệ số a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Nhập hệ số b: ");
            double b = double.Parse(Console.ReadLine());
            string ketqua = "";

            if (a == 0 && b != 0)
                ketqua = "vô nghiệm";
            else if (a == 0 && b == 0)
                ketqua = "có vô số nghiệm";
            else
                ketqua = "có nghiệm là " + (-b / a);

            Console.WriteLine("Phương trình {0}x + {1} = 0 {2}", a, b, ketqua);
            Console.ReadLine();
        }
    }
}
