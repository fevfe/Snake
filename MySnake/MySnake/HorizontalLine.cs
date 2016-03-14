using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnake
{
    class HorizontalLine : Figure
    {
        public HorizontalLine(int xleft, int xright, int y, char sym)
        {
            pList = new List<Point>();
            for(int x = xleft; x <= xright; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public override void Drow() // альтернативная реализация метода из базового класса
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            base.Drow();                                   // вызов метода базового класса
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
