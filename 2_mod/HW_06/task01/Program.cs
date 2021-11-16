using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace task01
{
    class Program
    {

        public static void f()
        {
            try
            {
                f();
            }
            catch 
            {
                Console.WriteLine("Exception_WasThrown");
            }
        }

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


            string[] buff = { "1", "2"};
            Object[] objs = (Object[])buff;
            try
            {
                Object obj = (Object)13;
                objs[1] = obj;
            }
            catch (System.ArrayTypeMismatchException)
            {
                System.Console.WriteLine("New element is not of the correct type.");
            }




            try
            {
                int[] d = null;
                Array.Sort(d);
            }
            catch (System.ArgumentNullException)
            {
                Console.WriteLine("Value cannot be null.");
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

            try
            {
                bool sample = true;
                IConvertible conv = sample;
                Char ch = conv.ToChar(null);
            }

            catch (System.InvalidCastException)
            {
                Console.WriteLine("Invalid cast from 'Boolean' to 'Char'");
            }

            try
            {
                //f();
            }
            catch 
            {
                Console.WriteLine("Exception_WasThrown");
            }
        }
    }
}
