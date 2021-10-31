using System;

namespace Task01
{

    public class Polygon
    {

        public int n { get; set; }
        public double r { get; set; }

        public double s
        {
            get
            {
                double R = r / Math.Cos(Math.PI / n);
                return n / 2 * R * R * Math.Sin(Math.PI * 2 / n);
            }
        }
        public double p
        {
            get
            {
                double R = r / Math.Cos(Math.PI / n);
                return n * 2 * R * Math.Sin(Math.PI / n);
            }
        }

        public Polygon(int num = 0, double d = 0)
        {
            this.n = num;
            this.r = d;
        }

        public string PolygonData()
        {
            return $"Колличество сторон - {n}, Радиус - {r}, Периметр - {p}, Площадь - {s}";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            Polygon[] line = new Polygon[n];
            for (int i = 0; i < n; ++i)
            {
                int a;
                int.TryParse(Console.ReadLine(), out a);
                int b;
                int.TryParse(Console.ReadLine(), out b);
                line[i] = new Polygon(a, b);
            }
            double min = 1e10;
            double max = -1e10;
            for (int i = 0; i < n; ++i)
            {
                min = Math.Min(min, line[i].p);
                max = Math.Max(max, line[i].p);
            }
            for (int i = 0; i < n; ++i)
            {
                if (line[i].p == min)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                if (line[i].p == max)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                Console.WriteLine(line[i].p);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}

