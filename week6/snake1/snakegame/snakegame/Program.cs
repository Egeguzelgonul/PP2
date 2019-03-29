using System;

namespace Example3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
            Console.WriteLine("Please Enter your Username:");
            string username = Console.ReadLine();
            
            Console.CursorVisible = false;
            Game game = new Game();
            game.Start();
        }
    }
}