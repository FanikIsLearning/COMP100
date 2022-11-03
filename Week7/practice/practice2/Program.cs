using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program to print the letters of the
 * alphabet on a single line.
 * 
 * The user will specify the start letter.
 * 
 */

namespace practice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char start;
            const char END = 'Z';

            Console.Write("Enter the start letter: ");
            start = Convert.ToChar(Console.ReadLine());

            while (start <= END)
            {
                Console.WriteLine($"{start} {(int)start}");
                start++;
            }

            /*
            for (; start <= END ; start++)
            {
                Console.WriteLine($"{start} {(int)start}");
            }
            */
        }
    }
}
