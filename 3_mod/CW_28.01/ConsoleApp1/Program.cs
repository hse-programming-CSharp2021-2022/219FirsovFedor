using System;

namespace ConsoleApp1
{
    class Point
    {
        private int x, y;
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }

        public static int dist(Point first, Point second)
        {
            return (first.x - second.x) * (first.x - second.x) + (first.y - second.y) * (first.y - second.y);
        }
        public Point(int x_, int y_)
        {
            x = x_;
            y = y_;
        }
    };

    class TriangleComp
    {
        Point[] points;
        double[] lengths;
        public double S { get {
                double p = (lengths[0] + lengths[1] + lengths[2]) / 2;
                return Math.Sqrt(p * (p - lengths[0]) * (p - lengths[1]) * (p - lengths[2]));
        } }

        public TriangleComp(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            points = new Point[] { new Point(x1, y1), new Point(x2, y2), new Point(x3, y3) };
            lengths = new double[] { Point.dist(points[0], points[1]), Point.dist(points[0], points[2]), Point.dist(points[1], points[2]) };
        }
        public TriangleComp(Point P1, Point P2, Point P3)
        {
            points = new Point[] { P1, P2, P3 };
            lengths = new double[] { Point.dist(points[0], points[1]), Point.dist(points[0], points[2]), Point.dist(points[1], points[2]) };
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
