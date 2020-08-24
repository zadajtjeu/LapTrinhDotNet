using System;
using System.Text;

namespace Chuong2Bai5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Xử lý ngoại lệ giải phương trình bậc hai
            Console.WriteLine("Giải phương trình bậc hai, ax + b = 0!");

            double a, b, x;
            string chuoi1, chuoi2;

            //Xử lý nhập a
            Console.Write("Nhập hệ số a: ");
            chuoi1 = Console.ReadLine();
            if (chuoi1 != String.Empty)
            {
                try
                {
                    a = double.Parse(chuoi1);

                    // Xử lý nhập b
                    Console.Write("Nhập hệ số b: ");
                    chuoi2 = Console.ReadLine();
                    if (chuoi2 != "")
                    {
                        try
                        {
                            b = Convert.ToDouble(chuoi2);

                            // Xử lý phép tính
                            try
                            {
                                x = -b / a;
                                Console.WriteLine("\nPhuong trinh {0}x+{1}=0 co nghiem x={2}", a, b, x);
                            }
                            catch (Exception e)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Phương trình vô nghiệm hoặc vô số nghiệm!");
                                Console.WriteLine(e.ToString());
                            }
                        }
                        catch (Exception e)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Hệ số b phải là số!");
                            Console.WriteLine(e.ToString());
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Bạn chưa nhập hệ số b!");
                    }
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Số a phải là một số!");
                    Console.WriteLine(e.ToString());
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Bạn chưa nhập hệ số a!");
            }

            Console.ReadLine();
        }
    }
}
