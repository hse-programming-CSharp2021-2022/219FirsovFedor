using System;

namespace Task04
{
    class Program
    {
        public static void get_ans(int a, int b, int c)
        {
            int max = Math.Max(a, Math.Max(b, c));
            int min = Math.Min(a, Math.Min(b, c));
            int mid = a + b + c - max - min;

            Console.WriteLine(max < min + mid);
        }

        static void Main(string[] args)
        {
            while (true)
            {
                int a, b, c;
                while (!int.TryParse(Console.ReadLine(), out a) || !int.TryParse(Console.ReadLine(), out b) || !int.TryParse(Console.ReadLine(), out c))
                {
                    Console.WriteLine("Incorrect input");
                }
                get_ans(a, b, c);
            }
        }
    }
}
