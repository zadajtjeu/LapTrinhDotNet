using System;
using System.Text;
namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Nhập vào một số nguyên n? ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} là số {1} {2}", n, n % 2 == 0 ? "chẵn" : "lẻ", n < 0 ? "âm" : "không âm");
            Console.ReadLine();
        }
    }
}
