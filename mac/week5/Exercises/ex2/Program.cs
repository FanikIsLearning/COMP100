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
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your average: ");
            double monthlyBill = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Hi {name}, your annual visa bill will be {(monthlyBill * 12):c2}");
        }
    }
}
