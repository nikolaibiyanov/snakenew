using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakenew
{
    class Figura
    {
        protected List<Point> PointList;

        public void Draw()
        {
            foreach (Point p in PointList)
                p.Draw();
        }
    }
}
