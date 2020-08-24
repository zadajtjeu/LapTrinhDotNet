using System;
using System.Text;
namespace Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("\tTÍNH LƯƠNG");
            Console.Write("- Nhập bậc lương: ");
            double hsLuong = Convert.ToDouble(Console.ReadLine());
            Console.Write("- Nhập số ngày công: ");
            double ngayCong = Convert.ToDouble(Console.ReadLine());
            Console.Write("- Nhập phụ cấp: ");
            double phuCap = double.Parse(Console.ReadLine());

            double ThucLinh = ngayCong < 25 ? ngayCong : (ngayCong - 25) * 2 + 25;
            Console.WriteLine("Tiền lĩnh = {0}", hsLuong * 650000 * ThucLinh +phuCap);
            Console.ReadLine();
        }
    }
}
