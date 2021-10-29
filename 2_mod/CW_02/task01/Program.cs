using System;

namespace task01
{
    class MyComplex
    {
        public double im{ get; }
        public double re { get; }
        public MyComplex(double xre, double xim)
        {
            re = xre;
            im = xim;
        }
        public static MyComplex operator ++(MyComplex mc)
        {
            MyComplex ans = new MyComplex(mc.re + 1, mc.im + 1);
            return ans;
        }
        public static MyComplex operator --(MyComplex mc)
        {
            return new MyComplex(mc.re - 1, mc.im - 1);
        }
        public double Mod()
        {
            return Math.Abs(re * re + im * im);
        }
        static public bool operator true(MyComplex f)
        {
            if (f.Mod() > 1.0) return true;
            return false;
        }
        static public bool operator false(MyComplex f)
        {
            if (f.Mod() <= 1.0) return true;
            return false;
        }

        static public MyComplex operator +(MyComplex a, MyComplex b)
        {
            MyComplex ans = new MyComplex(a.im + b.im, a.re + b.re);
            return ans;
        }
        static public MyComplex operator -(MyComplex a, MyComplex b)
        {
            MyComplex ans = new MyComplex(a.im - b.im, a.re - b.re);
            return ans;
        }
        static public MyComplex operator *(MyComplex a, MyComplex b)
        {
            MyComplex ans = new MyComplex(a.im * b.im - a.re * b.re, a.im * b.re + b.im * a.re);
            return ans;
        }
        static public MyComplex operator /(MyComplex a, MyComplex b)
        {
            MyComplex ans = new MyComplex((a.im * b.re + b.im * a.re) / (b.re * b.re + b.im * b.im), (a.im * b.re - b.im * a.re) / (b.re * b.re + b.im * b.im));
            return ans;
        }

        public static implicit operator string(MyComplex a)
        {
            return a.im + " " + a.re + "i";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyComplex a = new MyComplex(2, 3);
            MyComplex b = new MyComplex(3, 4);
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
        }
    }

}