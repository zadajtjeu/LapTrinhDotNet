using System;
using System.Text;
namespace Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("NHẬP THÔNG TIN SINH VIÊN");
            Console.WriteLine("- Nhập họ tên sinh viên: ");
            string hoTen = Console.ReadLine();
            Console.Write("- Nhập điểm tổng kết: ");
            double diemTK = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("THÔNG TIN SINH VIÊN");
            Console.WriteLine("- Họ tên: " + hoTen.ToUpper());
            Console.WriteLine("- Xếp loại: {0}", XepLoaiHocTap(diemTK));
            Console.ReadLine();
        }
        static string XepLoaiHocTap(double diem)
        {
            string xeploai = "";
            if (diem >= 8)
                xeploai = "Giỏi";
            else if (diem >= 6.5)
                xeploai = "Khá";
            else if (diem >= 5)
                xeploai = "Trung bình";
            else
                xeploai = "Yếu";
            return xeploai;

        }
    }
}
