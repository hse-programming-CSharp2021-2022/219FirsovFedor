using System;
using System.Collections.Generic;



abstract class Person
{
    protected string Name { get; }

    protected string Pocket { get; set; }

    public abstract void Receive(string present);

    protected Person(string name)
    {
        if (string.IsNullOrEmpty(name))
            throw new ArgumentException("parameter 'string name' is empty");
        Name = name;
    }

    public override string ToString()
    {
        return $"Name is {Name}";
    }
}

class SnowMaiden : Person
{
    public SnowMaiden(string name) : base(name) { }

    public override void Receive(string present)
    {
        if (!string.IsNullOrEmpty(Pocket))
        {
            throw new ArgumentException("Pocket of maiden is full.");
        }

        Pocket = present;
    }

    public string[] CreatePresents(int amount)
    {
        var presents = new string[amount];
        for (var i = 0; i < presents.Length; i++)
        {
            var syms = new string[3];
            for (var j = 0; j < 2; j++)
            {
                var r = new Random();
                var sym = (char)r.Next(0, 127);
                syms[j] = sym.ToString();
            }

            presents[i] = syms[0] + syms[1] + syms[2] + syms[1] + syms[0];
        }

        return presents;
    }
}

class Santa : Person
{
    public List<string> sack;

    public Santa(string name) : base(name)
    {
        sack = new List<string>();
    }

    public override void Receive(string present)
    {
        if (!string.IsNullOrEmpty(Pocket))
        {
            throw new ArgumentException("Pocket of Santa is full.");
        }

        Pocket = present;
    }

    public void Request(SnowMaiden maiden, int amount)
    {
        var presents = maiden.CreatePresents(amount);
        foreach (var present in presents)
        {
            sack.Add(present);
        }
    }

    public void Give(Person person)
    {
        if (sack.Count == 0)
        {
            throw new Exception("Lack of presents in sack.");
        }
        var r = new Random();
        var indOfPresent = r.Next(0, sack.Count);
        person.Receive(sack[indOfPresent]);
        sack.RemoveAt(indOfPresent);
    }
}

class Child : Person
{
    public Child(string name) : base(name) { }

    private string additionalPocket;

    public override void Receive(string present)
    {
        if (!string.IsNullOrEmpty(Pocket) && !string.IsNullOrEmpty(additionalPocket))
        {
            throw new ArgumentException($"Pockets of child {Name} are full.");
        }

        if (!string.IsNullOrEmpty(Pocket))
        {
            additionalPocket = present;
            return;
        }

        Pocket = present;
    }
}




class Program
{
    private static void Main()
    {
        while (true)
        {
            Console.WriteLine("Хотите запустить еще раз? Введите NO для выхода.");
            if (Console.ReadLine() == "NO")
                return;

            var maiden = new SnowMaiden("Snow Maiden");
            var santa = new Santa("Mad Santa");
            var people = new List<Person>(12);

            people.Add(santa);
            people.Add(maiden);
            for (var i = 0; i < 10; i++)
            {
                people.Add(new Child($"Child {i + 1}"));
            }

            bool MaidenisDeleted = false;

            while (true)
            {
                var rnd = new Random();
                if (rnd.Next(1, 11) == 1)
                {
                    try
                    {
                        santa.Give(santa);
                        Console.WriteLine(santa);
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                        break;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        if (!MaidenisDeleted)
                            santa.Request(maiden, rnd.Next(1, 5));
                        if ((MaidenisDeleted && santa.sack.Count == 0) || people.Count == 1)
                            break;
                    }
                }

                else
                {
                    var x = rnd.Next(1, people.Count);
                    try
                    {
                        santa.Give(people[x]);
                        Console.WriteLine(people[x]);
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                        people.RemoveAt(x);
                        if (x == 1 && !MaidenisDeleted)
                        {
                            MaidenisDeleted = true;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        if (!MaidenisDeleted)
                            santa.Request(maiden, rnd.Next(1, 5));
                        if ((MaidenisDeleted && santa.sack.Count == 0) || people.Count == 1)
                            break;
                    }
                }
                if (!MaidenisDeleted)
                    santa.Request(maiden, rnd.Next(1, 5));

            }
        }
    }
}
