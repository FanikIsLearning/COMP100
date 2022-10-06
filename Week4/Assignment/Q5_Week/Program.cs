using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program that prompts the user for a day of the week. 
 * The program will display a message based on the following table:
 * 
 * Sun "Home"
 * Mon "Work"
 * Tue "Work"
 * Wed "Home"
 * Thu "Work"
 * Fri "Work"
 * Sat "Work"
*/

namespace Q5_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter 3 LETTERS for a day of the week: ");
            string week = Console.ReadLine();

            switch (week.ToLower())
            {
                case "sun":
                    Console.WriteLine("Home");
                    Console.ReadLine();
                    break;
                case "mon":
                    Console.WriteLine("Work");
                    Console.ReadLine();
                    break;
                case "tue":
                    Console.WriteLine("Work");
                    Console.ReadLine();
                    break;
                case "wed":
                    Console.WriteLine("Home");
                    Console.ReadLine();
                    break;
                case "thu":
                    Console.WriteLine("Work");
                    Console.ReadLine();
                    break;
                case "fri":
                    Console.WriteLine("Work");
                    Console.ReadLine();
                    break;
                case "sat":
                    Console.WriteLine("Work");
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
