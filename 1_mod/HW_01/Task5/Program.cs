using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            if (double.TryParse(Console.ReadLine(), out double fir_num))
                if (double.TryParse(Console.ReadLine(), out double sec_num))
                {
                    if (fir_num >= (double)0 && sec_num >= (double)0)
                    {
                        Console.WriteLine(Math.Sqrt(fir_num * fir_num + sec_num * sec_num));
                        return;
                    }
                }

            Console.WriteLine("Incorrect input");
            return;
        }
    }
}
