using System;
using System.IO;
using System.Text;

namespace Chuong2Bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            
            string choice = "";
            do
            {
                Console.Clear();
                Console.WriteLine("ĐỌC GHI CÁC MẶT HÀNG");
                Console.WriteLine("\n1. Nhập và lưu danh sách các mặt hàng vào file text");
                Console.WriteLine("\n2. Hiển thị các mặt hàng trong file text ra");
                Console.WriteLine("\n3. Thoát");
                Console.Write("\nXin mời chọn? ");
                choice = Console.ReadLine();
                switch(choice)
                {
                    case "1":
                        InputItems();
                        break;
                    case "2":
                        ShowItems();
                        break;
                    case "3":
                        break;
                    default:
                        Console.WriteLine("\a");
                        break;
                }
            }while (choice != "3") ;
            Console.WriteLine("\nPress any key to close this window . . .");
            Console.ReadLine();
        }
        static void InputItems()
        {
            StreamWriter write = new StreamWriter("db.txt",true);
            string continuteWrite = "";
            do
            {
                Console.WriteLine("Nhập tên mặt hàng: ");
                write.WriteLine(Console.ReadLine());
                Console.Write("Nhập tiếp? (y/n) ");
                continuteWrite = Console.ReadLine();
            } while (continuteWrite != "n");
            write.Close();
        }
        static void ShowItems()
        {
            StreamReader read = new StreamReader("db.txt");
            while(read.Peek() != -1)
            {
                Console.WriteLine(read.ReadLine());
            }
            read.Close();
            Console.ReadLine();
        }
    }
}
