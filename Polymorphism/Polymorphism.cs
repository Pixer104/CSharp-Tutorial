using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.POLYMORPHISM
{
    class Polymorphism
    {
        //static polymorphism via method overloading
        public int sum(int a, int b)
        {
            return a + b;
        }

        public double sum(double a, double b)
        {
            return a + b;
        }

        public void Dynamic_Polymorphism()
        {
            var shapes = new List<Shape>
            {
                new Rectangle(),
                new Triangle(),
                new Circle(),

            };
            /*Shape shapes = new Shape();
            shapes = new Rectangle();
            shapes = new Circle();
            shapes = new Triangle();*/

            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }


    }

    //      ********* SEALED CLASS - it's used to restrict the user from inheriting the class
    //      it can't be extended. No class can be derived from sealed keyword
    sealed class SealedClass
    {
        public int Calculate(int a, int b)
        {
            return a * b;
        }
    }

    class Printer
    {
        public virtual void Show()
        {
            Console.WriteLine("display dimension : 6*6");
        }

        public virtual void Print() //virtual method cannot be sealed
        {
            Console.WriteLine("printer printing...\n");
        }

    }

    class LaserJet : Printer
    {
        sealed override public void Show()
        {
            Console.WriteLine("display dimension : 12*12");
        }

        override public void Print()
        {
            Console.WriteLine("Laser jet printing...\n");
        }

    }

    class OfficeJet : LaserJet
    {
        /* override public void Show() // it can't be override or inherited because it's sealed 
         {
         }*/

        public override void Print()
        {
            Console.WriteLine("OfficeJet printer printing....");
        }
    }

    public class Shape
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Performing base class drawing tasks.");
        }

    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Circle...");
            base.Draw();
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle...");
            base.Draw(); //it'll call the base class -> (shape)
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a Triangle...");
            base.Draw();
        }
    }

    //      ***********HAS A-RELATIONSHIPs**************

    /*class Address
    {
        public string AddressLine, City, State;
        public Address(string addressLine, string city, string state)
        {
            AddressLine = addressLine;
            City = city;
            State = state;
        }
    }
    class Person
    {
        //using Address in Employee class
        //Establishing Has-A relationship i.e. Employee HAS-A Address
        public Address address;
        public int Id;
        public string Name;
        public Person(int id, string name, Address adres)
        {
            Id = id;
            Name = name;
            address = adres;

        }

        public void Display()
        {
            Console.WriteLine($"Employee Id: {Id}");
            Console.WriteLine($"Employee Nmae: {Name}");
            Console.WriteLine($"AddressLine: {address.AddressLine}");
            Console.WriteLine($"City: {address.City}");
            Console.WriteLine($"State: {address.State}");
        }


    }*/

}
