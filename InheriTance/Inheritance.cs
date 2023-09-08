using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.INHERITANCE
{
    public class Inheritance
    {
        /*public void SingleInheritance()
        {
            Console.WriteLine("\nSigle Inheritance");
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();
        }

        public void MultilevelInheritance() 
        {
            Console.WriteLine("\nMultilevel inheritance");
            Horse ghoda = new Horse();
            ghoda.Eat();
            ghoda.Run();
            ghoda.Gallop();
        }

        public void HierarchicalInheritance()
        {
            Console.WriteLine("\nHierarchical Inheritance");
            Eagle eagle = new Eagle();
            eagle.Fly();
            eagle.Hunt();
            Penguin penguin = new Penguin();
            penguin.Fly();
            penguin.Swim();

        }*/
        public void Virtual_Override()
        {
            Dog dog = new Dog("German Shepherd", 14);
            Console.WriteLine($"{dog.Name} is  {dog.Age} years old");
            dog.Eat();
            dog.Play();
            dog.MakeSound();
        }

    }

    //base class
    class Animal
    {

        public int Age { get; set; }

        public string Name { get; set; }

        public bool IsHungry { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            IsHungry = true;
        }

        public virtual void MakeSound()
        {

        }

        //virtual method called Eat which allows subclasses to override
        public virtual void Eat()
        {
            if (IsHungry)
            {
                Console.WriteLine($"{Name} is Eating");
            }
            else
            {
                Console.WriteLine($"{Name} is not Hungry");
            }
        }

        public virtual void Play()
        {
            Console.WriteLine($"{Name} is Playing");
        }

    }

    //Derived Class
    class Dog : Animal
    {
        public bool IsHappy { get; set; }

        public Dog(string name, int age) : base(name, age) //base keyword is used access members of the base class
                                                           //from within a derived class
        {
            IsHappy = true;

        }

        public override void Eat()
        {
            //to call the eat method from our base(Animal) class 
            base.Eat();
        }

        public override void MakeSound()
        {
            Console.WriteLine("Wuuuuuu!");
        }

        public override void Play()
        {
            if (IsHappy)
            {
                base.Play();
            }
        }
    }
    /* class Animal
     {
         public void Eat()
         {
             Console.WriteLine("Animal is eating.");
         }
     }

     class Dog : Animal
     {
         public void Bark()
         {
             Console.WriteLine("Dog is Barking.");
         }
     }

     //multi-level inheritance
     class Mammal : Animal
     {
         public void Run()
         {
             Console.WriteLine("");
         }
     }
     class Horse : Mammal
     {
         public void Gallop()
         {
             Console.WriteLine("Horse is galloping");
         }
     }

     //hierarchical inheritance
     class Bird : Animal
     {
         public void Fly()
         {
             Console.WriteLine("");
         }
     }
     class Penguin : Bird
     {
         public void Swim()
         {
             Console.WriteLine("Penguin is Swimming ");
         }
     }
     class Eagle : Bird
     {
         public void Hunt()
         {
             Console.WriteLine("Eagle is hunting");
         }
     }*/



}
