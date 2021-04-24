using System;

namespace midtermTest
{
    class Program
    {
        static void Main(string[] args)
        {
            char n = char.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int steps = int.Parse(Console.ReadLine());
            for (int c = 1; c <= steps; c++)
            {
                for (int i = 1; i <= height; i++)
                {
                    Console.WriteLine();

                    for (int j = 0; j <= width; j++)
                    {
                        Console.Write(n);
                        if(c > 1 && c <= steps)
                        {
                            Console.Write(n);
                            if (c > 2 && c == steps)
                            {
                                Console.Write(n);
                            }
                        }
                    }
                }
            }
        }
    }
}
//(int i = 0; i <= height; i++)
    //(int j = 0; j <= width; j++)