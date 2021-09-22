using System;

namespace Task01
{
    class Program
    {
        public static double f(int n)
        {
            double b = (1 + Math.Sqrt(5)) / 2;
            double ans = (Math.Pow(b, n) - Math.Pow(-b, -n)) / (2 * b - 1);
            return ans;
        }
        static void Main(string[] args)
        {
            int n;
            while (int.TryParse(Console.ReadLine(), out n))
                Console.WriteLine(f(n));
        }
    }
}
