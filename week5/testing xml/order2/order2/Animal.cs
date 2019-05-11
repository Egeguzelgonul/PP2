// ---------- Animal.cs ----------

using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

// With serialization you can store the state 
// of an object in a file stream, pass it to
// a remote network

namespace CSharpTutA.cs
{
    // Defines that you want to serialize this class
    [Serializable()]
    public class Animal : ISerializable
    {
        public string Name { get; set; }
        public double Wage { get; set; }

        public Animal() { }

        public Animal(string name = "No Name",
            double wage = 0)
        {
            Name = name;
            Wage = wage;
        }

        public override string ToString()
        {
            return string.Format("{0} has wage of {1}",
                Name, Wage);
        }

        // Serialization function (Stores Object Data in File)
        // SerializationInfo holds the key value pairs
        // StreamingContext can hold additional info
        // but we aren't using it here
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // Assign key value pair for your data
            info.AddValue("Name", Name);
            info.AddValue("Wage", Wage);
        }

        // The deserialize function (Removes Object Data from File)
        public Animal(SerializationInfo info, StreamingContext ctxt)
        {
            //Get the values from info and assign them to the properties
            Name = (string)info.GetValue("Name", typeof(string));
            Wage = (double)info.GetValue("Wage", typeof(double));
        }
    }
}