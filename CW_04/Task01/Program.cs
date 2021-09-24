using System;

namespace Task01
{
    class Program
    {
        public static bool Transform(ref uint num)
        {
            if (num > 999 || num < 100)
                return false;
            uint fir = num / 100;
            uint sec = num / 10 % 10;
            uint thi = num % 10;

            uint max = Math.Max(fir, Math.Max(sec, thi));
            uint min = Math.Min(fir, Math.Min(sec, thi));
            uint mid = fir + sec + thi - max - min;
            num = min * 100 + mid * 10 + max;
            return true;
        }


        static void Main(string[] args)
        {
            uint n;
            if (uint.TryParse(Console.ReadLine(), out n) && Transform(ref n))
            {
                Console.WriteLine(n);
            }
        }
    }
}
