using System;

namespace Task02
{
    class Program
    {

        public static int comp(int[] a, int[] b)
        {
            if (a.Length > b.Length) return 1;
            if (a.Length < b.Length) return -1;
            return 0;
        }
        static void Main(string[] args)
        {
            int n;
            var rnd = new Random();
            int.TryParse(Console.ReadLine(), out n);
            int[][] arr = new int[n][];
            int num = 1;
            for (int i = 0; i < n; ++i)
            {
                arr[i] = new int[n];
                for (int j = 0; j < n; ++j)
                {
                    arr[i][j] = num;
                    num++;
                }
                if (i % 2 == 1)
                {
                    Array.Reverse(arr[i]);
                }
            }
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
