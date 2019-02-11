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
        static void KBTU_RECURSIVE(string directory, int level)
        {
            if (!Directory.Exists(directory))
                return;
            string interval = new string('\t', level++);
            string[] files = Directory.GetFiles(directory);

            Console.WriteLine(string.Concat(interval, " ", directory));

            interval += "\t";
            foreach (string file in files)
                Console.WriteLine(string.Concat(interval, " ", Path.GetFileName(file)));
            foreach (string fold in Directory.GetDirectories(directory))
                KBTU_RECURSIVE(fold, level);
        }

        static void Main(string[] args)
        {
            KBTU_RECURSIVE(@"C:\Users\asus\Desktop\Üni\PP2\", 0);
        }
    }
}
