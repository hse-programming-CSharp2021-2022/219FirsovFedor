using System;

namespace Task08
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            if (int.TryParse(Console.ReadLine(), out x) && int.TryParse(Console.ReadLine(), out y))
            {
                Console.WriteLine(x - y);
                Console.WriteLine(x * y);
                Console.WriteLine(x / y);
                Console.WriteLine(x % y);
                Console.WriteLine(x << y);
                Console.WriteLine(x >> y);
            }
            else
            {
                Console.WriteLine("Incorrect input");
            }
        }
    }
}
