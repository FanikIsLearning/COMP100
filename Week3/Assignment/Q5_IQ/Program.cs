using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write an application that asks a user to enter an IQ score.
 * If the score is a number less than 0 or greater than 200,
 * issue an error message; otherwise, issue an “above average”,
 * “average”, or “below average” message for scores over, at, or under 100, respectively
 */



namespace Q5_IQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Check your IQ score: ");
            int iq = Convert.ToInt32(Console.ReadLine());

            if (iq < 0 || iq > 200)
            {
                Console.WriteLine($"the score is ERROR!");
            }
            else 
            { 
                if(iq > 100)
                {
                    Console.WriteLine("above average");
                }
                else if (iq == 100)
                {
                    Console.WriteLine("average");
                }
                else if (iq < 100)
                {
                    Console.WriteLine("below average");
                }
            }
            Console.ReadLine();
        }
    }
}
