using System;
using System.Collections.Generic;
namespace Task02
{
    class TestClass
    {
        public class Shape
        {
            public const double PI = Math.PI;
            protected double _x, _y;

            public Shape()
            {
            }

            public Shape(double x, double y)
            {
                _x = x;
                _y = y;
            }

            public virtual double Area()
            {
                return _x * _y;
            }
        }

        public class Circle : Shape
        {
            public Circle(double r) : base(r, 0)
            {
            }

            public override double Area()
            {
                return PI * _x * _x;
            }
        }

        public class Sphere : Shape
        {
            public Sphere(double r) : base(r, 0)
            {
            }

            public override double Area()
            {
                return 4 * PI * _x * _x;
            }
        }

        public class Cylinder : Shape
        {
            public Cylinder(double r, double h) : base(r, h)
            {
            }

            public override double Area()
            {
                return 2 * PI * _x * _x + 2 * PI * _x * _y;
            }
        }
        public static int comparer(Shape fir, Shape sec)
        {
            if (fir is Cylinder || (fir is Sphere && sec is Circle))
                return 1;
            else if (fir is Circle || (fir is Sphere && sec is Cylinder))
                return -1;
            else
                return 0;
        }


        static void Main()
        {
            Random rnd = new Random();
            int n1 = rnd.Next(3, 6);
            int n2 = rnd.Next(3, 6);
            int n3 = rnd.Next(3, 6);
            Shape[] line = new Shape[n1 + n2 + n3];
            for (int i = 0; i < n1; ++i)
            {
                int r = rnd.Next(1, 100);
                line[i] = new Circle(r);
                Console.WriteLine($"Figure {i + 1} = Circle, R = {r}");
            }
            for (int i = 0; i < n2; ++i)
            {
                int r = rnd.Next(1, 100);
                int h = rnd.Next(1, 100);
                Console.WriteLine($"Figure {n1 + i + 1} = Cylinder, R = {r}, H = {h}");
                line[n1 + i] = new Cylinder(r, h);
            }
            for (int i = 0; i < n3; ++i)
            {
                int r = rnd.Next(1, 100);
                Console.WriteLine($"Figure {n1 + n2 + i + 1} = Sphere, R = {r}");
                line[n1 + n2 + i] = new Sphere(r);
            }

            Console.WriteLine();

            for (int i = 0; i < line.Length; ++i)
            {
                Console.WriteLine($"Area {i + 1} = {line[i].Area()}");
            }
            Console.WriteLine();

            for (int i = 0; i < line.Length; ++i)
            {
                Console.WriteLine((line[i] is Cylinder ? "Cylinder" : (line[i] is Sphere ? "Sphere" : "Circle")) + " " + line[i].Area());
            }

            Console.WriteLine();
            Array.Sort(line, comparer);

            for (int i = 0; i < line.Length; ++i)
            {
                Console.WriteLine((line[i] is Cylinder ? "Cylinder" : (line[i] is Sphere ? "Sphere" : "Circle")) + " " + line[i].Area());
            }
        }
    }
}