using System;
class MainClass
{
    public delegate int Cast(double x);
   
    public static int f(double x)
    {
        return ((int)Math.Log10(x) + 1);
    }

    static void Main(string[] args)
    {
        Cast fir = (x) => ((int)x) * 10 % 10 >= 5 ? (int)x + 1 : (int)x;
        Console.WriteLine(fir(10.3));
        Cast sec = (x) => ((int)Math.Log10(x) + 1);
        Console.WriteLine(sec(10.3));
        Cast thi = fir + sec;

        Console.WriteLine(thi?.Invoke(10.3));

        thi -= sec;
        Console.WriteLine(thi?.Invoke(10.3));
    }
}