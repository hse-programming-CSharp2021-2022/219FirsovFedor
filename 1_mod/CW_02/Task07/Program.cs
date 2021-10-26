using System;

namespace Task07
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            if (int.TryParse(Console.ReadLine(), out a) && a > 99 && a < 1000)
            {
                Console.WriteLine(a / 100);
                Console.WriteLine((a / 10) % 10);
                Console.WriteLine(a % 10);
            }
            else
            {
                Console.WriteLine("Incorrect input.");
            }
        }
    }
}
