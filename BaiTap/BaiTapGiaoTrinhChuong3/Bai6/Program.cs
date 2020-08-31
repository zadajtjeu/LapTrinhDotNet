using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("TRIANGLE");
            Triangle tamgiac = input();
            if(tamgiac.isTriangle())
            {
                Console.WriteLine("Tam giác vừa nhập là {0}\n - Có chu vi: {1}\n - Diện tích: {2}",
                    tamgiac.typeOfTriangle(), 
                    tamgiac.perimeter(),
                    tamgiac.area());
            }    
            
            Console.ReadKey();
        }
        static Triangle input()
        {
            double a, b, c;
            //xử lý nhập a
            do
            {
                Console.Write("a = ");
            } while (double.TryParse(Console.ReadLine(), out a) == false && a <= 0);
            //xử lý nhập ab
            do
            {
                Console.Write("b = ");
            } while (double.TryParse(Console.ReadLine(), out b) == false && b <= 0);
            //xử lý nhập c
            do
            {
                Console.Write("c = ");
            } while (double.TryParse(Console.ReadLine(), out c) == false && c <= 0);

            return new Triangle(a, b, c);
        }
    }
}
