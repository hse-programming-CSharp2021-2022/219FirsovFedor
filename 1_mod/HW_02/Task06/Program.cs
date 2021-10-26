using System;

namespace Task04
{
    class Program
    {
        public static void get_ans(decimal a, int b)
        {
            Console.WriteLine(a / 100 * b);
        }

        static void Main(string[] args)
        {
            while (true)
            {
                decimal a;
                int b;
                while (!decimal.TryParse(Console.ReadLine(), out a) || !int.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("Incorrect input");
                }
                get_ans(a, b);
            }
        }
    }
}
