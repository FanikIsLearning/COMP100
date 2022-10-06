using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program that prompts the user for a menu choice. 
 * The program will display a message based on the following table:
 * Choice 1 = "Calculate Method"
 * Choice 2 = "Calculate Volume"
 * Choice 3 = "Calculate surface area"
 * Choice 0 = "Exit the program"
 * <<any other input>> = "ERROR: Invalid choice"
 * If the user responds with a 1 after the program prompt, the program will display "Calculate area".Etc.
*/

namespace Q2_Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("------------------------------------------\n");
            Console.Write("|Choice          |Message                |\n");
            Console.Write("|1               |Calculate area         |\n");
            Console.Write("|2               |Calculate volume       |\n");
            Console.Write("|3               |Calculate surface area |\n");
            Console.Write("|0               |Exit the program       |\n");
            Console.Write("|any other input |ERROR: Invalid choice  |\n");
            Console.Write("------------------------------------------\n");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 0:
                    Console.WriteLine("Exit the program");
                    Console.ReadLine();
                    break;
                case 1:
                    Console.WriteLine("Calculate area");
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Calculate volume");
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Calculate surface area");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("ERROR: Invalid choice");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
