using System;

namespace Task04
{
    class Program
    {
        public static void get_ans(int x)
        {
            if (x == 0)
                return;
            Console.WriteLine(x % 10);
            get_ans(x / 10);
        }

        static void Main(string[] args)
        {
            while (true)
            {
                int x;
                while (!int.TryParse(Console.ReadLine(), out x) || x > 9999 || x < 1000)
                {
                    Console.WriteLine("Incorrect input");
                }
                get_ans(x);
            }
        }
    }
}
