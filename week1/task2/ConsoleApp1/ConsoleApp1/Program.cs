using System;
using static System.Net.Mime.MediaTypeNames;

namespace BoxApplication
{
    public class Student //Declaring a class and giving its properties
    {
        public string name = "Ege Güzelgönül";   // name
        public string id = "777";  // ID
        public int yearofstudy = 1;   // year of study
    }
    class Boxtester
    {
        static void Main(string[] args)
        {
            Student defau = new Student(); //declaring class to be able access it later
            Console.WriteLine("To begin, hit 1");
            int n = Convert.ToInt32(Console.ReadLine()); //this is just a pointless integer to begin the program with

                Console.WriteLine("Please enter the new student's name"); //Asking about this new student step by step
                defau.name = Console.ReadLine(); // HERE GOES THE INPUT (LEEEEEROOOOY JENKINS!)
                Console.WriteLine("Please enter the new student's ID");
                defau.id = Console.ReadLine();
                Console.WriteLine("Please enter the new student's year of study");
                defau.yearofstudy = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("If you want to display the name of the current student, hit 1"); // Not practical, but working method of accessing info (Hey, as long as it works!)
                Console.WriteLine("If you want to display the ID of the current student, hit 2");
                Console.WriteLine("If you want to display the year of study of the current student, hit 3");
                Console.WriteLine("If you want to end the program, hit any key");
                int m = Convert.ToInt32(Console.ReadLine()); //determining the thing that the user wants to know

                if (m == 1) //output will be given depending on the input
                {
                    Console.WriteLine(defau.name);
                }

                if (m == 2)
                {
                    Console.WriteLine(defau.id);
                }

                if (m == 3)
                {
                    Console.WriteLine(defau.yearofstudy);
                }   
        }
    }
}