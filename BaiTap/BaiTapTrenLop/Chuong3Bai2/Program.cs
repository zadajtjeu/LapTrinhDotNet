using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong3Bai2
{
    class Program
    {
        static ArrayList dsNhanVien = new ArrayList();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Menu();
            //Console.ReadKey();
        }
        static void Menu()
        {
            // Tạo menu
            do
            {
                Console.Clear();
                Console.WriteLine("\t\tMAIN MENU");
                Console.WriteLine("1. Nhập vào thông tin nhân viên");
                Console.WriteLine("2. Hiển thị danh sách");
                Console.WriteLine("3. Tính lương trung bình");
                Console.WriteLine("4. Thoát");
                Console.Write("\nMời bạn chọn?");
                string choice = Console.ReadLine();
                switch(choice)
                {
                    case "1":
                        Console.Clear();
                        InputNewNhanVien();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("{0,-10} {1,-20} {2,10} {3,10} {4,10} {5,10}",
                            "Mã NV", "Tên Nhân Viên", "Lương 1H",
                            "Số giờ LV", "HS Phụ Cấp", "Lương");
                        ShowDSNhanVien();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Lương trung bình = " + TinhLuongTrungBinh().ToString("N2"));
                        Console.ReadKey();
                        break;
                    case "4":
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Bạn đã nhập sai, ẤN ENTER ĐỂ TIẾP TỤC! \a");
                        Console.ReadLine();
                        Console.ResetColor();
                        break;
                } 
            }while (true) ;      
        }
        static void InputNewNhanVien()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("\t\tTHÊM NHÂN VIÊN");
                Console.WriteLine("1. Thêm Nhân viên");
                Console.WriteLine("2. Thêm Quản lý");
                Console.WriteLine("3. Thoát");
                Console.Write("\n Mời chọn? ");
                string choice = Console.ReadLine();
                switch(choice)
                {
                    case "1":
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

                        dsNhanVien.Add(new NhanVien(maSV, tenSV, tienLuong1Gio, soGioLV));
                        break;
                    case "2":
                        Console.Write(" Nhập mã nhân viên quản lý: ");
                        string maNV = Console.ReadLine();
                        Console.Write(" Nhập tên nhân viên quản lý: ");
                        string tenNV = Console.ReadLine();
                        double Luong1Gio = 0;
                        do
                        {
                            Console.Write(" Nhập số tiền lương 1 giờ: ");
                        } while (double.TryParse(Console.ReadLine(), out Luong1Gio) == false && Luong1Gio <= 0);
                        double soGio = 0;
                        do
                        {
                            Console.Write(" Nhập số giờ làm việc: ");
                        } while (double.TryParse(Console.ReadLine(), out soGio) == false && soGio < 0);
                        double hsPhuCap = 0;
                        do
                        {
                            Console.Write(" Nhập hệ số phụ cấp: ");
                        } while (double.TryParse(Console.ReadLine(), out hsPhuCap) == false && hsPhuCap <= 0);
                        dsNhanVien.Add(new NhanVienQuanLy(maNV, tenNV, Luong1Gio, soGio, hsPhuCap));
                        break;
                    case "3":
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Bạn đã nhập sai, ẤN ENTER ĐỂ TIẾP TỤC! \a");
                        Console.ReadLine();
                        Console.ResetColor();
                        break;
                }    
            } while (true); 
        }

        static void ShowDSNhanVien()
        {
            for(int i = 0; i < dsNhanVien.Count; i++)
            {
                Console.WriteLine(dsNhanVien[i].ToString());
            }    
        }

        static double TinhLuongTrungBinh()
        {
            double tong = 0;
            foreach(NhanVien nv in dsNhanVien)
            {
                tong += nv.TinhLuong();
            }
            return tong / dsNhanVien.Count;
        }
    }
}
