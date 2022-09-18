using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Write a program to prompt and accept a  grocery item, 
 * price and quantity. The program will calculate and display the total cost.
 * 
 * Sample calculation:
 *  cost = price * quantity
 *  cost = .25*7=1.75
 */

namespace GroceryCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
     
            Console.Write("What item would you like to buy? ");
            string name = Console.ReadLine();

            Console.Write($"How many {name} would like to buy? ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.Write($"What is the price of a {name}? ");
            double price = Convert.ToDouble(Console.ReadLine());

            double cost = quantity * price;

            Console.WriteLine($"The cost of {quantity} {name}(s) @{price:C} will be {cost:C}");
            Console.ReadLine();
        }
    }
}