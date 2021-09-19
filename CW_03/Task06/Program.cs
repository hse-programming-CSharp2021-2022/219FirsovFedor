using System;

namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, delta;
            double ans = 0;

            while (!double.TryParse(Console.ReadLine(), out a) || !double.TryParse(Console.ReadLine(), out delta))
            {
                Console.WriteLine("Incorrect input.");
            }

            for (int i = 0; (i + 1) * delta < a; ++i)
            {
                ans += ((i * delta * i * delta) + ((i + 1) * delta * (i + 1) * delta)) / 2 * delta;
            }
            ans += ((a - a % delta) * (a - a % delta) + (a * a)) / 2 * delta;
            Console.WriteLine(ans);
        }
    }
}
