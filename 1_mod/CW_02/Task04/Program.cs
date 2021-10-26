using System;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            string s;
            s = Console.ReadLine();
            char c = s[0];
            Console.WriteLine((c <= '9' && c >= '0') ? "цифра" : (((c <= 'я' && c >= 'а') || (c <= 'Я' && c >= 'А')) ? "буква" : "что-то другое"));
        }
    }
}
