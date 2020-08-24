using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong3Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            NhanVien nv1 = new NhanVien();
            nv1.maNV = "NV1";
            nv1.tenNV = "Phùng Văn An";
            nv1.tienLuong1Gio = 22000;
            nv1.soGioLV = 200;
            NhanVien nv2 = Input();
            //Show
            Console.WriteLine("{0,-10} {1,-20} {2,10} {3,10} {4,10}",
               "Mã NV", "Tên nhân viên", "Lương 1H",
                "Số Giờ", "Lương");
            Console.WriteLine(nv1.ToString());
            Console.WriteLine(nv2.ToString());
            Console.ReadLine();
        }

        static NhanVien Input()
        {
            Console.Write(" Nhập mã nhân viên: ");
            string maSV = Console.ReadLine();
            Console.Write(" Nhập tên nhân viên: ");
            string tenSV = Console.ReadLine();
            double tienLuong1Gio = 0;
            do
            {
                Console.Write(" Nhập số tiền lương 1 giờ: ");
            } while (double.TryParse(Console.ReadLine(), out tienLuong1Gio) == false && tienLuong1Gio <= 0);
            double soGioLV = 0;
            do
            {
                Console.Write(" Nhập số giờ làm việc: ");
            } while (double.TryParse(Console.ReadLine(), out soGioLV) == false && soGioLV < 0);

            return new NhanVien(maSV, tenSV, tienLuong1Gio, soGioLV);
        }
    }
}
