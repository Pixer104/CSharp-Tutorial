namespace Fundamentals.Arrays
{
    public class ArrayPractice
    {

        public void SingleDarray()
        {
            //string[] weekdays = new string[7] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            string[] weekdays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            Array.Sort(weekdays);
            //Console.WriteLine(weekdays[4]);
            string[] cars = { "Lamborghini", "BMW", "FORD", "Mustang", "Bugati" };
            Array.Sort(cars);

            //for loop will executes a block of statement untill the given condition get false
            Console.WriteLine("\nusing for loop");
            for (int i = 0; i < cars.Length; i++)
            {
                Console.Write(cars[i] + " ");
            }

            //for - foreach loop to get executed we don't neeed to define max or min limit, it'll executes block of statements for each element
            Console.WriteLine("\nusing foreach loop");

            foreach (string days in weekdays)
            {
                Console.Write(days + " ");
            }

        }

        public void MultiDArray()
        {
            // 2D-ARRAY initialization and DECLARATION

            int[,] array2D1 = new int[4, 2] // custom sized array
            {
            { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }
            };

            int[,] array2D =
            {
                {1,2,3},
                {5,6,7},
                {9,10,11}
            };

            foreach (int numbers in array2D)
            {
                Console.Write(numbers + " ");
            }

            Console.WriteLine("\n Using nested for loop");

            /*for(int rows=0; rows<array2D.GetLength(0); rows++)
            {
                for(int cols=2; cols<array2D.GetLength(1); cols--)
                {
                    //print diagonal elements of matrix from top left 

                    if (rows == cols)
                        //array2D[rows , cols] = 1;
                        Console.Write(array2D[rows, cols] + " ");

                    else
                        Console.Write(" ");

                }
                Console.WriteLine("");
            }*/


            //print diagonal elements from top right corner of matrix
            for (int rows = 0, cols = 2; rows < array2D.GetLength(0); rows++, cols--)
            {
                Console.WriteLine(array2D[rows, cols]);
            }

        }


        //JAGGED ARRAY - array of array where length of aech array index can be different
        public void JaggedArray()
        {
            //INIRIALIZATION and DECLARATION
            int[][] jaggedArray1 = new int[4][]; //here the number of rows are known
            jaggedArray1[0] = new int[] { 1, 2, 3 };
            jaggedArray1[1] = new int[] { 6, 7, 8, 9 };
            jaggedArray1[2] = new int[] { 10, 11, 12, 13 };
            jaggedArray1[3] = new int[] { 15, 17 };

            Console.WriteLine($"jaggedArray1[2][1] value is: {jaggedArray1[2][1]}");
            Console.ReadLine();

            int[][] jaggedArray2 = new int[][]//here rows isn't known 
            {
                new int[] { 1, 2, 3, 4, 6 },
                new int[]{5, 7, 9},
                new int[]{10,11,12},
                new int[] {13,15,16,17,18,19,20},
            };


            Console.WriteLine($"jaggedArray2[1][1] value is: {jaggedArray2[1][1]}");
            Console.ReadLine();

            int[][,] jaggedArray3 = new int[3][,] //when to include 2-d array inside jagged array
            {
                new int[,] { { 1, 2, 3,4},{ 67,68,31,21} },
                new int[,] { {0,2},{4,6} },
                new int[,] { {11,22,33}, {99,88,77}, {0,9,19} }
            };

            Console.WriteLine("JaggedAaaray1 size is: " + jaggedArray1.Length);
            Console.WriteLine("JaggedAaaray2 size is: " + jaggedArray2.Length);
            Console.WriteLine("JaggedAaaray3 size is: " + jaggedArray3.Length);

        }

        public double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double sum = 0;
            double average;

            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }
            average = sum / size;
            return average;
        }

        public void ParamsMethod(params int[] list)
        {
            int[] myIntArray = { 1, 3, 4, 6, 8, 9, 11, 13 };
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }

        public void ParamsMethod2(params object[] list)
        {
            object[] myObjArray = { 1, 2, 4 + 4, 8, 9, 'b', 'd', "we", "can", "include", "as", "many", "arguments", "we", "want", "test", "okay", "again" };

            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
        }




    }

}
