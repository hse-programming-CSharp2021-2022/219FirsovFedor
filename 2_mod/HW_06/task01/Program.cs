using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace task01
{
    class Program
    {
        class SAS_Exception : Exception
        {
            public SAS_Exception(string msg) : base(msg) { }
        }
        static void Main(string[] args)
        {
            try // 1-st
            {
                int a = 1;
                int b = 0;
                Console.WriteLine(a / b);
            }
            catch (System.DivideByZeroException)
            {
                Console.WriteLine("Attempted to divide by zero.");
            }

            try // 2-nd
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
            try // 3-rd
            {
                Object obj = (Object)13;
                objs[1] = obj;
            }
            catch (System.ArrayTypeMismatchException)
            {
                System.Console.WriteLine("New element is not of the correct type.");
            }


            try // 4-th
            {
                int[] d = null;
                Array.Sort(d);
            }
            catch (System.ArgumentNullException)
            {
                Console.WriteLine("Value cannot be null.");
            }

            try // 5-th
            {
                using (StreamReader sr = new StreamReader("бред какой-то")) { }
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("Could not find file.");
            }

            try // 6-th
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

            try // 7-th
            {
                bool sample = true;
                IConvertible conv = sample;
                Char ch = conv.ToChar(null);
            }
            catch (System.InvalidCastException)
            {
                Console.WriteLine("Invalid cast from 'Boolean' to 'Char'");
            }


            try // 8-th
            {
                 string qwe = "qwe";
                 Convert.ToInt32(qwe);
             }
             catch (System.FormatException)
             {
                 Console.WriteLine( "Input string was not in a correct format.");
             }


            try // 9-th
            {
                int max = int.MaxValue;
                int newMax = max * max;
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("Arithmetic operation resulted in an overflow.");
            }

            
            try // 10-th
            {
                List<int> i_dont_know_name = new List<int>();
                for (int i = 0; i < 179; ++i)
                {
                    i_dont_know_name.Add(179);
                }
                foreach (var elem in i_dont_know_name)
                {
                    i_dont_know_name.Add(elem);
                }
                int x = i_dont_know_name.Count();
            }
            catch (System.InvalidOperationException)
            {
                Console.WriteLine("Collection was modified; enumeration operation may not execute.");
            }

            try
            {
                throw new SAS_Exception("SAS...");
            }
            catch (SAS_Exception)
            {
                Console.WriteLine("SAS's coming...");
            }
            

        }
    }
}
