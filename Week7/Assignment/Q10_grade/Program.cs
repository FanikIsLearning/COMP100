using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a C program that continuously requests a grade. 
 * If the grade is less than 0 or greater than 100, your program 
 * should print an appropriate message informing the user that an invalid grade has been entered, 
 * else the grade should be added to a total. 
 * 
 * If the grade is 999, the program should exit the loop and display the sum, number of valid 
 * grades and the average of the valid grades entered. (You must NOT display an invalid 
 * message)
 * P.S. The value 999 is use to terminate the cycle and should not be used in any of the 
 * calculation. You must not display an “Invalid grade”
 */

namespace Q10_grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 0;
            bool stop = true;

            while (stop)
            {
                Console.Write("Enter number 0-100: ");
                int grade = Convert.ToInt32(Console.ReadLine());

                if (grade < 0 || grade > 100)
                {
                    Console.WriteLine($"an invalid grade has been entered {grade} ");
                    continue;
                }
                else if (start >= 999)
                {
                    stop = false;
                }
                else
                {
                    start += grade;
                    Console.WriteLine($"{start}");
                }
            };
        }
    }
}
