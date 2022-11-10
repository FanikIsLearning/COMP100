using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q5a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What kinds of rider are you (student/adult/senior)? ");
            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "student":
                    Console.WriteLine($"{input} pays $1.75");
                    break;

                case "adult":
                    Console.WriteLine($"{input} pays $3.75");
                    break;

                case "senior":
                    Console.WriteLine($"{input} pays $2.00");
                    break;
                default:
                    Console.WriteLine($"I am sorry I don't know of that class of riders");
                    break;
            }
        }
    }
}
