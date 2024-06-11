using System;
namespace MyFirstApp
{
    class Animal1{
        public string Name { get; set; }

        public virtual void Speak()
        {
            Console.WriteLine($"{Name} is making a noise.");
        }
    }
    class Dog1 : Animal1
    {
        public override void Speak()
        {
            Console.WriteLine($"{Name} is barking.");
        }
    }
}