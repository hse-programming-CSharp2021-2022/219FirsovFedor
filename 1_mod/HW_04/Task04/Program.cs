using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            uint n, m;
            if (uint.TryParse(Console.ReadLine(), out n) && uint.TryParse(Console.ReadLine(), out m))
            {
                uint ans;
                ans = (uint)(1 << (int)n) + (uint)(1 << (int)m);
                Console.WriteLine(ans);
            }
        }
    }
}
