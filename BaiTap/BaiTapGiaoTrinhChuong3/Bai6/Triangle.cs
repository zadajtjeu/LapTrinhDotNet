using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai6
{
    class Triangle
    {
        double a, b, c;
        public Triangle()
        {
            a = b = c = 0;
        }
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public bool isTriangle()
        {
            if (a + b > c && a + c > b && b + c > a)
                return true;
            return false;
        }

        public string typeOfTriangle()
        {
            int check = 0;
            string triangleType = null;
            if (a == b || a == c || c == b)
                check++;
            if (a == b && b == c)
                check++;
            if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                check += 3;
            switch(check)
            {
                case 0: triangleType = "Tam giác thường"; break;
                case 1: triangleType = "Tam giác cân"; break;
                case 2: triangleType = "Tam giác đều"; break;
                case 3: triangleType = "Tam giác vuông"; break;
                case 4: triangleType = "Tam giác vuông cân"; break;
            }

            return triangleType;
        }

        public double perimeter()
        {
            return a + b + c;
        }
        public double area()
        {
            double s = perimeter()/2; //semiperimeter
            double T = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return T;
        }
    }
}
