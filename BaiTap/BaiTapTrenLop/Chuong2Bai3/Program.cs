using System;
using System.Text;

namespace Chuong2Bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tính tiền lãi hàng tháng
            Console.OutputEncoding = Encoding.UTF8;

            double tienGuiHangThang = 0,
                   tienThuHangThang = 0,
                   laiSuatHangThang = 0;
            int soThang;
            Console.Write("Nhập số tiền tiết kiệm hàng tháng: ");
            tienGuiHangThang = double.Parse(Console.ReadLine());
            Console.Write("Nhập % lãi suất tháng: ");
            laiSuatHangThang = double.Parse(Console.ReadLine());
            Console.Write("Nhập số tháng gửi tiết kiệm: ");
            soThang = int.Parse(Console.ReadLine());

            Console.WriteLine("Tháng\t Tiền cuối tháng");
            Console.WriteLine("=======for======");
            for(int i=1; i<=soThang; i++)
            {
                tienThuHangThang = (tienGuiHangThang + tienThuHangThang)
                                    * (1.0 + laiSuatHangThang / 100);
                Console.WriteLine("{0}\t{1}", i, tienThuHangThang.ToString("N2"));
            }
            Console.WriteLine("=======while======");
            int thangThu = 1;
            tienThuHangThang = 0;
            while(thangThu<=soThang)
            {
                tienThuHangThang = (tienGuiHangThang + tienThuHangThang)
                                    * (1.0 + laiSuatHangThang / 100);
                Console.WriteLine("{0}\t{1}", thangThu++, tienThuHangThang.ToString("N2"));
 
            }    
            Console.ReadLine();
        }
    }
}
