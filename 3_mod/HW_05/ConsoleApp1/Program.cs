using System;

namespace ConsoleApp1
{
    delegate double calculate(double x);
    interface IFunction {
        double Function(double x);
    }
    class F : IFunction {
        public calculate Data { get; set; }

        public double Function(double x) {
            return Data(x);
        }
        public F(calculate Calc) {
            Data = Calc;
        }

    }

    class G {
        public F First { get; set; }
        public F Second { get; set; }
        public G(F A, F B)
        {
            First = B;
            Second = A;
        }
        public double GF(double x)
        {
            return Second.Function(First.Function(x));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            calculate calc1 = (double x) => (x * x - 4);
            calculate calc2 = (double x) => (Math.Sin(x));
            G g = new G(new F(calc2), new F(calc1));
            for (double i = 0; i < Math.PI + 1e-9; i += Math.PI / 16)
            {
                Console.WriteLine($"{g.GF(i):F4}");
            }
        }
    }
}
