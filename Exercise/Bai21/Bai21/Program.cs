using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Bai21
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Cách ghi vào file text with content is getting from Console 

            FileStream fs = new FileStream(@"C:\a.txt",FileMode.Create, FileAccess.Write, FileShare.None);
            StreamWriter sw = new StreamWriter(fs);
            Console.WriteLine("Moi nhap 1 dong");
            string str = Console.ReadLine();

            sw.WriteLine(str);

            // giải phóng dữ liệu và đóng lại
            // nếu như không đóng lại thì dữ liệu ghi vào file sẽ mất hết
            sw.Flush();
            sw.Close();
            fs.Close();
            Console.ReadLine();
            

        }
    }
}
