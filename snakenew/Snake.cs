﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakenew
{
    class Snake: Figura
    {
        public Snake(Point tail, int lenght, Direction direction)
        {
            PointList = new List<Point>();
            for (int i =0; i<lenght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                PointList.Add(p);
            }
        }

    }
}
