using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void KBTU_RECURSIVE(string directory, int level) //a twisted recursion begins
        {
            if (!Directory.Exists(directory)) //detecting the directory
                return;
            string interval = new string('\t', level++); //down you go in the directories, more levels you get
            string[] files = Directory.GetFiles(directory); //Files will be outputed

            Console.WriteLine(string.Concat(interval, " ", directory)); //showing the directory

            interval += "\t";
            foreach (string file in files)
                Console.WriteLine(string.Concat(interval, " ", Path.GetFileName(file))); //showing the file according to its level, more the level, more spaces!
            foreach (string fold in Directory.GetDirectories(directory))
                KBTU_RECURSIVE(fold, level);// Now function goes to recursion, where it returns the increased level to itself, and in the next recursion it will find more files
        }

        static void Main(string[] args)
        {
            KBTU_RECURSIVE(@"C:\Users\asus\Desktop\Üni\PP2\", 0);
        }
    }
}
