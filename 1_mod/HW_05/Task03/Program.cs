using System;

namespace Task03
{
    class Program
    {
        public static double[] sin(int N)
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
        static void Main(string[] args)
        {
            int n;
            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Incorrect input.");
            }
            var ans = sin(n);
            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine(ans[i]);
            }
        }
    }
}
