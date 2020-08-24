using System;
using System.Text;
namespace Chuong2Bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Nhập vào một chuỗi: ");
            string chuoi = Console.ReadLine();
            foreach (string word in chuoi.Split(' '))
                Console.WriteLine(word);
            Console.ReadLine();
        }
    }
}
