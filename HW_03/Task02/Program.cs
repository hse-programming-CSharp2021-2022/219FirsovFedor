using System;

namespace Task01
{
    class Program
    {

        public static int get_ans(int n)
        {
            if (n > 10)
                return Convert.ToInt32(Convert.ToString(n % 10) + Convert.ToString(get_ans(n / 10)));
            return n;
        }

        static void Main(string[] args)
        {
            int n;
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine(get_ans(n));
        }
    }
}
