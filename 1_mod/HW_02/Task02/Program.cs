using System;

namespace Task02
{
    class Program
    {

        public static void get_ans(int x)
        {
            int fir = x / 100;
            int sec = x / 10 % 10;
            int thi = x % 10;
            int fir_ = Math.Max(Math.Max(fir, sec), thi);
            int thi_ = Math.Min(Math.Min(fir, sec), thi);
            int sec_ = fir + sec + thi - fir_ - thi_;
            Console.WriteLine(fir_ * 100 + sec_ * 10 + thi_);

        }

        static void Main(string[] args)
        {
            while (true)
            {
                int x;
                while (!int.TryParse(Console.ReadLine(), out x) || x > 999 || x < 100)
                {
                    Console.WriteLine("Incorrect input");
                }
                get_ans(x);
            }
        }
    }
}
