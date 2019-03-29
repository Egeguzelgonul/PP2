using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace snake2
{
    class Program
    {
        static void Main(string[] args)
        {
            GameState gameState = new GameState();

            while(true)
            {
                gameState.Draw();

                ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();

                gameState.ProcessKey(consoleKeyInfo);
            }
        }
    }
}
