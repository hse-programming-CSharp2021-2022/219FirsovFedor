using System;

namespace Task03
{
    class Program
    {
        static double G(float x)
        {
            if (x <= 0.5)
                return Math.Sin(Math.PI / 2); // Its 1. Why we use sin(pi / 2)?
            return Math.Sin(Math.PI * (x - 1) / 2);
        }

        static void Main(string[] args)
        {
            float x, y;
            if (float.TryParse(Console.ReadLine(), out x))
            {
                Console.WriteLine(G(x));
                return;
            }
            Console.WriteLine("Incorrect input!"); 
        }
    }
}

