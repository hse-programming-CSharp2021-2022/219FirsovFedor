using System;
using System.Collections.Generic;

namespace Task01
{
    class Program
    {

        const int HolyAge = 77;
        public class Creature
        {

            public Creature(string name, double speed)
            {
                Name = name;
                Speed = speed;
            }
            public string Name { get; set; }
            public double Speed { get; set; }

            public virtual string Run()
            {
                return $"I am running with a speed of {Speed}.";
            }
            public override string ToString()
            {
                return this.Run() + $"My name is {Name}.";
            }
        }

        public class Dwarf : Creature
        {
            public double Strength { get; set; }
            public Dwarf(string name, double speed, double strength) : base(name, speed)
            {
                if (strength < 1 || strength > 20)
                {
                    var rnd = new Random();
                    strength = rnd.NextDouble() * 19 + 1;
                }
                Strength = strength;
            }

            public override string Run()
            {
                return base.Run() + $"My strength is {Strength}.";
            }
            public void MakeNewStaff()
            {
                Console.WriteLine("I've created a new staff!");
            }
        }


        public class Elf : Creature
        {
            public int Age { get; set; }
            public Elf(string name, double speed) : base(name, speed)
            {
                var rnd = new Random();
                Age = rnd.Next(100, 201);
            }

            public override string Run()
            {
                return $"I am running with a speed of {Speed + Age / 77}." + $"My age is {Age}.";
            }
        }


        static void Main(string[] args)
        {
            while (true)
            {
                int n;
                int.TryParse(Console.ReadLine(), out n);
                List<Creature> line = new List<Creature>(n);
                for (int i = 0; i < n; ++i)
                {
                    var rnd = new Random();
                    int rndNum = rnd.Next(1, 101);
                    string name = rnd.Next('A', 'Z').ToString();
                    for (int j = 0; j < rnd.Next(5); ++j)
                    {
                        name += rnd.Next('a', 'z').ToString();
                    }
                    if (rndNum / 10 < 2)
                    {
                        line.Add(new Creature(name, rnd.NextDouble() * 8 + 10));
                    }
                    else if (rndNum / 10 < 6)
                    {
                        line.Add(new Dwarf(name, rnd.NextDouble() * 8 + 10, rnd.Next(-50, 51)));
                    }
                    else
                    {
                        line.Add(new Elf(name, rnd.NextDouble() * 8 + 10));
                    }
                }
                for (int i = 0; i < n; ++i)
                {
                    Console.WriteLine(line[i].Run());
                    if (line[i] is Dwarf)
                    {
                        (line[i] as Dwarf).MakeNewStaff();
                    }
                }
            }
        }
    }
}
