using System;
namespace MyFirstApp
{
    abstract class Animal2
    {
        public string Name { get; set; }
        public abstract void MakeSound();
    }

    class Dog2 : Animal2
    {
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says Woof!");
        }
    }

    class Cat : Animal2
    {
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} says Meow!");
        }
    }
}
