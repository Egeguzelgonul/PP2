using System;

namespace BoxApplication
{
    public class Student
    {
        public string name;   // Length of a box
        public string id;  // Breadth of a box
        public string yearofstudy;   // Height of a box
    }
    class Boxtester
    {
        static void Main(string[] args)
        {
            Student Student1 = new Student();   // Declare Box1 of type Box
            Student Student2 = new Student();   // Declare Box2 of type Box
            double volume = 0.0;    // Store the volume of a box here

            // box 1 specification
            Student1.name = "Ege Güzelgönül";
            Student1.id = "BlablablaMYID";
            Student1.yearofstudy = "1";

            // box 2 specification
            Student2.name = "Remzi";
            Student2.id = "IDK what is my id?";
            Student2.yearofstudy = "9000";

            Console.WriteLine("Enter The");

        }
    }
}