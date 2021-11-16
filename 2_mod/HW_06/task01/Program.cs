using System;
using System.IO;

namespace task01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 1;
                int b = 0;
                Console.WriteLine(a / b);
            }
            catch (System.DivideByZeroException)
            {
                Console.WriteLine("Attempted to divide by zero.");
            }

            try
            {
                int[] list = new int[1];
                list[1] = 10;
            }
            catch (System.IndexOutOfRangeException)
            {
                Console.WriteLine("Index was outside the bounds of the array.");
            }

            try
            {
                int[] d = null;
                Array.Sort(d);
            }
            catch (System.ArgumentNullException)
            {
                Console.WriteLine("Value cannot be null. Arg_ParamName_Name");
            }

            try
            {
                using (StreamReader sr = new StreamReader("бред какой-то")) { }
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("Could not find file.");
            }

            try
            {
                using (StreamReader sr = new StreamReader("1.txt"))
                {
                    using (StreamWriter sw = new StreamWriter("1.txt"))
                    {

                    }
                }
            }
            catch(System.IO.IOException)
            {
                Console.WriteLine("The process cannot access the file because it is being used by another process.");
            }
        }
    }
}
