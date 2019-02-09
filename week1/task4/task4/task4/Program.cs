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

            for (int i = 0; i < n; i++) //cycle for the number of rows in total
            {
                for (int j = -1; j < i; j++) //second cycle which always repeats itself as much as there is current "i", example: i = 3, 3 = number of stars printed
                {
                    Console.Write("[*]"); //simply printing one star
                }
                Console.Write(System.Environment.NewLine); //it's like endl; in c++, presses enter and jumps to the next row
            }

            // Variable
            //Console.WriteLine(value);
            // Literal
            //Console.WriteLine(50.05);
        }
    }
}
