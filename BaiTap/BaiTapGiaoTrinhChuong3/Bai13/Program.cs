using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai13
{
    class Program
    {
        private static List<CONGNHAN> dsCongNhan = new List<CONGNHAN>();
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Nhập danh sách 
            Console.WriteLine("\tNHẬP THÔNG TIN");
            NhapDsCongNhan();
            //Xuất danh sách 
            Console.WriteLine("\tDANH SACH CONG NHAN");
            XuatDsCongNhan();
            //hsluong max
            Console.WriteLine("=====Công nhân có hệ số lương cao nhất===");
            CONGNHAN.MaxHsLuong(dsCongNhan);
            Console.ReadLine();
        }

        //Nhập ds công nhân
        static void NhapDsCongNhan()
        {
            string select = "Y";
            while (select == "Y")
            {
                Console.Write("Họ tên: ");
                string hoten = Console.ReadLine();
                Console.Write("Giới tính: ");
                string gioitinh = Console.ReadLine();
                Console.Write("Năm sinh: ");
                int namsinh = Convert.ToInt32(Console.ReadLine());
                Console.Write("Địa chỉ: ");
                string diachi = Console.ReadLine();
                Console.Write("Tên công ty: ");
                string tencongty = Console.ReadLine();

                Console.Write("Ngày vào làm việc: ");
                Console.Write("Năm: ");
                int nam = Convert.ToInt32(Console.ReadLine());
                Console.Write("Tháng: ");
                int thang = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ngày: ");
                int ngay = Convert.ToInt32(Console.ReadLine());
                DateTime dateTime = new DateTime(nam, thang, ngay);

                Console.Write("Hệ số lương: ");
                double hesoluong = Convert.ToDouble(Console.ReadLine());

                CONGNHAN cn = new CONGNHAN(hoten, gioitinh, namsinh, diachi, tencongty, dateTime, hesoluong);
                dsCongNhan.Add(cn);
                Console.WriteLine("==============================================");
                Console.WriteLine("Y : Nhập tiếp\nN : Dừng nhập");
                select = Console.ReadLine().ToUpper();
                Console.WriteLine("==============================================");
            }
        }

        //Xuất
        static void XuatDsCongNhan()
        {
            foreach (CONGNHAN item in dsCongNhan)
            {
                Console.WriteLine(item.ToString());
            }
        }

    }
}
