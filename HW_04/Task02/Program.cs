using System;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int summ = 0, cou = 0;
            while (int.TryParse(Console.ReadLine(), out n) && summ >= -1000)
            {
                if (n < 0)
                {
                    summ += n;
                    cou += 1;
                }
            }
            if (summ < -1000)
                Console.WriteLine((double)summ / (double)cou);
            else
                Console.WriteLine("Incorrct input.");
        }
    }
}
