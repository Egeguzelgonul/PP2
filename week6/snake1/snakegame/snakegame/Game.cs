using System;
using System.Collections.Generic;
namespace Example3
{
    public class Game
    {
        List<GameObject> g_objects;
        public bool isAlive;
        public Snake snake;
        public Food food;
        public Wall wall;

        public Game()
        {
            //int score = snake.body.Count;
            g_objects = new List<GameObject>();
            snake = new Snake(20, 10, '*', ConsoleColor.White);
            food = new Food(0, 0, 'o', ConsoleColor.Cyan);
            wall = new Wall('#', ConsoleColor.Green);
            wall.LoadLevel();
            while (food.IsCollisionWithObject(snake) || food.IsCollisionWithObject(wall))
                food.Generate();

            g_objects.Add(snake);
            g_objects.Add(food);
            g_objects.Add(wall);

            isAlive = true;
        }

        public void Showscore()
        {
            int score = snake.body.Count;
            Console.Clear();
            Console.Write("Current Player's score:");
            Console.Write(score);
        }

        public void Start()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            while (isAlive && keyInfo.Key != ConsoleKey.Escape)
            {
                Draw();
                keyInfo = Console.ReadKey();
                //if (keyInfo.Key == ConsoleKey.Z)
                //{
                    //Showscore();
                    //Console.ReadKey();
                //}
                if (snake.IsCollisionWithObject(food))
                {
                    snake.body.Add(new Point(0, 0));
                    while (food.IsCollisionWithObject(snake) || food.IsCollisionWithObject(wall))
                        food.Generate();

                    if (snake.body.Count % 3 == 0)
                        wall.NextLevel();
                }
                if (snake.IsCollisionWithObject(wall))
                {
                    isAlive = false;
                }
                snake.Move(keyInfo);
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(20, 10);
            Console.WriteLine("GAME OVER!!!");
        }
        public void Draw()
        {
            Console.Clear();
            Showscore();
            foreach (GameObject g in g_objects)
                g.Draw();
        }

    }
}