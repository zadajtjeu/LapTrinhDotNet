using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Thông Tin Sinh Viên");
            string choice = "";
            List<TheSinhVien> dsSinhVien = new List<TheSinhVien>();

            do
            {
                TheSinhVien sv = Nhap();
                dsSinhVien.Add(sv);
                Console.Write("!!! Bạn có muốn nhập tiếp? (Y/N) : ");
                choice = Console.ReadLine();
            } while (choice.ToLower() == "y");

            Console.WriteLine("{0,-10}{1,-20}{2,-10}{3,10}", "Mã", "Họ Tên", "Lớp", "Năm Học");
            foreach (TheSinhVien sinhVien in dsSinhVien)
            {
                Console.WriteLine(sinhVien.ToString());
            }
            Console.ReadLine();
        }
        static TheSinhVien Nhap()
        {
            string maSV, hoTenSV, lop;
            int namHoc;
            Console.Write(" - Nhập mã sinh viên: ");
            maSV = Console.ReadLine();
            Console.Write(" - Nhập họ tên sinh viên: ");
            hoTenSV = Console.ReadLine();
            Console.Write(" - Nhập lớp: ");
            lop = Console.ReadLine();

            do
            {
                Console.Write(" - Nhập năm học: ");
            } while (int.TryParse(Console.ReadLine(), out namHoc) == false || namHoc <= 1970 || namHoc > DateTime.Now.Year);

            return new TheSinhVien(maSV, hoTenSV, lop, namHoc);
        }
    }
}
