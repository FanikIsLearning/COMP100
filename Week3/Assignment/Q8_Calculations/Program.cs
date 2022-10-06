using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that allows the user to enter two integers and a character 
 * If the character is A, add the two integers If it is S, 
 *  subtract the second integer from the first if it is M, 
 *  multiply the integers. Display the results of the arithmetic
 */

namespace Q8_Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first integer: ");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second integer:");
            int second = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 'A' or 'S' only: ");
            char command = Convert.ToChar(Console.ReadLine());

            if (command == 'A' || command == 'a')
            {
                int result = first + second;
                Console.WriteLine($"Your result is {result}");
            }
            else if (command == 'S' || command == 's')
            {
                int result = first - second;
                Console.WriteLine($"Your result is {result}");
            }

            Console.ReadLine();

        }
    }
}
