using System;

namespace Task03
{
    class Program
    {
        static bool G(float x, float y)
        {
            if (x * x + y * y > 4)
                return false;
            if (x <= 0)
                return true;
            if (y < 0)
            {
                return false;
            }
            if (y >= x)
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            float x, y;
            if (float.TryParse(Console.ReadLine(), out x) && float.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine(G(x, y));
                return;
            }
            Console.WriteLine("Incorrect input!");
        }
    }
}

