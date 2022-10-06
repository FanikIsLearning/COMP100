using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a console-based program that accepts a user’s message and determines 
 * whether it is short enough for a social networking service that does not accept 
 * messages of more than 140 characters. 
 * 
 * [Hint: if the user’s input is assigned to the variable message then
 *  message.Length will automatically give you the number of characters in the variable message]
 */

namespace Q4_Length
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the message: ");
            string message = Console.ReadLine();
            int length = message.Length;

            if (length > 140)
            {
                Console.WriteLine("ERROR! your characters is more than 140");
            }
            else
            {
                Console.WriteLine(message);
            }
            Console.ReadLine();
        }
    }
}
