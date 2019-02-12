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
        public static bool chkprime(int num) //function to check if the number is prime
        {
            if (num == 1 || num == 0) //1 and 0 is prime, no suprise there
                return false;
            else
                for (int i = 2; i < num; i++) 
                    if (num % i == 0 || num == 0 || num == 1)
                        return false; // if it has any other divisor(s), then it is not prime
            return true;
        }

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("input.txt"); //clarifying input file

            string line = ""; //empty string for now

            line = sr.ReadLine(); //string becomes input files' line

            Console.WriteLine(line); //outputing the line

            string[] x = line.Split(' '); //splitting everything in the line using spaces
            int[] nums = new int[x.Length]; //array is the new home for all of these new numbers

            string finalproduct = ""; //empty string, which plans to become the array of the primes one day

            for (int i = 0; i < nums.Length; i++) //classic loop that goes as much as the numbers are here
            {
                nums[i] = Convert.ToInt32(x[i]); //they are now integers
                if (chkprime(nums[i])) //checking if they are prime
                {
                    Console.Write(nums[i] + " "); //Primes! show yourselves!
                    finalproduct = finalproduct + nums[i] + " "; //get in the array!
                }

            }
            //Console.WriteLine(finalproduct);
            System.IO.File.WriteAllText(@"output.txt", finalproduct); //this file is a place to be for the primes
        }
    }
}
