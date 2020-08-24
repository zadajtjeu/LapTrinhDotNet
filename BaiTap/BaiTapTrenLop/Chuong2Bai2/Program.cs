using System;
using System.Text;

namespace Chuong2Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Từ điểm số sang điểm chữ
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập điểm học phần: ");
            double diem = double.Parse(Console.ReadLine());
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
            Console.WriteLine("Điểm học phần\tĐiểm chữ");
            Console.WriteLine("\t{0}\t{1}", diem, diemChu);
            Console.ReadLine();
        }
    }
}
