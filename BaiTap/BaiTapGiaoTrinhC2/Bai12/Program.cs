using System;
using System.Text;
namespace Bai12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("TÍNH TỔNG CÁC SỐ");
            Console.WriteLine("Nhập số nguyên n: ");
            int n = 0;
            do
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                    if (n <= 0)
                    {
                        Console.WriteLine("Nhập số nguyên dương! ");
                        Console.Write("Nhập lại! n = ");
                    }    
                        
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nhập số nguyên bố ơi! SỐ NGUYÊN! ");
                    Console.Write("Nhập lại! n = ");
                }
            } while (n <= 0);
            Console.Clear();
            Console.WriteLine("n = " + n);
            int sA = 0;
            double sB = 0;
            for(int i=1; i<=n; i++)
            {
                sA += i;
                sB += 1.0 / i;
            }
            Console.WriteLine("S = 1 + 2 + 3 + ... + n = {0}", sA);
            Console.WriteLine("S = 1 + 1/2 + 1/3 + ... +1/n = " + sB);
            Console.ReadLine();
        }
    }
}
