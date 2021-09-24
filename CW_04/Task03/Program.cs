using System;

namespace Task01
{
    class Program
    {
        public static bool GetAns(double a, double b, double c, out double p, out double s)
        {
            double max = Math.Max(a, Math.Max(b, c));
            double min = Math.Min(a, Math.Min(b, c));
            double mid = a + b + c - max - min;
            if (max >= min + mid)
            {
                s = -1;
                p = -1;
                return false;
            }
            p = (a + b + c) / 2;
            s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            p *= 2;
            return true;
        }


        static void Main(string[] args)
        {
            double a, b, c, p, s;
            if (double.TryParse(Console.ReadLine(), out a) && double.TryParse(Console.ReadLine(), out b) && double.TryParse(Console.ReadLine(), out c) && GetAns(a, b, c, out p, out s))
            {
                Console.WriteLine(p);
                Console.WriteLine(s);
            }
        }
    }
}
