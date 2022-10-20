﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a program that prompts the user for her home planet. Based on the
 * user's input the program will display the following:
 * 
 * Input: earth
 * Message: earth! You are an Earthling and you have 10 fingers
 * 
 * Input: VENUS
 * Message: VENUS! You are a Venusian and you have 12 fingers
 * 
 * Input: Mars
 * Message: Mars! You are a Martian and you have 8 fingers
 * 
 * any other input (e.g. Pluto)
 * Message: Pluto! I am sorry I don't know of that planet
 * 
 * You may use either the ToUpper() or ToLower() methods 
 * 
 * You MUST USE ONLY A SWITCH statement to solve this problem
 * [For full marks you need to accept all permutations of earth, venus 
 * and mars]
 */

namespace ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your home planet: ");
            string input = Console.ReadLine();

            switch(input.ToLower())
            {
                case "earth":
                    Console.WriteLine($"{input}! You are an Earthling and you have 10 fingers");
                    break;
  
                case "venus":
                    Console.WriteLine($"{input}! You are a Venusian and you have 12 fingers");
                    break;
    
                case "mars":
                    Console.WriteLine($"{input}! You are a Martian and you have 8 fingers");
                    break;
       

                default:
                    Console.WriteLine($"{input}! I am sorry I don't know of that planet ");
             
                    break;
            }
        }
    }
}
