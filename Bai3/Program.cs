using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3
{
    internal class Program
    {
        static void Create()
        {
            string dataDirectory = @"..\\..\\..\data\\";
            Directory.CreateDirectory(dataDirectory);
            string dataFilePath = Path.Combine(dataDirectory, "data.txt");
            using (StreamWriter sw = new StreamWriter(dataFilePath))
            {
                sw.WriteLine("Dữ liệu đã được thêm vào file data.txt trong thư mục data");
            }
            Console.WriteLine("Dữ liệu đã ghi xong: " + dataFilePath);
        }
        static void Copy()
        {
            string sourceDirectory = @"..\\..\\..\data\\";
            string targetDirectory = @"..\\..\\..\data2\\";
            if (Directory.Exists(sourceDirectory))
            {
                Directory.CreateDirectory(targetDirectory);
                string[] files = Directory.GetFiles(sourceDirectory);
                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    string targetFile = Path.Combine(targetDirectory, fileName);
                    File.Copy(file, targetFile, true);
                }
                Console.WriteLine("Sao chép hoàn tất");
            }
            else
            {
                Console.WriteLine("Thư mục nguồn không tồn tại");
            }           
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Create();
            Copy();
            Console.ReadLine();
        }
    }
}
