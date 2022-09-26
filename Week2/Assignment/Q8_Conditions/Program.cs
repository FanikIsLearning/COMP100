using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program that prompts the user for a number (that may be a fraction). 
 * The program reads in the input and print the following: the input as a double, 
 * the input as an int and finally the input as a char.
 * e.g. if the input is 65.790, then the output will be 65.790, 65, and A.
 */

namespace Q8_Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert a number: ");
            double input = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"the output will be {input:F3}, {(int)input}, and {(char)input}.");
            Console.ReadLine();
        }
    }
}
