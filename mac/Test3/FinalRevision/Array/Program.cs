using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            char[] letters = "the quick brown fox jumps over the lazy dog".ToCharArray();
            int[] numbers = { 0, 2, 3, 5, 7, 1, 1, 2, 5, 6, 7, 2, 5, 2 };
            string[] poem = "mary had a little lamb its fleece was white as snow".Split();

            /* question4 */
            Console.WriteLine("\n\nQ4. the reverse charArray:");
            Array.Reverse(letters);
            printCharArray(letters);

            /* question5 */
            Console.WriteLine("\n\nQ5. the sort stringArray:");
            Array.Sort(poem);
            printStringArray(poem);

            /* question6 */
            int findThree = 3;
            //IT IS NOT WORKING IF IT IS NOT SORTED!!!!!!!!!!!!!!
            //int position = Array.BinarySearch(numbers, findThree); 
            //Console.WriteLine($"\n\nQ6. The position of '3' is {position}");
            Console.WriteLine("\n\nQ6. the sort intArray:");
            Array.Sort(numbers);
            printIntArray(numbers);
            int position1 = Array.BinarySearch(numbers, findThree);
            Console.WriteLine($"\n\nQ6. The position of '3' is {position1}");

            #region Q7

            Console.WriteLine("\nQ7. Display:");
            Console.Write("How many input? ");
            int limit = Convert.ToInt32(Console.ReadLine());
            int[] box = createIntArray(limit);
            Console.Write($"Display variable: ");
            for (int i = 0; i < box.Length; i++)
            {
                Console.Write($"{box[i]} ");
            }
            Console.WriteLine("");

            /*Console.WriteLine("Display variable : " + string.Join(",", createIntArray(limit)));*/
            #endregion

            /* question8 */
            Console.WriteLine("\nQ8. Random");
            Console.Write("How many input? ");
            int limit1 = Convert.ToInt32(Console.ReadLine());
            int[] box1 = createRandomIntArray(limit1);
            Console.Write($"Display variable: ");
            for (int i = 0; i < box1.Length; i++)
            {
                Console.Write($"{box1[i]} ");
            }
            Console.WriteLine("");
            /*Console.WriteLine("Display variable : " + string.Join(",", createIntArray(limit)));*/

        }

        #region printCharArray
        /*
         * 4. In your main method use the method in question 1 to display the letters array, then use the Array.Reverse() method 
         *  to reverse the letters array and then again call the appropriate method to print it
         */

        static void printCharArray(char[] print)
        {
            foreach (char i in print)
            {
                Console.Write($"{i} ");
            }
        }
        #endregion

        #region printStringArray
        /*
         * 5. In your main method use the method in question 3 to display the poem array, then use the Array.Sort() method 
         *  to sort the poem array and then again call the appropriate method to print it
         */
        static void printStringArray(string[] print)
        {
            foreach (string i in print)
            {
                Console.Write($"{i} ");
            }
        }
        #endregion

        #region printIntArray
        /*
         * 6. In your main method use the method in question 2 to display the numbers array, 
         * then use the Array.Binarysearch() method to try to find the position of 3 in the numbers array. What is your answer?
         * Now repeat the same steps after you have sorted the array and printed the sorted array
         */
        static void printIntArray(int[] print)
        {
            foreach (int i in print)
            {
                Console.Write($"{i} ");
            }
        }
        #endregion

        #region Question 7
        /*
         * 7. Write a method that creates and return an array of ints. 
         * The method takes a single int argument that represents the how many items will be in 
         * the resulting array and does the following:
         * •	Declare an array of the required type.
         * •	Allocate memory for the intended number of items.
         * •	Using any looping structure, prompt the user for a number and then assign to each element. 
         * •	Return the array after the loop.
         * In your main method do the following: 
         * (a) call this method (you will need to supply an argument), assign the resulting value to at suitable variable and then 
         * (b) display this variable.
         */

        static int[] createIntArray(int times)
        {
            int[] intArray = new int[times];
            for (int i = 0; i < times; i++)
            {
                Console.Write("Input numbers: ");
                int items = Convert.ToInt32(Console.ReadLine());
                intArray[i] = items;

            }
            return intArray;
        }
        #endregion

        #region Question 8
        /*
         * 8.	Write another method that creates and return an array of ints. 
         * The method takes a single argument that represents the number of items in the resulting array and does the following:
         * 
         * •	Declare an array of the required type.
         * •	Allocate memory for the intended number of items.
         * •	Using any looping structure, assign to each element a random integer in the range 100 to 200. 
         * •	Return the array.
         * You will need the following statement in global scope.
         * static Random rand = new Random();
         * The following statement will give you a random letter
         * rand.Next(100, 200);
         * Exercise this method in a similar fashion as you did for question 7
         */
        static int[] createRandomIntArray(int times)
        {
            int[] intArray = new int[times];
            for (int i = 0; i < times; i++)
            {
                int items = rand.Next(100, 200);
                intArray[i] = items;
            }
            return intArray;
        }

        #endregion
    }
}
