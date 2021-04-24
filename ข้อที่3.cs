using System;

namespace midtermTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string mode = Console.ReadLine();
            float filmBackWidth = float.Parse(Console.ReadLine());
            if (filmBackWidth > 0)
            {
                float fLength, fov;
                if(mode == "fLength")
                {
                    fLength = float.Parse(Console.ReadLine());
                    if(fLength > 0)
                    {
                        fov = (float)(2 * Math.Atan(filmBackWidth / (2 * fLength)));
                        Console.WriteLine("fLegnth = ", fLength);
                    }
                }
                else if(mode == "fov")
                {
                    fov = float.Parse(Console.ReadLine());
                    if(fov > 0.1 && fov < 6.28)
                    {
                        fLength = (fLength = (float)(filmBackWidth / (2 * Math.Tan(fov / 2))));
                        Console.WriteLine("fov = ", fov);
                    }
                }

            }
            else
                Console.WriteLine("Invalid filmBackWidth. Please input again");
        }
    }
}
//(int i = 0; i <= height; i++)
    //(int j = 0; j <= width; j++)