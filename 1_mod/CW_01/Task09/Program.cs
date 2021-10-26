using System;

namespace Task08
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            if (double.TryParse(Console.ReadLine(), out x) && double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine(x % 1 + y % 1);

            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
