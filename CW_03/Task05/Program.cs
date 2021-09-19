using System;

namespace Task05
{
    class Program
    {

        public static void ans_float()
        {
            float ans = 0;
            float last = -1;
            float i = 1;
            while (ans != last)
            {
                last = ans;
                ans += 1 / (i * (i + 1) * (i + 2));
                i += 1;
            }
            Console.WriteLine(ans);
        }

        public static void ans_double()
        {
            double ans = 0;
            double last = -1;
            double i = 1;
            while (ans != last)
            {
                last = ans;
                ans += 1 / (i * (i + 1) * (i + 2));
                i += 1;
            }
            Console.WriteLine(ans);
        }

        static void Main(string[] args)
        {
            ans_float();
            ans_double();
        }
    }
}
