using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your average monthly bill:");
            double bill = Convert.ToDouble(Console.ReadLine());

            double annualBill = bill * 12;

            Console.WriteLine($"Hi {name}, your annual visa bill is {annualBill:c}");
        }
    }
}
