using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakenew
{
    class HorizontalLine :Figura
    {
   

        public HorizontalLine (int xleft,int xRaight, int y, char sym)
        {
            PointList = new List<Point>();
            for (int x = xleft; x <= xRaight; x++)
            {
                Point p = new Point(x, y, sym);
                PointList.Add(p);
            }
        }


    }
}
