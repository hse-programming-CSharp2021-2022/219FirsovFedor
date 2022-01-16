using System;
using System.Text;


namespace task01
{
    class Program
    {
        delegate int Cast(double x);
        public static int fir(double x)
        {
            return (int)x - (int)x % 2;
        }

        public static int sec(double x)
        {
            return (int)(Math.Log10(x)) + 1;
        }
        static void Main(string[] args)
        {
            Cast cast1 = delegate (double x)
            {
                return (int)(x / 2) * 2;
            };
            Cast cast2 = (x) => (int)(Math.Log10(x)) + 1;


            Console.WriteLine(cast1(17.9));

            Console.WriteLine(cast2(17.9));


            Cast cast3 = cast1 + cast2;
           
            Console.WriteLine(cast3.Invoke(179.57));

            cast3 -= (x) => (int)(Math.Log10(x)) + 1;
            Console.WriteLine(cast3?.Invoke(179.91));

            Cast cast4 = fir;
            Cast cast5 = sec;
            Console.WriteLine(cast4.Invoke(17.9));
            Console.WriteLine(cast5.Invoke(179.91));

            Cast cast6 = cast4 + cast5;
            Console.WriteLine(cast6?.Invoke(179.91));

            cast6 -= fir;
            cast6 -= sec;
            Console.WriteLine(cast6?.Invoke(179.91));
        }
    }
}