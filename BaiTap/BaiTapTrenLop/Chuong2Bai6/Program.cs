using System;
using System.Text;
namespace Chuong2Bai6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập vào số phần tử trong mảng: ");
            int n = int.Parse(Console.ReadLine());
            int[] mang = new int[n];

            //Nhập mảng
            InputArray(mang);
            //Xuất mảng
            Console.WriteLine("Các phần tử trong mảng vừa nhập: ");
            OutputArray(mang);
            //Tính trung bình cộng các phần tử
            Console.WriteLine("Trung bình cộng của các phần tử trong mảng: {0}", AVGArray(mang).ToString("N2"));
            Console.ReadLine();
        }
        
        static void InputArray(int[] mang)
        {
            for(int i = 0; i < mang.Length; i++)
            {
                Console.Write("Nhập phần tử thứ {0}: ", i + 1);
                mang[i] = int.Parse(Console.ReadLine());
            }    
        }

        static void OutputArray(int[] mang)
        {
            foreach (int phantu in mang)
                Console.Write("\t{0}", phantu);
            Console.WriteLine();
        }
        static double AVGArray(int[] mang)
        {
            int tong = 0;
            foreach(int phantu in mang)
            {
                tong += phantu;
            }
            return (double)tong / (double)mang.Length;
        }
    }
}
