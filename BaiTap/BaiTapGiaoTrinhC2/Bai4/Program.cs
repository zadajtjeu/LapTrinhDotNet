using System;
using System.Text; 
namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Nhập thông tin học sinh:");
            Console.Write("- Nhập họ tên học sinh: ");
            string hoTenHS = Console.ReadLine();
            Console.Write("- Nhập điểm toán: ");
            double diemToan = Convert.ToDouble(Console.ReadLine());
            Console.Write("- Nhập điểm lý: ");
            double diemLy = Convert.ToDouble(Console.ReadLine());
            Console.Write("- Nhập điểm hóa: ");
            double diemHoa = Convert.ToDouble(Console.ReadLine());

            double diemTB = (diemToan + diemLy + diemHoa) / 3;

            Console.WriteLine("Thông tin học sinh:");
            Console.WriteLine("- Họ và tên: " + hoTenHS.ToUpper());
            Console.WriteLine("- Điểm TB: {0}", diemTB);

            Console.ReadLine();
        }
    }
}
