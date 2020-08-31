using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            List<ThuVien> dsSach = new List<ThuVien>(); ;

            int n;
            do
            {
                Console.WriteLine("Số lượng Sách : ");
                n = Convert.ToInt32(Console.ReadLine());
                if (n <= 0)
                    Console.WriteLine("Nhập lại !");
            } while (n <= 0);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("#Thông tin sách thứ {0}", i + 1);
                Console.Write("Tựa đề: ");
                string tuaDe = Console.ReadLine();
                Console.Write("Tác Giả: ");
                string tacGia = Console.ReadLine();
                Console.Write("Số lượng: ");
                int soLuong = Convert.ToInt32(Console.ReadLine());
                ThuVien sach = new ThuVien(tuaDe, tacGia, soLuong);
                dsSach.Add(sach);
                Console.WriteLine("--------------------------------------");
            }

            Console.WriteLine("\tDANH SÁCH");
            Console.WriteLine("Tựa đề \t Tác giả \t Số lượng");
            foreach (ThuVien item in dsSach)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadLine();
        }
    }
}
