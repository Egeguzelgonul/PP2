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

            string[] x = Console.ReadLine().Split(' '); //splitting each input integer by space
            int[] nums = new int[x.Length]; //declaring array based on split string
            int[] nums2 = new int[x.Length]; //declaring array based on split string

            for (int i = 0; i < n; i++)
            {
                nums[i] = Convert.ToInt32(x[i]); //every input number now becomes number in an array
            }

            for (int i = 0; i < n; i++)
            {
                nums2[i] = Convert.ToInt32(x[i]); //every input number now becomes number in an array
            }

            for (int i = 0; i < n; i++)
            {
                nums[i] = Convert.ToInt32(x[i]); //this line was copied
                Console.Write(nums[i] + " " + nums2[i] + " "); //each "i" in the loop outputs itself twice with a space between

            }

            // Variable
            //Console.WriteLine(value);
            // Literal
            //Console.WriteLine(50.05);
        }
    }
}
