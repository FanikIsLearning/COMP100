using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//P:\NPERSH\COMP100\common

namespace ArrayPractice_A
{
    internal class Program
    {
        static char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
        static int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37 };
        static int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        static string[] poem = { "Mary", "had", "a", "little", "lamb" };
        static string[] obama = { "Barack", "Hussein", "Obama" };

        static void Main(string[] args)
        {
            //PrintObama();
            //PrintReversedStringArray();
            //PrintStringAsCharArray("The quick brown fox jumps over the lazy dog.", '+');
            //forEach();
            BinarySearch();
        }
        #region Quesiton 1
        /*
         * 1.	Write a method that prints the string array obama. 
         * Each element must be on a separate line.
         * 
         * From your main, call this method. 
         * [Your method will not take any parameters and it does not return a value.]
         */
        static void PrintObama()
        {
            for (int i = 0; i < obama.Length; i++)
            {
                Console.WriteLine(obama[i]);
            }
            /*int index = 0;
            do
            {
                Console.WriteLine(obama[index]);
                index++;
            } while (index < obama.Length);*/
        }
        #endregion

        #region Quesiton 2
        /*
         * 2.	Write a method that prints the string array poem in reverse order. 
         * All the items must be in the same line. Your method will not take any parameters and it does not return a value.
         * From your main, call this method. 
         */
        static void PrintReversedStringArray()
        {
            int i = poem.Length; //????
            while (i > 0)
            {
                i--;
                Console.Write($"{poem[i]}, ");   
            }
          
        }
        #endregion

        #region Quesiton 10
        /*
         * 10. Write a method with the following specifications:
         * name: PrintStringAsCharArray
         * argument: A string and a char. The first is a string to convert to char array. The second is a char that will 
         * separate each item of the converted first argument.
         * return: nothing
         * tasks:
         * a.	Use the ToCharArray() method to convert the first argument to an array
         * b.	Print each item of the above array separate by the second argument 
         * 
         * From your main method, call the PrintStringAsCharArray method several times.
         * using your own arguments.
         */
        static void PrintStringAsCharArray(string toPrint, char separator)
        {
            char[] charArray = toPrint.ToCharArray();
            for(int i = 0; i < charArray.Length; i++)
            {
                Console.Write($"{(int)charArray[i]}{separator}");
            }
        }
        #endregion

        #region forEach
        static void forEach()
        {
            int[] prime = { 2, 3, 5, 7, 11, 13, 17, 19 };

            /*for (int i = 0; i < prime.Length; i++)
            {

            }*/

            foreach (int i in prime)
            {
                Console.WriteLine($"{i}");
            }
        }
        #endregion

        #region BinarySearch()
        static void BinarySearch()
        {
            int[] numbers = { 3, 2, 6, 8, 1, 9, 2, 3, 4, 0 };

            Array.Sort(numbers);

            Console.WriteLine(Array.BinarySearch(numbers, 4)); // => 6
            Console.WriteLine(Array.BinarySearch(numbers, 2)); // => 2 or 3
            Console.WriteLine(Array.BinarySearch(numbers, 5)); // => a negative value;
        }
        #endregion

        #region

        #endregion
    }
}
