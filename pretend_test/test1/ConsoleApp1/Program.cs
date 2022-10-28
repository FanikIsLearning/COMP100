using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Write a program that displays the name and address of your college. 
 * You must match the format exactly.
 */

namespace Q1a_Name
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name = "FAN HOI KIT";
            string address = "941 Progress Ave, Scarborough, ON M1G 3T8";

            Console.WriteLine($"My name is {name} and the address of my college is {address}.");
            Console.ReadLine();
        }
    }
}
