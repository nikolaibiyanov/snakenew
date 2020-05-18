using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snakenew
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);
     /*       Point p1 = new Point(1,3,'*');
            p1.Draw();

            Point p2 = new Point(2,3,'#');
            p2.Draw();

   /*         List<int> numlisst = new List<int>();
            numlisst.Add('f');
            numlisst.Add('a');
            numlisst.Add('h');
           
            List<Point> PointList = new List<Point>();
            PointList.Add(p1);
            PointList.Add(p2);
    */       
            HorizontalLine upline = new HorizontalLine(0,78,0,'+');
            HorizontalLine downline = new HorizontalLine(0,78,24,'+');
            
            VerticalLine vLeftline = new VerticalLine(0, 24, 0, '+');
            VerticalLine vRightline = new VerticalLine(0, 24, 78, '+');

            upline.Draw();
            downline.Draw();
            vLeftline.Draw();
            vRightline.Draw();

            Point p = new Point(4, 5, '%');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            snake.Move();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }
        }

    }
}
