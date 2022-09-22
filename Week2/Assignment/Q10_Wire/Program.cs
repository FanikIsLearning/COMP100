using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
/*
 * Write a program to calculate and display the potential difference between the ends of a wire. 
 * The program will prompt the user for the current flowing and the resistance of the wire. 
 * Potential difference is the product of the current and 
 * the resistance of the wire and may include a fractional part.
 * (Again, use the "F" format-specifier for floating point values).
 */

namespace Q10_Wire
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the current flowing: ");
            double currentFlowing = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the resistance of the wire: ");
            double resistance = Convert.ToDouble(Console.ReadLine());

            double potentialDifference = currentFlowing * resistance;

            Console.WriteLine($"The potential difference between the ends of a wire is {potentialDifference:F2}");
            Console.ReadLine();
        }
    }
}
