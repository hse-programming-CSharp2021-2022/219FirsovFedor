using System;

namespace Task03
{
    class Program
    {
        public static double F(double a, double b, double c, double x)
        {
            if (x < 1.2)
            {
                return a * x * x + b * x + c;
            }
            else if (x > 1.2)
            {
                return (a + b * x) / Math.Sqrt(x * x + 1);
            }
            else
            {
                return a / x + Math.Sqrt(x * x + 1);
            }
        }


        static void Main(string[] args)
        {
            double a, b, c;
            double l = 1;
            double r = 2;
            double delta = 0.05;
            if (double.TryParse(Console.ReadLine(), out a) && double.TryParse(Console.ReadLine(), out b) && double.TryParse(Console.ReadLine(), out c))
            {
                for (double x = l; x < r; x += delta)
                {
                    Console.WriteLine(F(a, b, c, x));
                }
            }
            else
                Console.WriteLine("Incorrct input.");

        }
    }
}
