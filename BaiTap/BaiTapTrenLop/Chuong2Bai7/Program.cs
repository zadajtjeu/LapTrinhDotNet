using System;
using System.Text;
using System.Collections.Generic;
namespace Chuong2Bai7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var danhSach = new List<double>();
            //Nhập danh sách
            Console.WriteLine("Nhập vào danh sách các số: ");
            inputList(danhSach);
            //Xuất danh sách
            Console.WriteLine("Danh sách các số vừa nhập là: ");
            outputList(danhSach);
            //Số lớn nhất và nhỏ nhất trong danh sách
            Console.WriteLine("Phần tử lớn nhất trong danh sách là: {0}", FindMaxNumber(danhSach));
            Console.WriteLine("Phần tử nhỏ nhất trong danh sách là: {0}", FindMinNumber(danhSach));
            Console.ReadLine();
        }
        static void inputList(List<double> ds)
        {
            while(true)
            {
                Console.Write("Nhập vào 1 số: ");
                ds.Add(double.Parse(Console.ReadLine()));
                Console.Write("Bạn có muốn nhập tiếp không? (y/n) ");
                string choice = Console.ReadLine();
                if (choice == "n" || choice == "N")
                    break;
            }
        }
        static void outputList(List<double> ds)
        {
            foreach(double item in ds)
                Console.Write("\t{0}", item);
            Console.WriteLine();
        }
        static double FindMaxNumber(List<double> ds)
        {
            double maxNumer = ds[0];
            for(int i=1; i<ds.Count; i++)
            {
                if (maxNumer < ds[i])
                    maxNumer = ds[i];
            }

            return maxNumer;
        }
        static double FindMinNumber(List<double> ds)
        {
            double minNumer = ds[0];
            for (int i = 1; i < ds.Count; i++)
            {
                if (minNumer > ds[i])
                    minNumer = ds[i];
            }

            return minNumer;
        }
    }
}
