using System;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int variable = 1;
            switch (variable)
            {
                case 1:
                    Console.WriteLine("case 1");
                case 2:
                    Console.WriteLine("case 2");
                    break;
                default:
                    Console.WriteLine("default");
                    break;
            }

        }
    }
}
