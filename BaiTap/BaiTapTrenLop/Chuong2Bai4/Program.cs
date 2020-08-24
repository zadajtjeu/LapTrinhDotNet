using System;
using System.Text;
namespace Chuong2Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Từ điểm số sang điểm chữ dùng method
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập điểm học phần: ");
            double diem = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Điểm học phần\tĐiểm chữ");
            Console.WriteLine("\t{0}\t{1}", diem, ChuyenDiemChu(diem));
            Console.ReadLine();
        }

        static string ChuyenDiemChu(double diem)
        {
            string diemChu = null;
            if (diem >= 0 && diem < 4)
                diemChu = "F";
            else if (diem >= 4 && diem < 5)
                diemChu = "D";
            else if (diem >= 5 && diem < 7)
                diemChu = "C";
            else if (diem >= 7 && diem < 8.5)
                diemChu = "B";
            else if (diem >= 8.5 && diem <= 10)
                diemChu = "A";

            return diemChu;
        }
    }
}
