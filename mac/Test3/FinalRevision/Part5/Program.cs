using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 5 12  8  5  7  3  5  6  9 10 16  8 11 34  9 50 12 14 45 */
            int[] ints = { 5, 12, 8, 5, 7, 3, 5, 6, 9, 10, 16, 8, 11, 34, 9, 50, 12, 14, 45 };
            #region Q1
            DisplayIntArray(ints);
            #endregion

            #region Q2
            Question2();
            #endregion

            #region Q3
            int[] EvenOddarray = GenerateRandomIntArray(10, 100);
            Console.Write("Array that is passed to find Even and Odd value is:");
            DisplayIntArray(EvenOddarray);
            int[] resultEvenOdd = CountEvenOdd(EvenOddarray);
            Console.WriteLine("***********************************************");
            Console.WriteLine();
            Console.WriteLine("Resulting array of FineEvenOdd method is : ");
            DisplayIntArray(resultEvenOdd);
            #endregion
        }

        #region Q1 DisplayIntArray(int[] numbers)
        /*
         * 1.	Write a method with header static void DisplayIntArray(int[] numbers). 
         * The first argument is an array of ints. 
         * There is no return value. 
         * This method displays all the elements of the argument on a single line. 
         * Each item will occupy three columns.
         * Call this method from main with a suitable argument.
         */
        static void DisplayIntArray(int[] numbers)
        {
            foreach (int num in numbers)
            {
                Console.Write($" {num} ");
            }
            Console.WriteLine();
        }
        #endregion

        #region Q2 
        /*
         * 2.	Write a method with header static int[] GenerateRandomIntArray(int numberOfItems, int largestValue). 
         * The first argument is an int indicating the number of elements that will be present in the return array. 
         * The second argument is an int representing the largest item in the array. 
         * The returned value is an array of integers. This method does the following:
         * a.	Declare and initialized a variable of type Random (Random generator = new Random();)
         * b.	Declare an array of type int (you may call it result)
         * c.	Allocate storage for the correct number of items
         * d.	Using your favorite looping statement, assign a random integer to each element of the array 
         * (result[i] = generator.Next(largestValue);)
         * In your main method, call the above method three times with arguments 15, 10 and 25, 10 and 30, 100. 
         * In each case assignment the results to a suitable variable and use the DisplayIntArray() method to display the value.
         */
        static int[] GenerateRandomIntArray(int numberOfItems, int largestValue)
        {
            Random generator = new Random();
            int[] result = new int[numberOfItems];
            for (int i = 0; i < numberOfItems; i++)
            {
                result[i] = generator.Next(largestValue);
            }
            return result;
        }

        private static void Question2()
        {
            DisplayIntArray(GenerateRandomIntArray(10, 15));
            Console.WriteLine();
            DisplayIntArray(GenerateRandomIntArray(25, 10));
            Console.WriteLine();
            DisplayIntArray(GenerateRandomIntArray(30, 100));
            Console.WriteLine();
        }
        #endregion

        #region Q3
        /*
         * 3.	Write a method with header static int[] CountEvenOdd(int[] array). The argument is an int array. The returned value is an array of 2 integers. 
         * The elements of the return array will be a count of the odd and even items in the argument. 
         * The first element of the returned array represents the number of odds in the argument and the second element indicates the number of evens in the argument.
         * The method will create an int array of 2 elements (call this the result). 
         * Each item of the argument is examined and the appropriate element of the result array is incremented. 
         * In your main method, call the GenerateRandomIntArray() method to create an int array using and assign it to a suitable variable. 
         * Using the DisplayIntArray() method display all the item of the return. 
         * Call the CountEvenOdd() method passing the above array as an argument and display the return value. 
         * Do a count to verify that your method is working correctly.
         */

         static int[] CountEvenOdd(int[] array)
         {
            int[] result = new int[2];
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    result[1] = result[1] + array[i];
                }
                else
                {
                    result[0] = result[0] + array[i];
                }
            }
            return result;
        }
        #endregion
    }
}