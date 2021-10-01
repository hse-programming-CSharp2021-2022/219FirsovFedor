using System;
using System.Collections;
namespace Task01
{
    class Program
    {
        public static int comp_1(int a, int b)
        {
            if (a % 2 == 0 && b % 2 == 1) return 1;
            if (a % 2 == 1 && b % 2 == 0) return -1;
            return 0;
        }

        public static int comp_2(int a, int b)
        {
            if (Math.Log10(a) > Math.Log10(b)) return 1;
            if (Math.Log10(a) < Math.Log10(b)) return -1;
            return 0;
        }

        public static int comp_3(int a, int b)
        {
            int sum_fir = 0;
            for (; a > 0; a /= 10)
                sum_fir += a % 10;
            int sum_sec = 0;
            for (; b > 0; b /= 10)
                sum_sec += b % 10;
            if (sum_fir > sum_sec) return 1;
            if (sum_fir < sum_sec) return -1;
            return 0;
        }

        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            int[] line = new int[n];
            var rand = new Random();
            for (int i = 0; i < n; ++i)
            {
                line[i] = rand.Next(1, 1000);
            }
            Array.Sort(line, comp_1);
            Array.ForEach(line, new Action<int>(Console.WriteLine));
            Console.WriteLine();
            Array.Sort(line, comp_2);
            Array.ForEach(line, new Action<int>(Console.WriteLine));
            Console.WriteLine(); 
            Array.Sort(line, comp_3);
            Array.ForEach(line, new Action<int>(Console.WriteLine));
            Console.WriteLine();
        }
    }
}
