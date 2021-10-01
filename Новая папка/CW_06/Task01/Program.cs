using System;

namespace Task02
{
    class Program
    {
        static void Print(int[] arr)
        {
            foreach (int val in arr)
            {
                Console.Write(val);
                Console.Write(' ');
            }
            Console.WriteLine();
        }
        static int Summ(int[] arr)
        {
            int ans = 0;
            foreach (int val in arr)
            {
                ans += val;
            }
            return ans;
        }

        static int[] Generate()
        {
            Random rnd = new Random();
            int[] data = new int[100];
            for(int i = 0; i < 100; ++i)
            {
                data[i] = i;
            }
            for (int i = data.Length - 1; i >= 1; i--)
            {
                int j = rnd.Next(i + 1);
                var tmp = data[j];
                data[j] = data[i];
                data[i] = tmp;
            }
            Array.Resize(ref data, 99);
            return data;
        }




        static void Main(string[] args)
        {
            int[] arr = Generate();
                Print(arr);
                Console.WriteLine(5050 - Summ(arr));
        }
    }
}

