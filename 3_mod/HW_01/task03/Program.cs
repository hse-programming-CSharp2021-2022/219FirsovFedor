using System;

namespace task03
{
    class Program
    {

        delegate double DelegateConvertTemperature(double x);


        class TemperatureConverterImp
        {
            public static double F_to_C(double x)
            {
                return x * 9 / 5 + 32; 
            }
            public static double C_to_F(double x)
            {
                
                return (x - 32) * 5 / 9;
            }

            public static double Ra_to_C(double x)
            {
                return (x - 491.67) * 5 / 9;
            }
            public static double C_to_Ra(double x)
            {
                return (x + 273.15) * 9 / 5;
            }


            public static double C_to_K(double x)
            {
                return (x + 273.15);
            }
            public static double K_to_C(double x)
            {
                return (x - 273.15);
            }

            public static double C_to_Re(double x)
            {
                return x * 21 / 40 + 7.5;
            }
            public static double Re_to_C(double x)
            {
                return (x - 7.5) * 40 / 21;
            }

        };
        static void Main(string[] args)
        {
            DelegateConvertTemperature fir =TemperatureConverterImp.C_to_F;
            DelegateConvertTemperature sec = TemperatureConverterImp.F_to_C;
            double x = fir(36.6);
            Console.WriteLine(x);
            Console.WriteLine(sec(x));
            Console.WriteLine();

            DelegateConvertTemperature[] line = { TemperatureConverterImp .C_to_F, TemperatureConverterImp.C_to_K, TemperatureConverterImp.C_to_Ra, TemperatureConverterImp.C_to_Re};

            Array.ForEach(line, (x) => Console.WriteLine(x(36.6)));
        }
    }
}
