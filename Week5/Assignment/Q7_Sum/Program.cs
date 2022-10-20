using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * To repeatedly prompt for a number and sum it. 
 * When the sum just exceeds 100, stop the prompting and display the sum at the end. 
 * You must not display the sum while the user in typing in numbers.  
 * (You do not need a counter but you will need some way of terminating the loop)
 */


namespace Q7_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Accumlator
            int sum = 0;
            const int stop = 100;
            Console.Write("Please insert any number between 0 and 100 ");
            int number = Convert.ToInt32(Console.ReadLine());
            do
            {
                sum = sum + number;
                number = number + 1;

                Console.WriteLine($"{number-1} {sum}");
                    
            } while (number <= stop);

        }
    }
}
