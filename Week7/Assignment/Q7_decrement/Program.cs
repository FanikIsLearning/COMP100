using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a program to produce a table of numbers from 10 to 1, with their squares and cubes. Again, your table must look professional!
 */


namespace Q7_decrement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 10, end = 1;
            Console.WriteLine($"number   square   cubes");
            /*for (; start >= end; start--)
            {
                int square = start * start;
                int cubes = start * start * start;
                Console.WriteLine($" {start,3} {square,9} {cubes,8}");
            }
            */
            while ( start >= end )
            {
                int square = start * start;
                int cubes = start * start * start;
                Console.WriteLine($" {start,3} {square,9} {cubes,8}");
                start --;
            }

        }
    }
}
