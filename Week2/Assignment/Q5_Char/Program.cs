﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Write a program to prompt the user to enter a single character. 
 * The program should display a message like “Your response was y”. 
 * For this question, you must use a variable of type char.
 */

namespace Q5_Char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any character here: ");
            char input = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"Your response was {input}");
            Console.ReadLine();
        }
    }
}
