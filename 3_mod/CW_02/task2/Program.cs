using System;
using System.Text;

namespace task2
{
    class Program
    {
        public delegate string ConvertRule(string x);
        class Converter
        {
            public string Convert(string str, ConvertRule sr)
            {
                return sr(str);
            }
        };

        public static string RemoveDigits(string str)
        {
            StringBuilder ans = new StringBuilder();
            for (int i = 0; i < str.Length; ++i)
            {
                ans.Append(str[i] <= '9' && str[i] >= '0' ? "" : str[i]);
            }
            return ans.ToString();
        }

        public static string RemoveSpaces(string str)
        {
            StringBuilder ans = new StringBuilder();
            for (int i = 0; i < str.Length; ++i)
            {
                ans.Append(str[i] == ' ' ? "" : str[i]);
            }
            return ans.ToString();
        }

           public static string f(string x, ConvertRule sr)
            {
                string ans = x;
                foreach (ConvertRule sr_ in sr.GetInvocationList())
                {
                    ans = sr_(ans);
                }
                return ans;
            }
 

        static void Main(string[] args)
        {
            string[] line = { "dkdii1 1 2w3", "Hello World!", "179 sch", "C++11 C++17 C++20" };
            ConvertRule fir = RemoveDigits;
            ConvertRule sec = RemoveSpaces;
            Array.ForEach(line, (string x) => Console.WriteLine(fir(x)));
            Console.WriteLine();
            Array.ForEach(line, (string x) => Console.WriteLine(sec(x)));
            Console.WriteLine();
            ConvertRule thi = fir + sec;
            Array.ForEach(line, (string x) => Console.WriteLine(thi(x)));
            Console.WriteLine();

            Action<string> d = x => Console.WriteLine(f(x, thi));
            Array.ForEach(line, d);
        }
    }
}
