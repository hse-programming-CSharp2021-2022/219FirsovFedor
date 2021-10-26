﻿using System;

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

        public  string PolygonData()
        {
            return $"Колличество сторон - {n}, Радиус - {r}, Периметр - {p}, Площадь - {s}";
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Polygon a = new Polygon(3, 1);
            Console.WriteLine(a.PolygonData());
        }
    }
}

    