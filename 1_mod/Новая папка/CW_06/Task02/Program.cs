using System;

namespace Task02
{
    class Program
    {
        static void Print(char[] arr)
        {
            foreach (char val in arr)
            {
                Console.Write(val);
                Console.Write(' ');
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            int n;
            Random rnd = new Random();
            if (int.TryParse(Console.ReadLine(), out n))
            {
                char[] arr = new char[n];
                for (int i = 0; i < n; ++i)
                {
                    arr[i] = (char)(rnd.Next('A', 'Z' + 1));
                }
                Print(arr);
                char[] arr2 = new char[n];
                Array.Copy(arr, arr2, n);
                Print(arr2);
                Array.Sort(arr2);
                Print(arr2);
                Array.Reverse(arr2);
                Print(arr2);
            }
        }
    }
}
