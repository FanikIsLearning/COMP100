using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2f
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter price: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter type: ");
            string type = Console.ReadLine();

            double cost = price * 25;

            Console.WriteLine($"The cost of 25 litres of {type} grade petrol will be {cost:c}");
        }
    }
}
