using System;
using System.Drawing;
using System.Net.Http.Headers;
using System.Security.AccessControl;
using System.Collections.Generic;
using Fundamentals.Abstraction;
using Fundamentals.Encapsulation;
using Fundamentals.AccessModifiers;
using System.Security.Cryptography.X509Certificates;

namespace Fundamentals
{
    class Program
    {
        public static void Main(string[] args)
        {

            /*  TYPECASTING */
            /*  implicit -  automatically done  *//*
            int myInt = 13;
            double myDouble = myInt;
            Console.WriteLine(myDouble);

            *//*  Explicit - done manually    *//*
            double myDouble2 = 9.91;
            int cast_int = (int) myDouble2;
            Console.WriteLine(cast_int); // 9

            *//*  Type convrsion method   *//*
            int int_val = 18;
            double double_val = 76.731;
            bool bool_val = true;

            Console.WriteLine(Convert.ToString(int_val));
            Console.WriteLine(Convert.ToInt32(double_val));
            Console.WriteLine(Convert.ToString(bool_val));
            Console.WriteLine(Convert.ToDouble(int_val));
            Console.WriteLine(Convert.ToDecimal(int_val));


            *//*  User input  *//*
            Console.WriteLine("Enter ur age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your age is: {age}");*/



            //PRE AND POST INCREMENT , DECREMENT
            /* int x = 9 , y = 11;
            Console.WriteLine("After x++: {0}", x++); // 9 first the x will get printed then it'll get incremented
            Console.WriteLine("After ++x: {0}", ++x); // 11 x is 10 after x++ and then ++x will increment then it'll print

            Console.WriteLine("After y--: {0}", y--); // 11 
            Console.WriteLine("After --y: {0}", --y); // 9 */




            //*************** Method / Function Implementation *****************

            /*FunctionImplementation fi_obj = new FunctionImplementation();
            fi_obj.Display();
            fi_obj.Sum(43, 67);
            fi_obj.Sum(21,65);*/

            /* Multiplication m = new Multiplication();
             m.Product(24, 5);*/
            // Product(21 , 4); //we can't directly call non static method in static method.

            //  UDEMY TASK

            /* fi_obj.GreetFriend("Naruto Uzumaki");
             fi_obj.GreetFriend("Jiraya Sensei");
             fi_obj.GreetFriend("Itachi Uchiha");*/

            // implement user input inside function
            // Console.WriteLine(fi_obj.Calculate());



            //  ************EXCEPTION HANDLING***************
            //fi_obj.ExceptionHandling(17);



            //************** Conditional Statements / Loops ****************
            /*ConditionsAndLoops conditional = new ConditionsAndLoops();
            conditional.ConditionalStatements();

            Console.WriteLine("\n Below is the Task output ");
            conditional.MicrosoftTask();

            Console.WriteLine("\n");
            conditional.CheckHighScore(300 , "Ms Dhoni");
            conditional.CheckHighScore(210 , "Sky");
            conditional.CheckHighScore(318, "Virat Kohli");

            conditional.TernaryOperator(102);*/



            //**************    OOPs CONCEPT    ***************

            //getter and setter

            /*Car own_car = new Car();
            own_car.setName(" Default Ferrari");
            Console.WriteLine(own_car.getName());
            own_car.Details();*/

            /* Car lambo = new Car("Lamborghini Aventador" , 1200, "white");
             lambo.Run();
             lambo.Details();

             Car mustang = new Car("Mustang Dark Horse", 900, "blue");
             mustang.Run();
             mustang.Details(); 

             string userInput = Console.ReadLine();
             if(userInput == "Stop")
             {
                 lambo.Stop();
             }*/



            //      *************DESTRUCTOR*************

            /*Person Mack = new Person("mack" , 22);
            Console.WriteLine(Mack.getName());
            Console.WriteLine(Mack.getAge());
            Console.ReadLine();*/




            //     *****ARRAY PRACTICE*******

            /*ArrayPractice arr = new ArrayPractice();
            arr.SingleDarray();
            Console.WriteLine("\n");
            arr.MultiDArray();
            Console.WriteLine("\n");
            arr.JaggedArray();
            Console.WriteLine("\n");
            Console.WriteLine(arr.GetAverage(new int[] { 2, 5, 7, 8, 9, 11, 13 }));
            Console.WriteLine("\n");
            arr.ParamsMethod(1, 3, 4, 6, 8, 9, 11, 13);
            Console.WriteLine("\n");*/
            //arr.ParamsMethod2(myObjArray);




            //  ***********  COLLECTION PRACTICE  ***************

            /*CollectionPractice collection = new CollectionPractice();
            collection.Arraylist();
            collection.ListCollection();
            collection.HashTables();
            collection.DictionaryImplementation();
            *]
            *collection.StackImplementation();
            collection.QueueImplementaion();*/



            //      *********** INHERITANCE IMPLEMENTATION  *********

            //Inheritance inheritance = new Inheritance();
            //inheritance.SingleInheritance();
            //inheritance.MultilevelInheritance();
            //inheritance.HierarchicalInheritance();
            //inheritance.Virtual_Override();


            //  ********INTERFACE IMPLEMENTATION***********
            /*SampleClass sample = new SampleClass();
            IDrawable drawable = sample;
            ISurface surface = sample;

            //the following lines call the same method.
            //sample.Paint(); //compile time error
            drawable.Paint();
            surface.Paint();*/


            //  ********* ABSTRACTION IMPLEMENTATION *******

            /*Employee emp = new Employee(11 , "Bon Jovi", 48500.0);
            emp.ShowEmployeeDetails();*/


            // ********** ENCAPSULATION IMPLEMENTATION **********
            Person obj = new Person();
            obj.SetAge(11);
            obj.GetAge();
            obj.SetPersonName("itachi");
            obj.GetPersonName();


            //     ********* PROTECTED ACCESS MODIFIERS *********

           /* Derived obj = new Derived();

            obj.Access();*/

            /*DerivedClass derivedObj = new DerivedClass();
            derivedObj.AccessProtectedMember();

            PvtMembers pvt_obj = new PvtMembers();
            Console.WriteLine(pvt_obj.ShowVariable());
            pvt_obj.ShowMethod();*/




            //  *********** POLYMORPHISM ***********

            /* Polymorphism methodOverloading = new Polymorphism();
             Console.WriteLine(methodOverloading.sum(28, 16));
             Console.WriteLine(methodOverloading.sum(20.9, 21.7));*/

            /*Polymorphism methodOverriding = new Polymorphism();
            methodOverriding.Dynamic_Polymorphism();*/




            //      ********    IENUMERABLE ***********

            /*IEnumerable<int> customCollection;
            customCollection = GetCollection(1);

            Console.WriteLine("This was List<int>");

            foreach (int number in customCollection)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine("");

            customCollection = GetCollection(2);
            Console.WriteLine("it's Queue<int>");

            foreach (int number in customCollection)
            {
                Console.Write(number + " ");
            }

            customCollection = GetCollection(4);
            Console.WriteLine("\nthis is an array ");

            foreach (int number in customCollection)
            {
                Console.Write(number + " ");
            }*/




            //      **********IENUMERATOR*********

            /*List<string> Months = new List<string>();
            Months.Add("January");
            Months.Add("February");
            Months.Add("March");
            Months.Add("April");
            Months.Add("May");
            Months.Add("June");
            Months.Add("July");
            Months.Add("August");
            Months.Add("September");
            Months.Add("October");
            Months.Add("November");
            Months.Add("December");

            IEnumerator<string> iEnumeratorOfString = Months.GetEnumerator();
            iEnumeratorMethodOne(iEnumeratorOfString);*/



            //  ************ SEALED KEYWORD ***********
            /*SealedClass sealedObj = new SealedClass();
            Console.WriteLine(sealedObj.Calculate(7,2));

            Printer  pObj = new Printer();
            pObj.Show();
            pObj.Print();
            LaserJet  laserjet = new LaserJet();
            laserjet.Show();
            laserjet.Print();
            Printer officejet = new OfficeJet();
            officejet.Show();
            officejet.Print();*/




            //      *************HAS A-RELATIONSHIPS**********
            /*Address address = new Address("hs-209", "Chandigarh", "Punjab"); 
            Employee emp = new Employee(1111, "Breet", address);
            emp.Display();
            Console.ReadKey();*/
        }



        /*static IEnumerable<int> GetCollection(int option)
        {

            List<int> numbersList = new List<int>() { 1, 2, 3, 4, 5 };
            Queue<int> numberQueue = new Queue<int>();
            numberQueue.Enqueue(7);
            numberQueue.Enqueue(9);
            numberQueue.Enqueue(11);
            numberQueue.Enqueue(13);
            numberQueue.Enqueue(15);
            numberQueue.Enqueue(17);

            if (option == 1)
            {
                return numbersList;
            }
            else if (option == 2)
            {
                return numberQueue;
            }
            else
            {
                return new int[] { 2, 4, 6, 8, 10, 12 };
            }*/



        /*static void iEnumeratorMethodOne(IEnumerator<string> index)
        {
            while(index.MoveNext())
            {
                Console.WriteLine(index.Current);

                if (index.Current == "November")
                    iEnumeratorMethodTwo(index);
            }
        }*/

        /*static void iEnumeratorMethodTwo(IEnumerator<string> index)
        {
            while(index.MoveNext())
            {
                Console.WriteLine(index.Current);
            }

        }*/

    }

   
        
 }