using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Write a program to ask the user about the validity of a simple statement. 
 * The program should accept the response then display the statement as well as the response. 
 * The response should be true or false. For this question, you must use a variable of type bool. 
 * It is useful to know that Convert.ToBoolean() can work with true, True, tRue, TRUE etc.
 */

namespace Q6_boolean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Is C# a low-level language?");
          
            bool output = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine($"{output}");
            Console.ReadLine();
        }
    }
}


