using System;

namespace ASCIIDecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int Code;
            int.TryParse(Console.ReadLine(), out Code);
            char Ans = (char)Code;
            Console.WriteLine(Ans);
        }
    }
}
