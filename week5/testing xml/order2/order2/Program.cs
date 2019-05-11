
// ---------- Program.cs ----------

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

// Used for writing to a file
using System.IO;

// Used to serialize an object to binary format
using System.Runtime.Serialization.Formatters.Binary;

// Used to serialize into XML
using System.Xml.Serialization;

namespace CSharpTutA.cs
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Hit 1 to Show all Employes");
            Console.WriteLine("Hit 2 to Add a new one");
            int n = Convert.ToInt32(Console.ReadLine()); //declaring an integer and inputting it in the console

            Animal bowser = new Animal("Bowser", 45);

            // Serialize the object data to a file
            Stream stream = File.Open("AnimalData.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();

            // Send the object data to the file
            bf.Serialize(stream, bowser);
            stream.Close();

            // Delete the bowser data
            bowser = null;

            // Read object data from the file
            stream = File.Open("AnimalData.dat", FileMode.Open);
            bf = new BinaryFormatter();

            bowser = (Animal)bf.Deserialize(stream);
            stream.Close();

            // Change bowser to show changes were made
            bowser.Wage = 50;

            // XmlSerializer writes object data as XML
            XmlSerializer serializer = new XmlSerializer(typeof(Animal));
            using (TextWriter tw = new StreamWriter(@"bowser.xml")) //("{0} has wage of {1}", Name, Wage)
            {
                serializer.Serialize(tw, bowser);
            }

            // Delete bowser data
            bowser = null;

            // Deserialize from XML to the object
            XmlSerializer deserializer = new XmlSerializer(typeof(Animal));
            TextReader reader = new StreamReader(@"bowser.xml");
            object obj = deserializer.Deserialize(reader);
            bowser = (Animal)obj;
            reader.Close();

            //Console.WriteLine(bowser.ToString());

            // Save a collection of Animals
            List<Animal> theAnimals = new List<Animal>
            {
                new Animal("Mario", 60),
                new Animal("Luigi", 55),
                new Animal("Peach", 40)
            };

            // Delete list data
            //theAnimals = null;

            // Read data from XML
            XmlSerializer serializer3 = new XmlSerializer(typeof(List<Animal>));

            using (FileStream fs2 = File.OpenRead(@"animals.xml"))
            {
                theAnimals = (List<Animal>)serializer3.Deserialize(fs2);
            }

            //comeback here!
            if (n == 1)
            {
                foreach (Animal a in theAnimals)
                {
                    Console.WriteLine(a.ToString());
                }
            }

            if (n == 2)
            {
                string newname = Console.ReadLine();
                double newwage = Convert.ToDouble(Console.ReadLine());
                Animal newemployee = new Animal(newname, newwage);

                theAnimals.Add(newemployee);

                using (Stream fs = new FileStream(@"animals.xml",
                FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    XmlSerializer serializer2 = new XmlSerializer(typeof(List<Animal>));
                    serializer2.Serialize(fs, theAnimals);
                }
            }

            Console.ReadLine();

        }
    }
}