using System;

namespace Task02
{
    class Program
    {

        public static double[,] f(double[][] arr)
        {
            int n = arr.Length;
            double[,] ans = new double[n, n];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < arr[i].Length; ++j)
                {
                    if (j < i + 1)
                    {
                        ans[i, j] = arr[i][j];
                    }
                }
            }
            return ans;
        }
        static void Main(string[] args)
        {
            int n;
            var rnd = new Random();
            int.TryParse(Console.ReadLine(), out n);
            double[][] arr = new double[n][];
            int num = 1;
            for (int i = 0; i < n; ++i)
            {
                arr[i] = new double[i + 1];
                for (int j = 0; j < i + 1; ++j)
                {
                    arr[i][j] = rnd.NextDouble();
                    num++;
                }
            }

            double[,] ans = f(arr);
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    Console.Write("{0:F3}", ans[i, j]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }

            for (int i = 0; i < n; ++i)
            {
                double Ans = 0;
                for (int j = 0; j < n; ++j)
                {
                    Ans += ans[j, i];
                }
                Console.WriteLine(Ans);
            }

        }
    }
}
