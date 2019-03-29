using System;
using System.Collections.Generic;
using System.Text;

namespace snake2
{
    abstract class GameObject
    {
        public List<Point> body = new List<Point>();
        protected char sign;

        public GameObject(char sign)
        {
            this.sign = sign;
        }

        public void Draw()
        {
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.X, p.Y);
                Console.Write(sign);
            }
        }

        public void Clear()
        {
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.X, p.Y);
                Console.Write(' ');
            }
        }
    }
}
