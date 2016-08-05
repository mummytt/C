using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Bai22
{
    class FileText
    {
        private String filename;
        public String FileName
        {
            set
            {
                filename = value;
            }
            get
            {
                return filename;

            }

        }

        // Go 3 dau / (///) thi se ghi summary as below
        ///<summary>
        ///yeu cau nguoi dung nhap vao 10 dong va in vao file text
        ///</summary>
        ///

        private FileStream fs;

        public void WriteData()
        {
            fs = new FileStream(filename, FileMode.Append, FileAccess.Write, FileShare.None );
            StreamWriter sw = new StreamWriter(fs);
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Moi nhap dong thu {0}", i);
                String str = Console.ReadLine();
                sw.WriteLine(str);
            }
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        ///<summary>
        ///Doc toan bo noi dung
        ///</summary>
        ///
        public void ReadData()
        {
            fs = new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.None) ;
            StreamReader sr = new StreamReader(fs);
            String str = sr.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }
    }
}
