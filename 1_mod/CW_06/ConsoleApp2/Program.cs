using System;
using System.Text;
namespace ConsoleApp2
{
    class Program
    {
        public static StringBuilder Reverse(StringBuilder s)
        {
            StringBuilder ans = new StringBuilder(50);
            for(int i = s.Length - 1; i > -1; --i)
            {
                ans.Append(s[i]);
            }
            return ans;
        }

        static public StringBuilder ConvertHex2Bin(string HexNumber)
        {
            StringBuilder ans = new StringBuilder(HexNumber.Length * 4);
            for (int i = 0; i < HexNumber.Length; ++i)
            {
                int n;
                if (HexNumber[i] > '0' && HexNumber[i] < '9')
                {
                    n = HexNumber[i] - '0';
                }
                else
                {
                    n = HexNumber[i] - 'A' + 10;
                }
                StringBuilder buf = new StringBuilder(50);
                for (int q = 0; q < 4; ++q)
                {
                    buf.Append((char)(n % 2 + '0'));
                    n /= 2;
                }
                ans.Append(Reverse(buf));
            }
            return ans;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(ConvertHex2Bin(Console.ReadLine()));
        }
    }
}
