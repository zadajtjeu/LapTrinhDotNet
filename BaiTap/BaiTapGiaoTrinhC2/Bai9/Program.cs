using System;
using System.Text;

namespace Bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.WriteLine("GIẢI PHƯƠNG TRÌNH BẬC HAI (ax^2 + bx + c = 0)");
            Console.Write("- Nhập hệ số a: ");
            double a;
            string A = Console.ReadLine();
            bool checkA = double.TryParse(A, out a);
            if (checkA != true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("a={0} phải là một số! ", A);
                Console.WriteLine();
                Console.ReadKey();
            }
            else
            {
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
                    if (checkC = checkC != true)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("c={0} phải là một số ! ", C);
                        Console.WriteLine();
                        Console.ReadKey();
                    }
                    else
                    {
                        if(a==0)
                        {
                            Console.WriteLine("Phương trình bậc 1 của bạn là {0}x + {1} = 0 ", b, c);
                            if (b == 0 && c == 0)
                                Console.WriteLine(" Phương trình vô số nghiệm! ");
                            else if (b == 0)
                                Console.WriteLine(" Phương trình vô nghiệm! ");
                            else
                                Console.WriteLine(" Phương trình có một nghiệm x = {0} ", -c / b);
                        }
                        else
                        {
                            Console.WriteLine("Phương trình bậc 2 của bạn là {0}x^2 + {1}x + {2} = 0 ",a, b, c);
                            double delta = b*b-4*a*c;
                            if (delta > 0)
                            {
                                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                                Console.WriteLine("Nghiệm x1 = "+ x1);
                                Console.WriteLine("Nghiệm x2 = "+ x2);
                            }
                            else if (delta == 0)
                            {
                                Console.WriteLine("Phương trình có nghiệm kép: x1 = x2 = {0}",-b / 2 * a);
                            }
                            else
                            {
                                Console.WriteLine(" Phương trình vô nghiệm! ");
                            }
                        }    
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
