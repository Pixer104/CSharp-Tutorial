using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//in most of the cases it's recomended to use Generic Collections because it
//performs faster than non-generic collections and also minimize exception by giving compile time error.
namespace Fundamentals.Collections
{
    public class CollectionPractice
    {
        //ArrayList - contain multiple null and duplicate value
        public void Arraylist()
        {
            //var arrlist = new ArrayList(100); //of size 100
            Console.WriteLine("Array list 1");
            var arlist = new ArrayList();
            arlist.Add(1);
            arlist.Add("Bill");
            arlist.Add(" ");
            arlist.Add(true);
            arlist.Add(7.14);
            arlist.Add(null);

            foreach (var item in arlist)
            {
                Console.Write(item + ", ");
            }

            arlist.RemoveRange(1, 2);

            foreach (var item in arlist)
            {
                Console.Write(item + ", ");
            }

            //adding elements using object initializer
            Console.WriteLine("\nArray list 2");
            var arrlist2 = new ArrayList()
            {
                2, "Steve", " ", 'p', true, 4.5, null
            };

            foreach (var elements in arrlist2)
            {
                Console.Write(elements + ", ");
            }

            //Adding entire array/arrayList into arraylist
            Console.WriteLine("\nArray list 3");
            var arrlist3 = new ArrayList();
            int[] arr = { 100, 200, 300, 400 };
            //arrlist3.AddRange(arrlist2);
            arrlist3.AddRange(arr);

            for (int i = 0; i < arrlist3.Count; i++)
            {
                Console.Write(arrlist3[i] + ", ");
            }
            arrlist3.Insert(2, 500);
            arrlist3.Insert(3, 600);
            arrlist3.Insert(4, 700);
            arrlist3.Insert(5, 800);
            //arrlist3.InsertRange(2 , arrlist2); //add collection st specific index
            for (int i = 0; i < arrlist3.Count; i++)
            {
                Console.Write(arrlist3[i] + ", ");
            }

        }

        //List - it's the generic version of ArrayList
        public void ListCollection()
        {
            Console.WriteLine("\nList Collection");
            List<int> numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(3);
            numbers.Add(5);
            numbers.Add(7);

            numbers.Remove(1);

            numbers.Insert(1, 2); //insert 2 at 1st index
            foreach (var item in numbers)
            {
                Console.Write(item + ", ");
            }

            var bigCities = new List<string>()
            {
                "New York",
                "London",
                "Mumbai",
                "Chicago"
            };

        }

        public void HashTables()
        {
            Console.WriteLine("\nStudents Data");
            Hashtable studentsTable = new Hashtable();
            Student stud1 = new Student(1, "Minato", 98);
            Student stud2 = new Student(2, "Pain", 76);
            Student stud3 = new Student(3, "Jiraya", 89);
            Student stud4 = new Student(4, "Naruto", 69);
            Student stud5 = new Student(5, "Itachi", 81);

            studentsTable.Add(stud1.Id, stud1);
            studentsTable.Add(stud2.Id, stud2);
            studentsTable.Add(stud3.Id, stud3);
            studentsTable.Add(stud4.Id, stud4);
            studentsTable.Add(stud5.Id, stud5);

            foreach (DictionaryEntry data in studentsTable)
            {
                Student temp = (Student)data.Value;
                Console.WriteLine("Student ID:{0}", temp.Id);
                Console.WriteLine("Student Name:{0}", temp.Name);
                Console.WriteLine("Student GPA:{0}", temp.GPA);
            }

        }


        //Dictionary - Generic version of hashtable
        public void DictionaryImplementation()
        {
            Console.WriteLine("\nDictionary Implementation\n" +
                "using foreach loop");

            Dictionary<int, string> dict1 = new Dictionary<int, string>();
            dict1.Add(11, "Welcome");
            dict1.Add(22, "to the");
            dict1.Add(33, "World of");
            dict1.Add(44, "Anime");

            dict1[55] = "Naruto Shipuden";
            dict1[66] = "Demonslayer";
            dict1.Add(77, "Chainsawmen");
            dict1[77] = "One Piece";
            foreach (KeyValuePair<int, string> elements in dict1)
            {
                Console.WriteLine("Key: {0}, Value: {1}", elements.Key, elements.Value);
            }

            Console.WriteLine("\nusing For loop");

            var cities = new Dictionary<string, string>()
            {
                {"UK" , "London, Birmingham, Manchester" },
                {"USA", "Chicago , New York, Washington" },
                {"India", "Mumbai, New Delhi, Pune" }
            };

            cities["UK"] = "Liverpool , Bristol";
            cities["USA"] = "Los Angeles, Boston, Houston";
            cities.Remove("UK");
            for (int i = 0; i < cities.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                    cities.ElementAt(i).Key, cities.ElementAt(i).Value);
            }

        }


        //STACK - stores element in LIFO style
        public void StackImplementation()
        {
            Console.Write("\nStack Implementation\n");
            Stack<int> numbers = new Stack<int>();
            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);
            numbers.Push(4);
            numbers.Push(5);
            numbers.Push(6);

            foreach (var item in numbers)
                Console.Write(item + ",");

            /*Console.WriteLine("\nstack after popped\n");
            while (numbers.Count > 0) 
            {
                Console.Write(numbers.Pop() + ",");
            }
            Console.Write("\nNumber of elements in stack: {0}", numbers.Count);*/

            if (numbers.Count > 0)
            {
                Console.WriteLine("Peek element is: " + numbers.Peek());
            }
            Console.Write("Number of elements in Stack: {0}", numbers.Count);

            numbers.Contains(8);


            /* int[] arr = new int[] { 1, 2, 3, 4 };
             Stack<int> naturalNumbers = new Stack<int>(arr);
             }*/

        }

        public void QueueImplementaion()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Queue Implementation");

            Queue<string> bestAnimes = new Queue<string>();
            bestAnimes.Enqueue("Naruto");
            bestAnimes.Enqueue("Demonslayer");
            bestAnimes.Enqueue("One Punch Man");
            bestAnimes.Enqueue("One Piece");
            bestAnimes.Enqueue("DeathNote");
            bestAnimes.Enqueue("ChainSaw men");

            /*foreach (var series in bestAnimes)
            {
                Console.WriteLine(series);
            }*/

            //bestAnimes.Dequeue();//remove the first element

            Console.WriteLine("Total elements: {0}", bestAnimes.Count);
            /* while(bestAnimes.Count > 0) 
             {
                 Console.WriteLine(bestAnimes.Dequeue());
             }

             Console.WriteLine("\nAfter Deque");
             Console.WriteLine("Total elements: {0}", bestAnimes.Count);*/

            if (bestAnimes.Count > 0)
            {
                Console.WriteLine("peek element is: {0}", bestAnimes.Peek());

            }
            Console.WriteLine("Total elements: {0}", bestAnimes.Count);



        }
    }

    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }

        public Student(int id, string name, float GPA)
        {
            Id = id;
            Name = name;
            this.GPA = GPA;
        }
    }
}
