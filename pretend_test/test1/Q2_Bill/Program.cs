using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Write a program that prompts the user for his name and average monthly 
 * visa bill. The program displays his name and his annual visa bill.
 * You must match the format exactly.
 */

namespace Q2a_Bill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            Console.Write("How much is your visa bill monthly?");
            double monthlyBill = Convert.ToDouble(Console.ReadLine());

            double yearlyBill = monthlyBill * 12;

            Console.WriteLine($"{name} has to pay an annual visa bill {yearlyBill:C}");
            Console.ReadLine();
        }
    }
}
