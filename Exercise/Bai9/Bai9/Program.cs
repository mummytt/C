using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bai9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moi ban nhap ");
            string a = Console.ReadLine();
            string b = space(a);
            string c = UppercaseWords(b);
            Console.WriteLine("\n Ket qua la {0}", c);
            Console.ReadLine();

        }

        public static string UppercaseWords(string value)
        {
            char[] array = value.ToCharArray();

            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    if (char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }
            return new string(array);
        }

        public static string space(string str)

        { 
            string[] a = str.Split(' ');
            string c = "";
            for (int i = 0; i < a.Length; i++)
            {
                if (!a[i].Equals(""))
                {
                    c += " " + a[i];
                }
            }

            return c;
        }

    }
}
