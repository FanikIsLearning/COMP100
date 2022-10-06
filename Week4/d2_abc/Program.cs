using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d2_abc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            char letter = Convert.ToChar(Console.ReadLine());

            switch (letter)
            {
                case 'A':
                    Console.WriteLine("Apple");
                    break;
                case 'B':
                case 'C':
                    Console.WriteLine("I love candy!");
                        break;
                    default:
                    Console.WriteLine("I don't know that letter");
                    break;
            }
        }
    }
}
