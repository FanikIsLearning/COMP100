using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

/*
 * Print the decimal, octal, and hexadecimal values of all characters between the start and stop 
 * characters entered by a user. For example, if the user enters an a and a z, the program should 
 * print all the characters between a and z and their respective numerical values. Make sure that
 * the second character entered by the user occurs later in the alphabet than the first character
 * If it does not, write a loop that repeatedly asks the user for a valid second character until one 
 * is entered.
 * Your output should be formatted as shown below
 * Letter	  Decimal	Octal	Hex
   a	        97	     141	 61
   b	        98	     142	 62
   c	        99	     143	 63
   d	       100	     144	 64
   e	       101	     145	 65
   
to obtain an int from a char use an explicit cast
to obtain an octal from an int use Convert.ToString(«number_value», 8)
to obtain a hexadecimal from an int use Convert.ToString(«number_value», 16)


 */

namespace Q11_convert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char start, end;
            bool stop = true;
            Console.Write("First: Insert a-z: ");
            start = Convert.ToChar(Console.ReadLine().ToLower());
            Console.Write("Second: Insert a-z: ");
            end = Convert.ToChar(Console.ReadLine().ToLower());

            while (stop)
            {
                if (start <= end)
                {
                    Console.WriteLine("Letter  Decimal  Octal  Hex");
                    for (; start <= end; start++)
                    {

                        string octal = Convert.ToString(start, 8);
                        string hex = Convert.ToString(start, 16);
                        Console.WriteLine($"{start,1} {(int)start,10} {octal,8} {hex,5}");
                    }
                    break;
                }
                else
                {
                    Console.Write("Error! Please insert a-z : ");
                    end = Convert.ToChar(Console.ReadLine().ToLower());
                }
            };
        }
    }
}
