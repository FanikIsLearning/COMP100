using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program that prompts the user for the number of courses and residency status 
 * (domestic or international) and calculates tuition cost. 
 * Cost is calculated based on the table below.
 * 
 * Domestic
 * $325 per course
 * 
 * International
 * $1375 per course
 * 
 * You decide how you want the user to enter her/his residency status and prompt accordingly, 
 * also you should use named constants for the cost per course
*/

namespace Q4_Residents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("International Student or Domestic Student? Please insert either 'Intnational' or 'Domestic' ");
            string type = Console.ReadLine();

            Console.Write("How many courses do you want? ");
            int course=Convert.ToInt32(Console.ReadLine());

            int intCost = course * 1375;
            int domCost = course * 325;

            switch (type.ToLower())
            {
                case "international":
                    Console.WriteLine($"the cost of {course} course(s) for international student is {intCost:C}");
                    Console.ReadLine();
                    break;
                case "domestic":
                    Console.WriteLine($"the cost of {course} course(s) for domestic student is {domCost:C}");
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
