using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q3e
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a letter: ");
            char input = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"The letter {(char)input} corresponds to the number {(double)input:f2}");
        }
    }
}
