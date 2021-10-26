using System;

namespace Task02
{
    class Program
    {

        public static string get_ans(double a, double b, double c)
        {
            double d = b * b - 4 * a * c;
            return d > 0 ? Convert.ToString((-b + Math.Sqrt(d)) / 2 / a) + ' ' + Convert.ToString((-b - Math.Sqrt(d)) / 2 / a) : (d == 0 ? Convert.ToString((-b) / 2 / a) : "No solutions");
        }

        static void Main(string[] args)
        {
            while (true)
            {
                double a, b, c;
                while (!double.TryParse(Console.ReadLine(), out a) || !double.TryParse(Console.ReadLine(), out b) || !double.TryParse(Console.ReadLine(), out c))
                {
                    Console.WriteLine("Incorrect input");
                }
                Console.WriteLine(get_ans(a, b, c));
            }
        }
    }
}
