using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class Program
    {        
        static void writeFile()
        {
            string filePath = "data.txt";

            // Mở file để ghi với FileStream và StreamWriter
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            using (StreamWriter writer = new StreamWriter(fileStream, Encoding.UTF8))
            {
                writer.WriteLine("UserName: Nguyễn Minh Hải");
                writer.WriteLine("Password: 123456");
                Console.WriteLine("Dữ liệu đã được lưu");
            }
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(fileStream, Encoding.UTF8))
            {
                // Đọc và hiển thị nội dung từ file
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            writeFile();
            Console.ReadLine();
        }
    }
}
