using System;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            if (double.TryParse(Console.ReadLine(), out x) && double.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine(x * x + y * y < 100 ? "inside" : "outside");
            }
            else
            {
                Console.WriteLine("Incorrect input.");
            }
        }
    }
}
