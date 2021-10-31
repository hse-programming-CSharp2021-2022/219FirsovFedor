using System;

namespace Task1
{
    class Program
    {

        public class Point
        {
            public double X { get; set; }
            public double Y { get; set; }

            public Point(double x = 0, double y = 0)
            {
                X = x;
                Y = y;
            }

            public double Ro
            {
                get
                {
                    return Math.Sqrt(X * X + Y * Y);
                }
            }

            public double Fi
            {
                get
                {
                    return Math.Atan2(Y, X);
                }
            }

            public string PointData
            {
                get
                {
                    string maket = "X = {0:F2}; Y = {1:F2}; Ro = {2:F2}; Fi = {3:F2} ";
                    return string.Format(maket, X, Y, Ro, Fi);
                }
            }
        }

        public static Point Min(Point a, Point b, Point c)
        {
            if (a.Ro < Math.Min(b.Ro, c.Ro))
            {
                return a;
            }
            if (b.Ro < Math.Min(a.Ro, c.Ro))
            {
                return b;
            }
            return c;
        }

        public static Point Max(Point a, Point b, Point c)
        {
            if (a.Ro > Math.Max(b.Ro, c.Ro))
            {
                return a;
            }
            if (b.Ro > Math.Max(a.Ro, c.Ro))
            {
                return b;
            }
            return c;
        }
        public static Point Mid(Point a, Point b, Point c)
        {
            if (a != Max(a, b, c) && a != Min(a, b, c))
            {
                return a;
            }
            if (b != Max(a, b, c) && b != Min(a, b, c))
            {
                return b;
            }
            return c;
        }

        static void Main()
        {
            Point a, b, c;
            a = new Point(3, 4);
            Console.WriteLine(a.PointData);
            b = new Point(0, 3);
            Console.WriteLine(b.PointData);
            c = new Point();
            double x = 0, y = 0;
            do
            {
                Console.Write("x = ");
                double.TryParse(Console.ReadLine(), out x);
                Console.Write("y = ");
                double.TryParse(Console.ReadLine(), out y);
                c = new Point(x, y);

                Console.WriteLine(Min(a, b, c).PointData);
                Console.WriteLine(Mid(a, b, c).PointData);
                Console.WriteLine(Max(a, b, c).PointData);

            } while (x != 0 | y != 0);
        }
    }
}
