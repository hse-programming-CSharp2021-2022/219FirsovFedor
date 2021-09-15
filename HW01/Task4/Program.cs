using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            double U, R;
            if (double.TryParse(Console.ReadLine(), out U) && double.TryParse(Console.ReadLine(), out R) && R != 0)
            {
                double I = U / R;
                double P = U * U / R;
                Console.WriteLine(I + ' ' + P);
            }
            Console.WriteLine("Incorrect Input");
        }
    }
}
