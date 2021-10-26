using System;

namespace Task03
{
    class Program
    {
        public static double[] sin_one(int N)
        {
            double[] ans = new double[N];
            double[] f = new double[N];
            ans[0] = 1;
            f[0] = 1;
            for (int i = 1; i < N; ++i)
            {
                f[i] = f[i - 1] * (2 * i + 1) * (2 * i);
                if (i % 2 == 1)
                    ans[i] = ans[i - 1] - 1 / f[i];
                else
                    ans[i] = ans[i - 1] + 1 / f[i];
            }
            return ans;
        }


        public static double[] sin_x(ref double[] a, double x)
        {
            int N = a.Length;
            double[] ans = new double[N];
            double[] pow = new double[N];
            pow[0] = x;
            a[0] = ans[0] * pow[0];
            for (int i = 1; i < N; ++i)
            {
                pow[i] = pow[i - 1] * x * x;
                ans[i] = a[i] * pow[i];
            }
            return ans;
        }
        static void Main(string[] args)
        {
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Incorrect input.");
            }
            var fir = sin_one(n);
            while (true)
            {
                double x;
                while (!double.TryParse(Console.ReadLine(), out x))
                {
                    Console.WriteLine("Incorrect input.");
                }
                var ans = sin_x(ref fir, x);
                for (int i = 0; i < n; ++i)
                {
                    Console.WriteLine(ans[i]);
                }
                Console.WriteLine(Math.Sin(x));
            }
        }
    }
}
