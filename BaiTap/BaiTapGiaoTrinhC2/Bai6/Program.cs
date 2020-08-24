using System;
using System.Text;

namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Tìm số nhỏ nhất trong 3 số:");
            Console.Write("- Nhập số nguyên thứ nhất: ");
            int so1 = int.Parse(Console.ReadLine());
            Console.Write("- Nhấp số nguyên thứ hai: ");
            int so2 = int.Parse(Console.ReadLine());
            Console.Write("- Nhập số nguyên thứ ba: ");
            int so3 = int.Parse(Console.ReadLine());

            int min = so1 < so2 ? so1 : so2;
            min = so3 < min ? so3 : min;

            Console.WriteLine("Số nhỏ nhất trong ba số {0}, {1}, {2} là: {3}", so1, so2, so3, min);
            Console.ReadLine();
        }
    }
}
