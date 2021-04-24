using System;

namespace midtermTest
{
    class Program
    {
        static void Main(string[] args)
        {
            float x, y, dx, dy, step;
            float x1 = float.Parse(Console.ReadLine());
            float y1 = float.Parse(Console.ReadLine());
            float x2 = float.Parse(Console.ReadLine());
            float y2 = float.Parse(Console.ReadLine());
            dx = x2 - x1;
            dy = y2 - y1;
            int i = 1;
            if (Math.Abs(dx) >= Math.Abs(dy))
            {
                step = Math.Abs(dx);
                dx /= step;
                dy /= step;
                x = x1;
                y = y1;
            }
            else
                step = Math.Abs(dy);
                dx /= step;
                dy /= step;
                x = x1;
                y = y1;
            while (i <= step)
            {
                Console.Write(x);
                Console.Write(",");
                Console.Write(y);
                x += dx;
                y += dy;
                i++;
            }
            Console.ReadLine();
        }
    }
}
//(int i = 0; i <= height; i++)
    //(int j = 0; j <= width; j++)