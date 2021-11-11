using System;
namespace TaskAnimal
{
    abstract class Animal
    {
        string Name{ get; set;}
        bool IsTrained{ get; }
        public abstract string AnimalSound();
        public abstract string AnimalInfo();
    }
    class Dog : Animal
    {
        bool isTrained = true;
        public Dog(string name) { this.Name = name;}

        bool IsTrained{ get; }
        string Name{ get; set;}

        public override string AnimalSound(){ return "gav gav";}
        public override string AnimalInfo()
        {
            return $"Name - {this.Name}, Sound - {this.AnimalSound()}, Is Trained - {this.IsTrained}";
        }
    }
    class Cow : Animal
    {
        int MilkCount;
        public Cow(string name, int milk) { this.Name = name; MilkCount = milk; }
        bool IsTrained { get; }
        string Name { get; set;}
        public override string AnimalSound() {return "moo";}
        public override string AnimalInfo()
        {
            return $"Name - {this.Name}, Sound - {this.AnimalSound()}, Is Trained {this.IsTrained}, Milk Count - {MilkCount}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Tyzik");

            Cow cow = new Cow("Zoriaka", 10); 
            Console.WriteLine(dog.AnimalInfo());
            Console.WriteLine(cow.AnimalInfo());
        }
    }
}