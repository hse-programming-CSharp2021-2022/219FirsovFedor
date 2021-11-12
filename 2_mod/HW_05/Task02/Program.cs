using System;
using System.Collections.Generic;

namespace Task02
{
    class TestClass
    {
        public class Something
        {
            public double data;
            public Something()
            {
            }
        }

        public class Lentil : Something
        {
            Random rnd = new Random();
            public double Weight
            {
                get { return data; }
                set { data = rnd.NextDouble() + rnd.NextDouble();  }
            }
        }

        public class Ashes : Something
        {
            Random rnd = new Random();
            public double Volume
            {
                get { return data; }
                set { data = rnd.NextDouble(); }
            }
        }

        static void Main()
        {
            Random rnd = new Random();
            int n;
            int.TryParse(Console.ReadLine(), out n);
            Something[] line = new Something[n];
            for (int i = 0; i < n; ++i)
            {
                bool random = rnd.Next() % 2 == 1;
                if (random)
                {
                    line[i] = new Lentil();
                }
                else
                {
                    line[i] = new Ashes();
                }
            }
            for (int i = 0; i < n; ++i)
            {
                if (line[i] is Lentil)
                {
                    Console.WriteLine(line[i].Weight);
                }
                else
                {
                    Console.WriteLine(line[i].Volume);
                }
            }
        }
    }
}