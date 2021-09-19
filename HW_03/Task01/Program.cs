using System;

namespace Task01
{
    class Program
    {

        public static Tuple<int, int> find_ans()
        {
            int summ = 0;
            int i = 0;
            while (summ < 100)
            {
                summ += i;
                i++;
            }
            while (summ % 10 != (summ / 10) % 10 || summ % 10 != summ / 100)
            {
                summ += i;
                i++;
            }
            return Tuple.Create(i, summ);

        }

        public static void print_ans(Tuple<int, int> ans)
        {
            Console.WriteLine(ans.Item2);
            Console.WriteLine(ans.Item1 - 1);
            Console.WriteLine("1+2+3+...+" + Convert.ToString(ans.Item1 - 3) + '+' + Convert.ToString(ans.Item1 - 2) + '+' + Convert.ToString(ans.Item1 - 1));
        }

        static void Main(string[] args)
        {
            print_ans(find_ans());
        }
    }
}
