using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snakenew
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x1 = 1;
            //int y1 = 2;
            //char sym1 = '*';

            //Draw(x1, y1, sym1);

            Point p1 = new Point();
            p1.x = 1;
            p1.y = 3;
            p1.sym = '*';
            //Draw(p1.x, p1.y, p1.sym);
            p1.Draw();

            Point p2 = new Point();
            p2.x = 2;
            p2.y = 3;
            p2.sym = '#';
            p2.Draw();

            Console.ReadKey();
        }

    }
}
