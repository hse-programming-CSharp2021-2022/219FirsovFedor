using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a < 21; ++a)
                for (int b = a; b < 20; ++b)
                    for (int c = b; c < 20; ++c)
                        if (a * a + b * b == c * c)
                        {
                            Console.WriteLine("{0} ^ 2 + {1} ^ 2 = {2} ^ 2", a, b, c);
                        }
        }
    }
}
