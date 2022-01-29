using System;

namespace ConsoleApp1
{ 
    public class RingIsFoundEventArgs : EventArgs
    {
        public RingIsFoundEventArgs(string s) { Message = s; }
        public String Message { get; set; }
    };

    abstract public class Creature
    {
        public string Name { get; protected set; }
        protected string Location;
    };

    public class Wizard : Creature
    {

        public delegate void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs a);

        public event RingIsFoundEventHandler RaiseRingIsFoundEvent;

        public Wizard(string s, string s2) { Name = s; Location = s2; }
        public Wizard() { }

        public void SomethingIsChangedInTheAir()
        {
            Console.WriteLine($"{Name} >> Кольцо найдено у старого Бильбо! Призываю вас в {Location}! ");
            RaiseRingIsFoundEvent(this, new RingIsFoundEventArgs(Location));
        }
    };

    public class Hobbit : Creature
    {
        public Hobbit(string s, string s2="Шир") { Name = s; Location = s2; }

        public void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Покидаю {Location}! Иду в " + e.Message);
        }
    };

    public class Human : Creature
    {
        public Human(string s, string s2) { Name = s; Location = s2; }
        public void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Сейчас я в {Location}. Волшебник {((Wizard)sender).Name} позвал. Моя цель { e.Message }");
            Location = e.Message;
        }
    };

    public class Elf : Creature
    {
        public Elf(string s, string s2) { Name = s; Location = s2; }
        public void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> В {Location} звёзды светят не так ярко как обычно. Цветы увядают. Листья предсказывают идти в " + e.Message);
            Location = e.Message;
        }
    };

    public class Dwarf : Creature
    {
        public Dwarf(string s, string s2) { Name = s; Location = s2;  }
        public void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Точим топоры, собираем припасы! Выдвигаемся в {e.Message} из {Location}");
            Location = e.Message;
        }
    };


    class Program
    {
        static void Main(string[] args)
        {
            Creature[] FellowshipOfTheRing = new Creature[9];


            Wizard wizard = new Wizard("Гендальф", "Ривенделл");
            FellowshipOfTheRing[0] = wizard as Creature;

            Hobbit[] hobbit = new Hobbit[4];
            hobbit[0] = new Hobbit("Фродо");
            hobbit[1] = new Hobbit("Сэм");
            hobbit[2] = new Hobbit("Мерри");
            hobbit[3] = new Hobbit("Пипин");
            for (int i = 0; i < 4; ++i)
            {
                FellowshipOfTheRing[i + 1] = hobbit[i] as Creature;
                (FellowshipOfTheRing[0] as Wizard).RaiseRingIsFoundEvent += hobbit[i].RingIsFoundEventHandler;
            }

            Human[] humans = { new Human("Боромир", "Гондора"), new Human("Арагорн", "Рохана") };
            for (int i = 0; i < 2; ++i)
            {
                FellowshipOfTheRing[5 + i] = humans[i] as Creature;
                (FellowshipOfTheRing[0] as Wizard).RaiseRingIsFoundEvent += humans[i].RingIsFoundEventHandler;
            }

            Dwarf dwarf = new Dwarf("Гимли", "Железных холмов");
            FellowshipOfTheRing[7] = dwarf as Creature;
            (FellowshipOfTheRing[0] as Wizard).RaiseRingIsFoundEvent += dwarf.RingIsFoundEventHandler;

            Elf elf = new Elf("Леголас", "Лихолестье");
            FellowshipOfTheRing[8] = elf as Creature;
            (FellowshipOfTheRing[0] as Wizard).RaiseRingIsFoundEvent += elf.RingIsFoundEventHandler;

            (FellowshipOfTheRing[0] as Wizard).SomethingIsChangedInTheAir();
        }
    };
}
