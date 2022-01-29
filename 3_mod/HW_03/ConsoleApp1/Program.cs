using System;

namespace ConsoleApp1
{
    delegate void CoordChanged(Dot A);

    class Dot
    {
        double x, y;
        public double X { get { return x; } set { x = value; } }
        public double Y { get { return y; } set { y = value; } }

        public event CoordChanged OnCoordChanged;
        public Dot()
        {
            this.x = 0;
            this.y = 0;
        }

        public Dot(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        
        public void DotFlow()
        {
            var rnd = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = -10 + rnd.NextDouble() * 20;
                y = -10 + rnd.NextDouble() * 20;
            }
            if (x < 0 && y < 0)
            {
                OnCoordChanged.Invoke(this);
            }
        }
    };

    class Program
    {
        public static void PrintInfo(Dot A) => Console.WriteLine($"Point : x = {A.X}, y = {A.Y}.");
        static void Main(string[] args)
        {
            double userX = double.Parse(Console.ReadLine());
            double userY = double.Parse(Console.ReadLine());
            Dot userD = new Dot(userX, userY);
            userD.OnCoordChanged += PrintInfo;
            userD.DotFlow();
        }
    }
}
