using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a single letter: ");
            char input = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"The letter {(char) input} corresponds to the number {(int) input}");
        }
    }
}
