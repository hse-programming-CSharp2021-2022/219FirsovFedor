using System;

namespace Task02
{
    class Program
    {

        public static void f(ref int[][] a, int i, int j, int n, int num, int last)
        {
            a[i][j] = num;

            if (last == 0)
            {
                if (j < n - 1 && a[i][j + 1] == -1)
                {
                    f(ref a, i, j + 1, n, num + 1, 0);
                }
                else if (i < n - 1 && a[i + 1][j] == -1)
                {
                    f(ref a, i + 1, j, n, num + 1, 1);
                }
            }
            else if (last == 1)
            {
                if (i < n - 1 && a[i + 1][j] == -1)
                {
                    f(ref a, i + 1, j, n, num + 1, 1);
                }
                else if (j != 0 && a[i][j - 1] == -1)
                {
                    f(ref a, i, j - 1, n, num + 1, 2);
                }
            }
            else if (last == 2)
            {
                if (j != 0 && a[i][j - 1] == -1)
                {
                    f(ref a, i, j - 1, n, num + 1, 2);
                }
                else if (i != 0 && a[i - 1][j] == -1)
                {
                    f(ref a, i - 1, j, n, num + 1, 3);
                }
            }
            else
            {
                if (i != 0 && a[i - 1][j] == -1)
                {
                    f(ref a, i - 1, j, n, num + 1, 3);
                }
                else if (j < n - 1 && a[i][j + 1] == -1)
                {
                    f(ref a, i, j + 1, n, num + 1, 0);
                }
            }

        }


        static void Main(string[] args)
        {
            int n;
            var rnd = new Random();
            int.TryParse(Console.ReadLine(), out n);
            int[][] arr = new int[n][];
            for (int i = 0; i < n; ++i)
            {
                arr[i] = new int[n];
                for (int j = 0; j < n; ++j)
                {
                    arr[i][j] = -1;
                }
            }
            f(ref arr, 0, 0, n, 0, 0);
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < arr[i].Length; ++j)
                {
                    Console.Write(arr[i][j]);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }

        }
    }
}
