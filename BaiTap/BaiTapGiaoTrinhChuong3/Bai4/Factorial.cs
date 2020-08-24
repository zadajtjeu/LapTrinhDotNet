using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai4
{
    class Factorial
    {
        public int n { get; set; }
        public Factorial()
        {
            n = 0;
        }
        public Factorial(int n)
        {
            this.n = n;
        }
        public static ulong operator !(Factorial a)
        {
            return CalculatorFactorial(a.n);
        }
        public static ulong CalculatorFactorial(int n)
        {
            if (n == 0)
                return 1;
            return (ulong)n * CalculatorFactorial(n - 1);
        }
    }
}
