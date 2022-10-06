using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program for a furniture company. Ask the user to choose Pine, Oak or Mahogany. 
 * Show the price of a table manufactured with the chosen wood Pine tables cost $100, Oak 
 * tables cost $225, and Mahogany tables cost $310. You must use named constants and switch. 
 * Also you must be able to accept any variation on the case. E.g. Pine, pine PINE, pinE, Pine … 
 * should give $100.
*/

namespace Q6_Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Choose Pine, Oak or Mahogany: ");
            string type = Console.ReadLine();


            switch (type.ToLower())
            {
                case "pine":
                    Console.WriteLine($"Pine tables cost $100");
                    Console.ReadLine();
                    break;
                case "oak":
                    Console.WriteLine($"Oak tables cost $225");
                    Console.ReadLine();
                    break;
                case "mahogany":
                    Console.WriteLine($"Mahogany tables cost $310");
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
