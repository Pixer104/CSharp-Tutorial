using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.AccessModifiers
{
    /*public class Base
    {
        protected int x = 11;
    }
    public class Derived : Base
    {
        public void Access()
        {
            var a = new Base();
            var b = new Derived();

            // a.x = 12; //cannot access with a qualifier of type A
            b.x = 13;
            
        }
        
    }*/

   public class BaseClass
   {
        protected int protectedField;
        protected void ProtectedMethod()
        {
            Console.WriteLine("this is a protected method");
        }
   }
    public class DerivedClass : BaseClass
    {
        public void AccessProtectedMember()
        {
            protectedField = 19;
            Console.WriteLine($"Accessing protected field from derived class");
            ProtectedMethod();
            Console.WriteLine(protectedField);
        }
    }

    // PRIVATE MEMBERS - it can only be accessed in same class containing private members
    class PvtMembers
    {
        private int num1 = 10;
        private int num2 = 11;
        private void PvtMethodAdd(int a, int b)
        {
            num1 = a;
            num2 = b;
            int result = a + b;
            Console.WriteLine(result);
        }
        public int ShowVariable()
        {
            return num1 & num2;

        }

        public void ShowMethod()
        {
            PvtMethodAdd(21, 23);
        }
    }
    class Derived : PvtMembers
    {
        public void AccesVar()
        {
           // PvtMethodAdd(); // it's not accessible in derived class
        }
    }
    

}
