using System;

namespace task01
{
    class Plant
    {
        private int growth, photosensitivity, frostresistance;
        public int Growth { get { return growth;  }
                            set { growth = value; } }
        public Plant(int a, int b, int c)
        {
            growth = a;
            photosensitivity = b;
            frostresistance = c;
        }
        public override string ToString()
        {
            return $"growth - {growth}, photosensitivity - {photosensitivity}, frost resistance - {frostresistance}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = 25;
            int.TryParse(Console.ReadLine(), out n);

            Plant[] line = new Plant[n];
            for (int i = 0; i < n; ++i)
            {
                line[i] = new Plant(rnd.Next(25, 100), rnd.Next(100), rnd.Next(80));
            }
            Array.ForEach(line, (x) => Console.WriteLine(x));

            Comparison<Plant> d = (x, y) => (x.Growth == y.Growth? 0 : (x.Growth < y.Growth? -1 : 1));
            Array.Sort(line, d);
            Array.ForEach(line, (x) => Console.WriteLine(x));
        }
    }
}
