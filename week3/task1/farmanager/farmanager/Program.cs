using System;
using System.IO;

namespace Ex1
{
    class FarManager
    {
        public int cursor; //declaring all the variables required
        public string path;
        public int sz;
        public bool ok;
        DirectoryInfo directory = null;
        FileSystemInfo currentFs = null;
        public int numberoffiles = 0;
        public int numberoffolders = 0;

        public FarManager()
        {
            cursor = 0;
        }

        public FarManager(string path) //function with all the primary variables to run the program
        {
            this.path = path;
            cursor = 0;
            directory = new DirectoryInfo(path);
            sz = directory.GetFileSystemInfos().Length;
            ok = true;
        }

        public void Color(FileSystemInfo fs, int index) //Simply, colors
        {
            if (cursor == index) //color of the object that cursor is hovering upon
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                currentFs = fs;
            }
            else if (fs.GetType() == typeof(DirectoryInfo)) //folder color, or objects that can be entered
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else //anything else, particularly unaccessable by the far manager, files
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            }
        }

        public void Show() //function to show off the menu
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            directory = new DirectoryInfo(path);
            FileSystemInfo[] fs = directory.GetFileSystemInfos();
            for (int i = 0, k = 0; i < fs.Length; i++)
            {
                if (ok == false && fs[i].Name[0] == '.')
                {
                    continue;
                }
                Color(fs[i], k);
                Console.WriteLine(fs[i].Name);
                k++;
            }
        }

        public void Showcontentamount()
        {
            directory = new DirectoryInfo(path);
            FileSystemInfo[] fs = directory.GetFileSystemInfos();
            numberoffiles = 0;
            numberoffolders = 0;

            for (int i = 0, k = 0; i < fs.Length; i++)
            {
                if (fs[i].GetType() == typeof(DirectoryInfo)) // Everytime we get inside a directory, cursor is always at the top
                {
                    numberoffolders++;
                }
                else
                {
                    numberoffiles++;
                }
            }
            Console.Write("Number of Files :", numberoffiles);
            Console.Write(numberoffiles);
            Console.WriteLine(" ");
            Console.Write("Number of Folders :", numberoffolders);
            Console.Write(numberoffolders);
            Console.ReadKey();
        }

        public void Up() //function for navigating up
        {
            cursor--;
            if (cursor < 0)
                cursor = sz - 1;
        }
        public void Down() //function for navigating down
        {
            cursor++;
            if (cursor == sz)
                cursor = 0;
        }

        public void CalcSz() //function to make sure folder and all the indexes are consistent with each other
        {
            numberoffolders = 0;
            numberoffiles = 0;

            directory = new DirectoryInfo(path);
            FileSystemInfo[] fs = directory.GetFileSystemInfos();
            sz = fs.Length;
            if (ok == false)
                for (int i = 0; i < fs.Length; i++)
                    if (fs[i].Name[0] == '.')
                    {
                        numberoffiles++;
                        sz--;
                    }
            //Console.Write("Number of Files :", numberoffiles);
            //Console.Write(numberoffiles);
            //Console.WriteLine(" ");
            //Console.Write("Number of Folders :", numberoffolders);
            //Console.Write(sz);
            //Console.ReadKey();
        }

        public void Del()
        {
            if (currentFs.GetType() == typeof(DirectoryInfo)) // Everytime we get inside a directory, cursor is always at the top
            {
                cursor = 0;
                Directory.Delete(currentFs.FullName);
            }
            else
            {
                cursor = 0;
                File.Delete(currentFs.FullName);
            }
        }

        public void Intxt()
        {
            //if (currentFs.GetType() == typeof(DirectoryInfo))
            //{
            Console.WriteLine("*******************BEEP_BOOP_I_AM_A_TEXT_FILE*******************"); //outputing the line

            string line = ""; //empty string for now

            line = File.ReadAllText(currentFs.FullName);

                Console.WriteLine(line);
            Console.WriteLine("*******************PRESS_ANY_KEY_TO_PROCEED*******************"); //outputing the line

            Console.ReadKey();
            //}
        }

        public void Renamer()
        {
            if (currentFs.GetType() == typeof(DirectoryInfo))
            {
                string line = Console.ReadLine(); //empty string for now

                String parentti = path;
                Console.WriteLine(parentti);
                line = parentti + "/" + line;
                System.IO.Directory.Move(currentFs.FullName, line);
                Console.WriteLine(line);
                Console.ReadKey();
            }
            else
            {
            string pusan = Console.ReadLine(); //empty string for now

                String parentti = path;
                Console.WriteLine(parentti);
                pusan = parentti + "/" + pusan;
                System.IO.File.Move(currentFs.FullName, pusan);
                Console.WriteLine(pusan);
            Console.ReadKey();
            }
        }

        public void Start()
        {
            ConsoleKeyInfo consoleKey = Console.ReadKey();
            while (consoleKey.Key != ConsoleKey.Escape) //escape will terminate the program
            {
                CalcSz();
                Show();
                consoleKey = Console.ReadKey();
                if (consoleKey.Key == ConsoleKey.UpArrow) // if user presses up, up function plays
                    Up();
                if (consoleKey.Key == ConsoleKey.DownArrow) //if user presses down, down function plays
                    Down();
                if (consoleKey.Key == ConsoleKey.RightArrow) //toggles ok off, resets the cursor
                {
                    ok = false;
                    cursor = 0;
                }
                if (consoleKey.Key == ConsoleKey.LeftArrow) //toggles of on, resets the cursor
                {
                    cursor = 0;
                    ok = true;
                }
                if (consoleKey.Key == ConsoleKey.Enter) // Entering folder
                {
                    if (currentFs.GetType() == typeof(DirectoryInfo)) // Everytime we get inside a directory, cursor is always at the top
                    {
                        cursor = 0;
                        path = currentFs.FullName;
                    }
                }
                if (consoleKey.Key == ConsoleKey.Backspace) // for going back in folder
                {
                    cursor = 0;
                    path = directory.Parent.FullName; //returns folder to its parent(previous folder)
                }
                if (consoleKey.Key == ConsoleKey.Delete) // if user presses up, up function plays
                    Del();
                if (consoleKey.Key == ConsoleKey.Spacebar) // if user presses up, up function plays
                    Intxt();
                if (consoleKey.Key == ConsoleKey.X) // if user presses up, up function plays
                    Renamer();
                if (consoleKey.Key == ConsoleKey.C) // if user presses up, up function plays
                    Showcontentamount();
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            string path = "/Users/asus/desktop/Üni/PP2/trash";
            FarManager farManager = new FarManager(path);
            farManager.Start();
        }
    }
}
