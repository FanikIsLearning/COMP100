using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program that allows the user to enter two integers and a character 
 * If the character is A, add the two integers
 * If it is S, subtract the second integer from 
 * the first else multiply the integers
 * Display the results of the arithmetic
*/

namespace Q3_SimpleCal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter only 'A' or 'S': ");
            char letter = Convert.ToChar(Console.ReadLine());

            switch (letter)
            {
                case 'A':
                    int sum = first + second;
                    Console.WriteLine($"the sum is {sum}");
                    Console.ReadLine();
                    break;
                case 'S':
                    int substraction = first - second;
                    Console.WriteLine($"the substraciton is {substraction}");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("ERROR: Invalid option");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
