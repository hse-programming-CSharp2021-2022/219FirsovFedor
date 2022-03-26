using System;
using System.Linq;
using System.Collections.Generic;
namespace CW_25_02
{
    class Programm
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int n = 10;
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
                arr[i] = random.Next(-10000, 10000);
            var z1 = from num in arr
                     select Math.Abs(num) % 10;
            foreach (var num in z1)
                Console.WriteLine(num);

            var ans2 = arr.GroupBy(x => Math.Abs(x) % 10);

            foreach (var num in ans2)
            {
                Console.Write(num.Key + ": ");
                foreach (var elem in num)
                    Console.Write(elem + " ");
                Console.WriteLine();
            }


            var ans3 = from g in arr
                       where g % 2 == 0
                       where g > 0
                       select g;

            foreach (var num in ans3)
                Console.WriteLine(num);
            Console.WriteLine();

            var ans4 = ans3.Sum();
            Console.WriteLine(ans4);
            Console.WriteLine();

            var ans5 = arr.OrderBy(x => Math.Abs(x) / Math.Pow(10, (int)Math.Log10(Math.Abs(x)))).ThenBy(x => Math.Abs(x) % 10);

            foreach (var num in ans5)
                Console.WriteLine(num);
        }
    }

}

