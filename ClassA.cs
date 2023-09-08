using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class A
    {
        public string Firstname
        {
            get { return Firstname; }
            set { Firstname = value; }
        }

        protected string MiddleName { get; set; }
        public void Display()
        {
            Console.WriteLine("it's an base class");
        }
    }
    public class B : A
    {
        public  string Lastname { get; set; }
        public new void Display()
        {
            Console.WriteLine(MiddleName);
            Console.WriteLine("it's an derived class ");
        }

        

    }

    public class ClassC
    {
        public A A { get; set; }
        public B B { get; set; }
        public ClassC(A a , B b) {
            A = a; B = b;
        }
    }


    

}
