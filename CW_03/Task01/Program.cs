using System;

namespace Task01
{
    class Program
    {
        public static int f(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            if (n == 0)
            {
                return f(m - 1, 1);
            }
            return f(m - 1, f(m, n - 1));
        }
        static void Main(string[] args)
        {
            int a, b;
            int.TryParse(Console.ReadLine(), out a);
            int.TryParse(Console.ReadLine(), out b);
            f(a, b);
        }
    }
}
