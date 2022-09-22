using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Write a program that prompts the user for two integers. 
 * The program will display the result of summing and finding the difference.
 * (If the user enters 8 and 3, the display should be 8 + 3 = 11 and 8 – 3 = 5).
 */

namespace Q3_Sum_And_Difference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enther the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;
            int difference = num1 - num2;

            Console.WriteLine($"{num1} + {num2} = {sum} and {num1} - {num2} = {difference}");
            Console.ReadLine();
        }
    }
}