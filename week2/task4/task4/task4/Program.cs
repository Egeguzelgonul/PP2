using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Program
    {
        private const string V = "take";

        //private static bool overwrite;
        static void AddLog(string take) //Failed function :'(
        {
            string path = @"C:\Users\asus\Desktop\Üni\PP2\week2\task4\YAY FILES\path\" + take + ".txt";
            using (var tw = new StreamWriter(path, true)) ;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Creating the file..."); // I was unable to create and move at the same time :'(
            //string take = V;
            //AddLog(take);
            string sourceFile = @"C:\Users\asus\Desktop\Üni\PP2\week2\task4\YAY FILES\path\take.txt"; //directory of the source, where the file was created
            string destFile = @"C:\Users\asus\Desktop\Üni\PP2\week2\task4\YAY FILES\path1\take.txt"; //directory of the destination, where file wants to be
            //File.Create(sourceFile);
            Console.ReadKey();
            Console.WriteLine("Copying the file...");
            //File.Copy(sourceFile, destFile);
            Console.ReadKey();
            Console.WriteLine("Deleting the original file...");
            //File.Delete(sourceFile);
            File.Move(sourceFile, destFile); // Moving = Copying and deleting at the same time, file won't be at its original directory anymore, instead, will move to the path1
            Console.ReadKey();
        }
    }
}
