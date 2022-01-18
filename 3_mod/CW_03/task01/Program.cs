using System;
namespace Task01
{
    delegate void SqureSizeChanged(double a);
    class Point
    {
        public int x;
        public int y;
        public Point(int X, int Y)
        {
            x = X;
            y = Y;
        }
        public Point(string s)
        {
            string[] buf = s.Split();
            int.TryParse(buf[0], out x);
            int.TryParse(buf[1], out y);
        }
        public double Dist(Point other)
        {
            return Math.Sqrt((this.x - other.x) * (this.x - other.x) + (this.y - other.y) * (this.y - other.y));
        }
    }
    class Square
    {
        public event SqureSizeChanged OnSizeChanged;
        Point leftAndUp;
        Point rightAndDown;
        public Point LeftAndUp
        {
            get { return leftAndUp; }    set { leftAndUp = value;    OnSizeChanged(leftAndUp.Dist(rightAndDown) * (1 / Math.Sqrt(2))); }
        }
        public Point RightAndDown
        {
            get { return rightAndDown; } set { rightAndDown = value; OnSizeChanged(leftAndUp.Dist(rightAndDown) * (1 / Math.Sqrt(2))); }
        }
        public Square(Point fir, Point sec)
        {
            leftAndUp = fir;
            rightAndDown = sec;
        }
    }
    class Program
    {
        static void SquareConsoleInfo(double A)
        {
            Console.WriteLine($"{A:F3}");
        }

        static void Main(string[] args)
        {
            Point leftUP = new Point(Console.ReadLine());
            Point rightDown = new Point(Console.ReadLine());
            Square S = new Square(leftUP, rightDown);
            S.OnSizeChanged += SquareConsoleInfo;
            for(int i = 0; i < 5; ++i)
            {
                S.RightAndDown = new Point(Console.ReadLine());
            }
        }
    }
}