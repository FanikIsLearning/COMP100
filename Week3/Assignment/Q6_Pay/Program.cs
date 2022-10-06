using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a console-based program that prompts the user for an hourly pay rate and hours worked. 
 * Compute gross pay (hours times pay rate), withholding tax, and net pay (gross pay minus 
 * withholding tax). Withholding tax is computed as a percentage of gross pay based on the following:
 * 
 * Gross Pay
 * Up to and including 300.00
 * More than 300.00
 * 
 * Withholding Percentage
 * 10%
 * 12%
 */

namespace Q6_Pay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many hours do you work? ");
            int workingHours = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is your hourly pay rate? ");
            double payRate = Convert.ToDouble(Console.ReadLine());

            double grossPay = payRate * workingHours;

            if (grossPay > 300)
            {
                double tax = grossPay * 0.12;
                double netPay = grossPay - tax;
                Console.WriteLine($"Your working hours are {workingHours}, withholding tax is {tax:F2}, gross pay is {grossPay:c}, and net pay is {netPay:c}");
            }
            else 
            {
                double tax = grossPay * 0.1;
                double netPay = grossPay - tax;
                Console.WriteLine($"Your working hours are {workingHours}, withholding tax is {tax:F2}, gross pay is {grossPay:c}, and net pay is {netPay:c}");
            }
            Console.ReadLine();

        }
    }
}
