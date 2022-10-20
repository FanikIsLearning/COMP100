using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Same as the previous question but additionally displays the average 
 * of the numbers when the loop terminates. You will need a counter but not as a loop terminator. 
 */

namespace Q8_Sum2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Flag
            double sum = 0;
            bool stop = true;

            Console.Write("Please insert any number between 0 and 100 ");
            int input = Convert.ToInt32(Console.ReadLine()), counter = 0;

            do
            {
                if (input >= 0 && input <= 100)
                {
                    sum += input;
                    input ++;
                    counter ++;

                    double average = sum / counter;
                    Console.WriteLine($"{input-1} {sum}, the avearge is {average:F2} counter is {counter}");
                }
                else
                {
                    stop = false;
                }

            } while (stop);

        }
    }
}
