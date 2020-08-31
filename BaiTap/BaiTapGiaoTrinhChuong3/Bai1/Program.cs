using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("Phương trình bậc nhất bx + c = 0");
            PhuongTrinhBacNhat pt = Nhap();
            pt.ShowPhuongTrinh();
            pt.GiaiPhuongTrinhBacNhat();
            Console.ReadKey();
        }
        static PhuongTrinhBacNhat Nhap()
        {
            double b, c;
            //xử lý nhập b
            string inputLine = null;
            while (true)
            {
                try
                {
                    Console.Write("Nhập hệ số b: ");
                    inputLine = Console.ReadLine();
                    if (double.TryParse(inputLine, out b))
                    {
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Vui lòng nhập vào một số! ");
                    Console.Write("Nhập lại ! ");
                }
            }
            //xử lý nhập c
            inputLine = null;
            while (true)
            {
                try
                {
                    Console.Write("Nhập hệ số c: ");
                    inputLine = Console.ReadLine();
                    if (double.TryParse(inputLine, out c))
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Vui lòng nhập vào một số! ");
                    Console.Write("Nhập lại ! ");
                }
            }

            return new PhuongTrinhBacNhat(b, c);
        }
    }
}
