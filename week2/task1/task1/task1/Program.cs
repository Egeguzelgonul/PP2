using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{

    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("readthis.txt");

            string line = "";

            line = sr.ReadLine();

            Console.WriteLine(line);
            if (GetStatus(line))
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }

        private static bool GetStatus(string line)
        {
            string first = line.Substring(0, line.Length / 2);
            char[] arr = line.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);

            return first.Equals(second);
        }
    }

}
