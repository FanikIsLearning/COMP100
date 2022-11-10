using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q4b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the amount of your purchase: ");
            double input = Convert.ToDouble(Console.ReadLine());
            double rate = 0.1;

            if (input <= 100)
            {
                double tarif = 0 * rate;
                double sum = input + tarif;
                Console.WriteLine($"Cost: {input:c}, tarif: {tarif:c} so you pay: {sum:c}");
            }
            else
            {
                double tarif = input * rate;
                double sum = input + tarif;
                Console.WriteLine($"Cost: {input:c}, tarif: {tarif:c} so you pay: {sum:c}");

            }

        }
    }
}
