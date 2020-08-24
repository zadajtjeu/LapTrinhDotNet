using System;
using System.Text;
namespace Bai10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Nhập số nguyên n: ");
            int n = 0;

            do
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                    if (n <= 0)
                        Console.Write("Nhập lại! n = ");
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nhập số nguyên bố ơi! SỐ NGUYÊN! ");
                    Console.Write("Nhập lại! n = ");
                }
            } while (n <= 0);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("SỐ NGUYÊN DƯƠNG ĐÃ NHẬP: {0}", n);
            Console.ReadLine();
        }
    }
}
