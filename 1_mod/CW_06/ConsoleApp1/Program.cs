using System;
using System.Text;
namespace ConsoleApp1
{
    class Program
    {

        public static bool G(Char c)
        {
            return c == 'a' || c == 'e' || c == 'o' || c == 'y' || c == 'u' || c == 'i' ||
                   c == 'A' || c == 'E' || c == 'O' || c == 'Y' || c == 'U' || c == 'I';
        }
        static void Main(string[] args)
        {
            string inp = Console.ReadLine();
            var a = inp.Split(';');
            foreach (var x in a)
            {
                int i = 0;
                while (i < x.Length)
                {
                    StringBuilder word = new StringBuilder(50);
                    while (i < x.Length && !G(x[i]))
                    {
                        if (word.Length == 0 && 'a' <= x[i] && x[i] <= 'z')
                        {
                            word.Append((char)(x[i] + 'A' - 'a'));
                        }
                        else
                        {
                            word.Append(x[i]);
                        }
                        i++;
                    }
                    if (i < x.Length)
                    {
                        if (word.Length == 0 && 'a' <= x[i] && x[i] <= 'z')
                        {
                            word.Append((char)(x[i] + 'A' - 'a'));
                        }
                        else
                        {
                            word.Append(x[i]);
                        }
                        i++;
                    }
                    Console.Write(word);
                    while (i < x.Length && x[i] != ' ')
                    {
                        word.Append(x[i]);
                        i++;
                    }
                    i++;
                }
                Console.WriteLine();
            }
                    
        }
    }
}
