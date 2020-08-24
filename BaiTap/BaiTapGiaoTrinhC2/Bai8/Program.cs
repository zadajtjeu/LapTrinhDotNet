using System;
using System.Text;

namespace Bai8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("GIẢI PHƯƠNG TRÌNH BẬC NHẤT 1 ẨN (bx + c = 0)");
            Console.Write("- Nhập hệ số b: ");
            double b;
            string B = Console.ReadLine();
            bool checkB = double.TryParse(B, out b);
            if (checkB != true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("b={0} phải là một số! ", B);
                Console.WriteLine();
                Console.ReadKey();
            }
            else
            {
                Console.Write("- Nhập hệ số c: ");
                double c;
                string C = Console.ReadLine();
                bool checkC = double.TryParse(C, out c);
                if(checkC=checkC!=true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("c={0} phải là một số ! ", C);
                    Console.WriteLine();
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Phương trình bậc 1 của bạn là {0}x + {1} = 0 ", b, c);
                    if (b == 0 && c == 0)
                        Console.WriteLine(" Phương trình vô số nghiệm! ");
                    else if (b == 0)
                        Console.WriteLine(" Phương trình vô nghiệm! ");
                    else
                        Console.WriteLine(" Phương trình có một nghiệm x = {0} ", -c / b);
                }    
            }
            Console.ReadKey();
        }
    }
}
