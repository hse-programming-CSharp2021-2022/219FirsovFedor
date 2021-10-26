using System;

namespace Task01
{
    class Program
    {
        public static double GetAns(int n)
        {
            double x;
            if (n > 1)
                x = GetAns(n - 1);
            else
                x = 0;
            Console.WriteLine(x + ((double)n + 0.33) / (3 * n * n + 5));
            return x + ((double)n + 0.33) / (3 * n * n + 5);
        }


        static void Main(string[] args)
        {
            int n;
            if (int.TryParse(Console.ReadLine(), out n))
            {
                GetAns(n);
            }
        }
    }
}
