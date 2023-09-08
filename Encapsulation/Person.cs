using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Encapsulation
{
    public class Person
    {
        private int personAge;
        private string personName;
        

       
        public void SetAge(int newAge)
        {
            this.personAge = newAge;
            if (newAge > 0)
                personAge = newAge;
            else
                Console.WriteLine("Age should not be negative or Zero");
        }


        public void GetAge()
        {
            if (personAge > 0)
                Console.WriteLine("your Age is : {0}", personAge);
                //return personAge;
        }

        public void SetPersonName(string newName)
        {
            this.personName = newName;
            if (string.IsNullOrEmpty(personName) == true)
                Console.WriteLine("Name is required.");
            else
                personName = newName;
        }


        public void GetPersonName()
        {
            if (string.IsNullOrEmpty(personName) != true)
            {
                Console.WriteLine("your name is: {0}", personName);
            }
               
        }

    }
}
