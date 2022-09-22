using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
/*
 * Adult ticket cost $3.75 and child ticket cost $2.25. 
 * Write a program to prompt the user for the amount of adult and child ticket that she needs. 
 * The program will display a user-friendly message of the number of tickets brought as well as the total cost.
 * (Use the "C" format-string for currency).
 */

namespace Q9_Ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many adult ticket? ");
            int adult = Convert.ToInt32(Console.ReadLine());

            Console.Write("How many child ticket? ");
            int child = Convert.ToInt32(Console.ReadLine());

            double priceOfAdult = 3.75 * adult;
            double priceOfChild = 2.25 * child;

            Console.WriteLine($"The cost of {adult} adult ticket(s) is/are {priceOfAdult:C} and the cost of {child} adult ticket(s) is/are {priceOfChild:C}");
            Console.ReadLine();
        }
    }
}
