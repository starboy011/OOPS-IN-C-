using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Encapsulation
            Person person = new Person();
            person.Name = "John";
            person.Age = 40;
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

            //inheritance
            Dog dog = new Dog();
            dog.Name = "Buddy";
            dog.Eat();
            dog.Bark();

            //Polynorphism
            Animal1 myAnimal = new Animal1 { Name = "Animal" };
            myAnimal.Speak();

            Dog1 myDog = new Dog1 { Name = "Buddy" };
            myDog.Speak();

            //Abstraction

            Animal2 myDog2 = new Dog2 { Name = "Buddy" };
            myDog2.MakeSound();

            Animal2 myCat = new Cat { Name = "Whiskers" };
            myCat.MakeSound();
        }
    }
}
