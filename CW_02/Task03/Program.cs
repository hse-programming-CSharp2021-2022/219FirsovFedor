using System;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, z;
            if (int.TryParse(Console.ReadLine(), out x) && int.TryParse(Console.ReadLine(), out y) && int.TryParse(Console.ReadLine(), out z))
            {
                int fir, sec, thi;
                fir = x > y ? y : x;
                fir = fir > z ? z : fir;

                thi = x > y ? x : y;
                thi = thi > z ? thi : z;

                sec = x + y + z - fir - thi;
                x = fir;
                y = sec;
                z = thi;
                Console.WriteLine(x);
                Console.WriteLine(y);
                Console.WriteLine(z);
            }
        }
    }
}
