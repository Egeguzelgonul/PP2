using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing_stuff
{
        class Test
        {
        public static bool chkprime(int num) //function to test is number is prime or not
        {
            if (num == 1 || num == 0) //eliminating 1 and 0 because they are not prime
                return false;
            else
            for (int i = 2; i < num; i++) //if any number has a divisor except 1 or itself, its not prime
                if (num % i == 0 || num == 0 || num == 1)
                    return false;
            return true;
        }

        public static void Main(string[] args)
            {

            int n = Convert.ToInt32(Console.ReadLine()); //declaring an integer and inputting it in the console

            string[] x = Console.ReadLine().Split(' '); //splitting each input integer by space
            int[] nums = new int[x.Length]; //declaring array based on split string

            int[] priminals = new int[x.Length];
            int priminalspree = 0;

            for (int i = 0; i < n; i++)
            {
                nums[i] = Convert.ToInt32(x[i]); //every input number now becomes number in an array
                if (chkprime(nums[i])) //applying prime number function to sort out prime numbers
                {
                    priminalspree++; //for every prime counted, number grows
                    priminals[i] = Convert.ToInt32(nums[i]); //primes join in the new array
                }

            }

            Console.WriteLine(priminalspree); //displaying the the total number of primes in the input

            for (int i = 0; i < n; i++)
            {
                nums[i] = Convert.ToInt32(x[i]); //this line was copied
                if (chkprime(nums[i])) //applying prime number function to sort out prime numbers
                {
                    Console.Write(nums[i] + " "); //if it's prime, it gets outputed
                }

            }

            // Variable
            //Console.WriteLine(value);
            // Literal
            //Console.WriteLine(50.05);
        }
        }
}
