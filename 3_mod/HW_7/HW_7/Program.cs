using System;

namespace HW_7
{
    struct Person : IComparable<Person>
    {
        private string name;
        private string lastname;
        private int age;

        public Person(string name, string lastname, string age)
        {
            this.name = name;
            this.lastname = lastname;
            if (int.Parse(age) < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            this.age = int.Parse(age);
        }

        public int CompareTo(Person other)
        {
            return age.CompareTo(other.age);
        }

        public override string ToString()
        {
            return $"{name} {lastname} {age}";
        }
    }

    class Program
    {
        public static string GenerateName(int n)
        {
            Random rand = new Random();
            string now = "";
            for (int i = 0; i < n; ++i)
            {
                now += (char)('a' + rand.Next(0, 26));
            }
            return now;
        }

        static void Main(string[] args)
        {
            int n = 10;
            Person[] peop = new Person[n];
            Random rand = new Random();
            for (int i = 0; i < n; ++i)
            {
                peop[i] = new Person(GenerateName(rand.Next(1, 10)),
                    GenerateName(rand.Next(1, 10)),
                    rand.Next(1, 101).ToString());
                Console.WriteLine(peop[i]);
            }
            Array.Sort(peop);
            Console.WriteLine();
            for (int i = 0; i < n; ++i)
            {
                Console.WriteLine(peop[i]);
            }
        }
    }
}