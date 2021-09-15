using System;

namespace Task01
{
    class Program
    {
        public static void get_ans(int x)
        {
            int x_12 = x + x + x + x + x + x + x + x + x + x + x + x;
            Console.WriteLine(x * (x * (x * (x_12 + 9) - 3) + 2) - 4);
        }

        static void Main(string[] args)
        {
           while (true)
            {
                int x;
                while (!int.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Incorrect input");
                }
                get_ans(x);
            }
        }
    }
}
