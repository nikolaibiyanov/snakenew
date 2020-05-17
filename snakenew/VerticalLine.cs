using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakenew
{
    class VerticalLine: Figura
    {
        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            PointList = new List<Point>();
            for (int y = yUp; y<= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                PointList.Add(p);
            }

        }
    }

}
