using System;

namespace Task03
{
    class Program
    {
        static double G(float x, float y)
        {
            if (x < y && x > 0)
                return x + Math.Sin(y);
            if (x > y && x < 0)
                return y - Math.Cos(x);
            return 0.5 * x * y;
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

