using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_stuff
{
    class Test
    {
        public static void Main(string[] args)
        {

            int n = Convert.ToInt32(Console.ReadLine()); //declaring an integer and inputting it in the console

            for (int i = 0; i < n; i++)
            {
                for (int j = -1; j < i; j++)
                {
                    Console.Write("[*]");
                }
                Console.Write(System.Environment.NewLine);
            }

            // Variable
            //Console.WriteLine(value);
            // Literal
            //Console.WriteLine(50.05);
        }
    }
}
