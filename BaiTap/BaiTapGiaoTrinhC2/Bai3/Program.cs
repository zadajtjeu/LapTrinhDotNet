using System;
using System.Text;
namespace Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Nhập vào cạnh của hình vuông: ");
            double canh = double.Parse(Console.ReadLine());
            Console.WriteLine("Hình vuông cạnh {0} có chu vi là {1} , diện tích {2}", canh, canh * 4, Math.Pow(canh,2));
            Console.ReadLine();
        }
    }
}
