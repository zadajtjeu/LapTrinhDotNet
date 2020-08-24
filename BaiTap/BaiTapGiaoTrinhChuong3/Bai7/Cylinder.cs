using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai7
{
    class Cylinder
    {
        private double radius; // bán kính
        private double height; // chiều cao
        public Cylinder()
        {
            radius = height = 0;
        }
        public Cylinder(double r, double h)
        {
            radius = r;
            height = h;
        }
        public void input()
        {
            //xử lý nhập radius
            do
            {
                Console.Write("Bán kính r = ");
            } while (double.TryParse(Console.ReadLine(), out radius) == false && radius <= 0);
            //xử lý nhập height
            do
            {
                Console.Write("Chiều cao h = ");
            } while (double.TryParse(Console.ReadLine(), out height) == false && height <= 0);
        }
        public double Volume() // Thể tích V
        {
            return Math.PI * Math.Pow(radius, 2) * height;
        }
        public double SurfaceArea() // Diện tích toàn phần
        {
            return 2 * Math.PI * radius * (radius + height);
        }
    }
}
