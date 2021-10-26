using System;

namespace Task01
{
    class Program
    {
        public static bool Shift(ref char c)
        {
            if (c > 'z' || c < 'a')
                return false;
            c = (char)(c + 4);
            if (c > 'z')
            {
                c = (char)(c - 26);
            }
            return true;
        }


        static void Main(string[] args)
        {
            char c;
            if (char.TryParse(Console.ReadLine(), out c) && Shift(ref c))
            {
                Console.WriteLine(c);
            }
        }
    }
}
