using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw();

            Point p2 = new Point(4, 7, '#' );
            p2.Draw();

            HorizontalLine line = new HorizontalLine(5, 10, 8, '+');
            line.Drow();

            VerticalLine vline = new VerticalLine(10, 9, 15, '*');
            vline.Drow();

            HorizontalLine line1 = new HorizontalLine(11, 20, 15, '+');
            line1.Drow();

            VerticalLine vline1 = new VerticalLine(20, 9, 15, '*');
            vline1.Drow();

            Console.ReadLine();
        }
    }
}
