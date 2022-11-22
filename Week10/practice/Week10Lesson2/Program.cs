using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10Lesson2
{
    internal class Program
    {
        static Random generator = new Random();
        static void Main(string[] args)
        {
            string[] names = "Dean Bart Luke Olaf Tess Sara Vida Sean Rita Hana Arya Curt Eden Fred Gina West Jack Kate Zuri Dave Toni Ruth Vera Brad Theo Xena Mark Neal Nick".Split();
            string[] pets = "dog cat gecko hamster chinchilla rabbit turtle snake newt hedgehog parrot buggie ferret gerbil mouse".Split();
            char[] letters = "dog cat hamster rabbit parrot buggie gerbil ".ToCharArray();


            PrintStringArray("ivan billy hello hi".Split());

            Console.WriteLine("\n\nPrinting the names array");
            PrintStringArray(names);
            
            
            Console.WriteLine("\n\nReversing the names array");
            Array.Reverse(names);
            PrintStringArray(names);

            Console.WriteLine("\n\nSorting the names array");
            Array.Sort(names);
            PrintStringArray(names);

            string toFind = "Nick";
            int position = Array.BinarySearch(names, toFind);
            Console.WriteLine($"\n\n{toFind} is a position {position}");

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"{i+1} {GenerateSentence(names, pets)}");
            }

        }
        #region Question 1
        /*
         * 1.	Write a method that takes a string array and displays each items on a single line separated by a single space.
         * From your main method do the following:
         * 
         * a.	Call this method with argument “names”. 
         * b.	Use the Array.Reverse() to reverse the names array
         * c.	Print the array
         * d.	Use the Array.Sort() to order the names array
         * e.	Print the array
         * f.	Use Array.BinarySearch() to find and print the position of “Nick”
         * g.	Comment the line in step d and repeat step f. Are you able to find “Nick”?
         */

        static void PrintStringArray(string[] toPrint)
        {
            foreach(string item in toPrint)
            {
                Console.Write($"{item} ");
            }
        }
        #endregion

        #region Question 3
        /*
         * 3.	Write a method that takes two arguments. 
         * The first argument is a string array representing four-letter names. 
         * The second argument is a string array representing pets. 
         * The method will generate and return a string of the form 
         * “Hi I am Dean, I have a dog that is 15 months old”. 
         * The owner’s name is a random element from the first argument, 
         * the pet is a random element from the second argument and the age is a random value in the range 10-20.
         * From your main, call this 20 times method with arguments names and pets. 
         * 
         */

        /*
         Type "#help" for more information.
        Random generator = new Random();
        generator.Next();
        generator.Next()
        425933237
        generator.Next()
        1959820524
        int.MaxValue
        2147483647
        generator.Next(10, 20)
        16
        generator.NextDouble()
        0.77771564097037338
         */

        static string GenerateSentence(string[] owners, string[] pets)
        {
            
            int randomOwnerPosition = generator.Next(owners.Length);
            string owner = owners[randomOwnerPosition];

            int randomPetPosition = generator.Next(pets.Length);
            string pet = pets[randomPetPosition];

            int age = generator.Next(10, 20);

            return $"Hi I am {owner}, I have a {pet} that is {age} months old";
        }

        #endregion

    }
}
