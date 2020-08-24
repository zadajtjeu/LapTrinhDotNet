using System;
using System.Text;
namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Nhập vào 2 cạnh của hình chữ nhật: ");
            Console.Write("- Chiều dài: ");
            double height = double.Parse(Console.ReadLine());
            Console.Write("- Chiều rộng: ");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("HCN có chu vi là: {0} , diện tích {1}", 2 * (height + width), height * width);
            Console.ReadLine();

        }
    }
}
