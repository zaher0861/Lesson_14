using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Кекс");
            cat.ShowInfo();
            Dog dog = new Dog("Корица");
            dog.ShowInfo();
            Console.ReadKey();

        }
    }
    abstract class Animal
    {
        public abstract string Name { get; set; }
        public Animal(string name)
        {
            Name = name;
        }
        public abstract void Say();
        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Say();
        }
    }
    class Cat : Animal
    {
        string name;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Cat(string name)
            :base(name)
        {
        }
        
        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }
    class Dog:Animal
    {
        string voice;
        string name;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public Dog(string name)
            :base(name)
        {
        }

        public override void Say()
        {
            Console.WriteLine("Гав"); 
        }
    }

}
