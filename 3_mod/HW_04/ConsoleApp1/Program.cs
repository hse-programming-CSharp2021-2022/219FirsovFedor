using System;

namespace ConsoleApp1
{

    public class RingIsFoundEventArgs : EventArgs {
        public RingIsFoundEventArgs(string s) { Message = s; }
        // Будем передавать только строку
        public String Message { get; set; }
    };

    public class Wizard
    {
        public string Name { get; private set; }

        //2) событийный делегат
        public delegate void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs a);

        //3) событие "Кольцо найдено"
        public event RingIsFoundEventHandler RaiseRingIsFoundEvent;

        public Wizard(string s) { Name = s; }
        public Wizard() { }
        // Когда волшебнику кажется, что кольцо найдено, он вызывает этот метод
        public void SomethingIsChangedInTheAir()
        {
            Console.WriteLine($"{Name} >> Кольцо найдено у старого Бильбо! Призываю вас в Ривенделл! ");
            RaiseRingIsFoundEvent(this, new RingIsFoundEventArgs("Ривендейл"));
        }
    };

    public class Hobbit
    {
        public string Name { get; private set; }
        public Hobbit(string s) { Name = s; }

        public void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Покидаю Шир! Иду в " + e.Message);
        }
    };

    public class Human
    {
        public string Name { get; private set; }
        public Human(string s) { Name = s; }
        public void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Волшебник {((Wizard)sender).Name} позвал. Моя цель { e.Message }");
        }
    };
    public class Elf
    {
        public string Name { get; private set; }
        public Elf(string s) { Name = s; }
        public void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Звёзды светят не так ярко как обычно. Цветы увядают. Листья предсказывают идти в " + e.Message);
        }
    };

    public class Dwarf
    {
        public string Name { get; private set; }
        public Dwarf(string s) { Name = s; }
        public void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Точим топоры, собираем припасы! Выдвигаемся в " + e.Message);
        }
    };


    class Program
    {
        static void Main(string[] args)
        {
            Wizard wizard = new Wizard("Гендальф");

            Hobbit[] hobbit = new Hobbit[4];
            hobbit[0] = new Hobbit("Фродо");
            hobbit[1] = new Hobbit("Сэм");
            hobbit[2] = new Hobbit("Мерри");
            hobbit[3] = new Hobbit("Пипин");
            for (int i = 0; i < 4; ++i)
            {
                wizard.RaiseRingIsFoundEvent += hobbit[i].RingIsFoundEventHandler;
            }

            Human[] humans = { new Human("Боромир"), new Human("Арагорн") };
            for (int i = 0; i < 2; ++i)
            {
                wizard.RaiseRingIsFoundEvent += humans[i].RingIsFoundEventHandler;
            }

            Dwarf dwarf = new Dwarf("Гимли");
            wizard.RaiseRingIsFoundEvent += dwarf.RingIsFoundEventHandler;

            Elf elf = new Elf("Леголас");
            wizard.RaiseRingIsFoundEvent += elf.RingIsFoundEventHandler;

            wizard.SomethingIsChangedInTheAir();
        }
    };
}
