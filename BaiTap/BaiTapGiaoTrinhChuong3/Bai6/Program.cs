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
            Triangle tamgiac = new Triangle();
            tamgiac.input();
            if(tamgiac.isTriangle())
            {
                Console.WriteLine("Tam giác vừa nhập là {0}\n - Có chu vi: {1}\n - Diện tích: {2}",
                    tamgiac.typeOfTriangle(), 
                    tamgiac.perimeter(),
                    tamgiac.area());
            }    
            
            Console.ReadKey();
        }
    }
}
