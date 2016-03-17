using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MySnake
{
    class Program
    {
        static void Main(string[] args)
        {
            int mapWidth = 40;
            int mapHight = 25;
            Console.SetBufferSize(80, 25);

            Walls walls = new Walls(mapWidth, mapHight);
            walls.Draw();

/*            // Полиморфизм

            VerticalLine vl = new VerticalLine(10, 0, 5, '%');
            //Draw(vl);

            Point p1 = new Point(10, 5, '*');
            Figure fSnake = new Snake(p1, 6, Direction.RIGHT);
            //Draw(fSnake);
            Snake fs = (Snake)fSnake; // приведение типа (явное)
            fs.Move();

            HorizontalLine hl = new HorizontalLine(10, 16, 6, '&');

            List<Figure> figures = new List<Figure>();
            figures.Add(fs);
            figures.Add(hl);
            figures.Add(vl);

            foreach(var f in figures)
            {
                f.Drow();
            }
*/
/*
            upLine.Drow();
            leftLine.Drow();
            downLine.Drow();
            rightLine.Drow();
*/
            // Отрисовка точек
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Drow();

            FoodCreator foodCreator = new FoodCreator(mapWidth, mapHight, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while(true)
            {
                if(snake.IsHitTail())
                {
                    break;
                }
                if (walls.IsHit(snake))
                {
                    break;
                }


                    if (snake.Eat(food))
                    {
                        food = foodCreator.CreateFood();
                        food.Draw();
                    }
                    else
                    {
                        snake.Move();
                    }
                
                Thread.Sleep(200);


                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    while (Console.KeyAvailable) key = Console.ReadKey(true);
                    snake.HandleKey(key.Key);
                }
            }
        }

        static void Draw(Figure figure)
        {
            figure.Drow();
        }

    }
}
