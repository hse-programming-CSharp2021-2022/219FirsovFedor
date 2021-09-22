using System;

namespace Task03
{
    class Program
    {
        static int min(int fir, int sec, int thi)
        {
            int fir_ = fir % 100;
            int sec_ = sec % 100;
            int thi_ = thi % 100;
            int ans = Math.Min(fir_, Math.Min(sec_, thi_));
            if (fir_ == ans)
                return fir;
            if (sec_ == ans)
                return sec;
            return thi;
        }

        static void Main(string[] args)
        {
            int fir, sec, thi;
            if (int.TryParse(Console.ReadLine(), out fir) && int.TryParse(Console.ReadLine(), out sec) && int.TryParse(Console.ReadLine(), out thi)
                     && fir < 1000 && fir > 99 && sec < 1000 && sec > 99 && thi < 1000 && thi > 99)
            {
                Console.WriteLine(min(fir, sec, thi));
                return;
            }
            Console.WriteLine("Incorrect input!");
        } 
    }
}

