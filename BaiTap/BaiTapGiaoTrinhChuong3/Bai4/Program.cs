﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Factorial");
            Factorial so = new Factorial(int.Parse(Console.ReadLine()));
            Console.WriteLine("n! = {0}! = {1}", so.n, !so);
            Console.ReadKey();
        }
    }
}
