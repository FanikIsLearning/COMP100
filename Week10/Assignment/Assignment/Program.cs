using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Program
    {

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
            int position = Array.BinarySearch(numbers, findThree);
            Console.WriteLine($"\n\nQ6. The position of '3' is {position}");
            Console.WriteLine("\nQ6. the sort intArray:");
            Array.Sort(numbers);
            printIntArray(numbers);
            //int position1 = Array.BinarySearch(numbers, findThree);
            //Console.WriteLine($"\n\nQ6. The position of '3' is {position1}");

            /* question7 */
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
         * Write a method that creates and return an array of ints. 
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
        #endregion
    }
}
