using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakenew
{
    class Snake : Figura
    {
        Direction direction;
        public Snake(Point tail, int lenght, Direction direction)
        {

            PointList = new List<Point>();
            for (int i = 0; i < lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                PointList.Add(p);
            }
        }

        internal void Move()
        {
            Point tail = PointList.First();
            PointList.Remove(tail);
            Point head = GetNextPoint();
            PointList.Add(head);
            tail.Clear();
            head.Draw();
        }

        private Point GetNextPoint()
        {
            Point head = PointList.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
        }
    }
}
