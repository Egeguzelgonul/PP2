using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        public static bool chkprime(int num) 
        {
            if (num == 1 || num == 0) 
                return false;
            else
                for (int i = 2; i < num; i++) 
                    if (num % i == 0 || num == 0 || num == 1)
                        return false;
            return true;
        }

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt");

            string line = "";

            line = sr.ReadLine();

            Console.WriteLine(line);

            string[] x = line.Split(' '); 
            int[] nums = new int[x.Length]; 

            string finalproduct = "";

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = Convert.ToInt32(x[i]); 
                if (chkprime(nums[i])) 
                {
                    Console.Write(nums[i] + " "); 
                    finalproduct = finalproduct + nums[i] + " ";
                }

            }
            //Console.WriteLine(finalproduct);
            System.IO.File.WriteAllText(@"output.txt", finalproduct);
        }
    }
}
