using System;

namespace ConsoleApp1
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double Distance(Point other)
        {
            return (this.X - other.X) * (this.X - other.X) +
                   (this.Y - other.Y) * (this.Y - other.Y);
        }
    }

    class Circle
    {
        public Point Mid;
        public double R;
        public Circle(Point mid, double r)
        {
            Mid = mid;
            R = r;
        }
        public Circle(double x, double y, double r)
        {
            Mid = new Point(x, y);
            R = r;
        }
        public override string ToString()
        {
            return $"Mid - x = {Mid.X}, y = {Mid.Y}; R = {R}.";
        }
        public static bool operator >(Circle fir, Circle sec)
        {
            return fir.Mid.Distance(new Point(0, 0)) * fir.R > sec.Mid.Distance(new Point(0, 0)) * sec.R;
        }
        public static bool operator <(Circle fir, Circle sec)
        {
            return fir.Mid.Distance(new Point(0, 0)) * fir.R < sec.Mid.Distance(new Point(0, 0)) * sec.R;
        }
        public int CompareTo(Circle other)
        {
            if (this < other)
                return 1;
            return -1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Circle[] arr = new Circle[n];
            Random rnd = new Random();
            for (int i = 0; i < n; ++i)
            {
                arr[i] = new Circle(rnd.Next(0, 10), rnd.Next(0, 10), rnd.Next(0, 10));
            }
            Array.Sort(arr, (Circle circ1, Circle circ2) => (circ1 > circ2 ? 1 : -1));

            foreach (var circle in arr)
            {
                Console.WriteLine(circle);
            }
        }
    }
}
