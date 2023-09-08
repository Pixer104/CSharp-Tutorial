using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.OOPsBasics
{
    public class Car
    {
        // Member Variables
        private string color;
        private string name;
        private int hp;

        public string getName()
        {
            return name;
        }
        public void setName(string carName)
        {
            name = carName;
        }
        //  Default Constructor
        public Car()
        {
            name = "Car";
            hp = 800;
            color = "white";
        }

        // 
        public Car(string carName, int horsePower, string carColor)
        {
            name = carName;
            hp = horsePower;
            color = carColor;
            Console.WriteLine(carName + " was created");
        }

        //Member Method
        public void Run()
        {
            Console.WriteLine(name + " is Running");
        }

        public void Stop()
        {
            Console.WriteLine(name + " Stopped");
        }
        public void Details()
        {
            Console.WriteLine(name + " is having " + hp + " horsepower and " + color + " in color");
        }

    }

    //      DESTRUCTOR
    public class Person
    {
        public string Name;
        public int Age;

        public Person(string name, int age) //parameterized constructor
        {
            this.Name = name; //this keyword is referring to class variable
            this.Age = age;
        }

        public string getName()
        {
            return this.Name;
        }
        public int getAge()
        {
            return this.Age;
        }

        ~Person()
        {
            Console.WriteLine("Destructor has been invoked !");
        }
    }
}
