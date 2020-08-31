using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            //ArrayList dsHocSinh = new ArrayList();
            List<HocSinh> dsHocSinh = new List<HocSinh>();
            int n;
            do
            {
                Console.Write("Nhập số học sinh: ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n <= 0)
                    Console.WriteLine("Nhập lại !");

            } while (n <= 0);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("#Thông tin học sinh thứ {0}", i + 1);
                Console.Write("Họ tên : ");
                string hoten = Console.ReadLine();
                Console.Write("Tuổi : ");
                int tuoi = Convert.ToInt32(Console.ReadLine());
                Console.Write("Toán : ");
                int diemT = Convert.ToInt32(Console.ReadLine());
                Console.Write("Lý : ");
                int diemL = Convert.ToInt32(Console.ReadLine());
                Console.Write("Hóa : ");
                int diemH = Convert.ToInt32(Console.ReadLine());

                HocSinh hs = new HocSinh(hoten, tuoi, diemT, diemL, diemH);
                dsHocSinh.Add(hs);
                Console.WriteLine("======================================");
            }

            Console.WriteLine("\tDANH SÁCH HỌC SINH");
            Console.WriteLine("hoten\t tuoi\t diemT\t diemL\t diemH\t DTB");
            foreach (HocSinh item in dsHocSinh)
            {
                Console.WriteLine(item.ToString());
            }

            //Sort Diem Trung Binh
            dsHocSinh.Sort(); // Sắp xếp

            Console.WriteLine("\tDANH SÁCH HỌC SINH SẮP XẾP THEO ĐIỂM TRUNG BÌNH");
            Console.WriteLine("hoten\t tuoi\t diemT\t diemL\t diemH\t DTB");
            foreach (HocSinh item in dsHocSinh)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }
    }
}
