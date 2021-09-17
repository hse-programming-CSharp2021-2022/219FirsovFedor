using System;

namespace Task04
{
    class Program
    {
        public static void First(double a)
        {
            Console.WriteLine(Convert.ToString((int)a) + ' ' + Convert.ToString(a % 1));
        }

        public static void Second(double a)
        {
            Console.WriteLine(a * a);
            Console.WriteLine(a > 0 ? Convert.ToString(Math.Sqrt(a)) : "");
        }

        static void Main(string[] args)
        {
            while (true)
            {
                double a;
                while (!double.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Incorrect input");
                }
                First(a);
                Second(a);
            }
        }
    }
}
