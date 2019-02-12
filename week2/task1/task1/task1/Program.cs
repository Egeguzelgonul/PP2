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
            StreamReader sr = new StreamReader("readthis.txt"); //declaring the name of the input file

            string line = ""; //empty string for now

            line = sr.ReadLine(); //empty string is a string from the input file

            Console.WriteLine(line); //input whatever was in the input file
            if (GetStatus(line)) //applying boolean function to test out is it palindrome or not
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }

        private static bool GetStatus(string line) //function to check if its palindrome or not
        {
            string first = line.Substring(0, line.Length / 2);
            char[] arr = line.ToCharArray();

            Array.Reverse(arr);

            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2);

            return first.Equals(second); //if reverse = original, it's palindrome!
        }
    }

}
