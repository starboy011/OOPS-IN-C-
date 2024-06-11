using System;
namespace MyFirstApp
{
    class Animal {
        public string Name {get;set;}
        public void Eat(){
            Console.WriteLine($"{Name} is eating.");
        }
    }
    class Dog:Animal{
        public void Bark(){
            Console.WriteLine($"{Name} is barking.");
        }
    }
}
