using System;
using System.Text;
namespace Bai11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("KIỂM TRA SỐ NGUYÊN TỐ");
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
            bool check = kiemtraSoNguyenTo(n);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Số n={0} {1} số nguyên tố!",n,check==true?"là":"không là");
        }
        static bool kiemtraSoNguyenTo(int n)
        {
            if (n <= 2)
                return false;
            else
                for (int i = 2; i <= (int)Math.Sqrt(n); i++)
                    if (n % i == 0)
                        return false;
            return true;
        }
    }
}
