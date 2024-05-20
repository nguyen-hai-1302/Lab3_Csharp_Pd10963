using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Bai2
{
    class Program
    {
        static void writeFile()
        {
            string userName = "NMH";
            string passWord = "123";
            string timeSave = "60";            

            // Mở file để ghi với FileStream và StreamWriter
            using (StringWriter sw = new StringWriter())
            {
                sw.WriteLine("Username: " + userName);
                sw.WriteLine("Password: " + passWord);
                sw.WriteLine("Timesave: " + timeSave);
                string content = sw.ToString();
                using (StringReader sr = new StringReader(content))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
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
