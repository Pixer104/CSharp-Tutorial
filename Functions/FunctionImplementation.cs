using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals.Functions
{
    class FunctionImplementation
    {
        public void Display()
        {
            Console.WriteLine("display anything");
        }
        public int Sum(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine($"the sum of {num1} and {num2} is: {result}");
            return 0;

        }
        //  UDEMY TASK
        public void GreetFriend(string friend)
        {

            Console.WriteLine($"hi {friend} , my friend!");
        }

        //implement user input in method
        public int Calculate()
        {
            Console.WriteLine("Please enter the first number");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int number2 = Convert.ToInt32(Console.ReadLine());

            return number1 + number2;
        }

        //exception handling
        public void ExceptionHandling(int age)
        {
            /*if (age < 18)
            {
                throw new ArithmeticException("Access denied - you must be at least 18 yr or older");
            }
            else
            {
                Console.WriteLine("Access Granted - u are old enough!");
            }*/
            try
            {
                if (age < 18)
                {

                }
                /*int[] numbers = { 1, 7, 9 };
                Console.WriteLine(numbers[10]);*/
            }
            catch (Exception err)
            {
                //Console.WriteLine(err.Message);
                Console.WriteLine("Error occured");
            }
            finally
            {
                Console.WriteLine("try catch is finished");
            }
        }
    }
    /*class Multiplication
    {
        public int Product(int n1, int n2)
        {
            int prod = n1 * n2;
            Console.WriteLine($"Product of {n1} and {n2} is: {prod}");
            return 0;
        }
    }*/
}
