using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5_IQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your IQ score: ");
            int score = Convert.ToInt32(Console.ReadLine());

            if(score > 0 && score < 200)
            {
                if (score < 100) //below average
                {
                    Console.WriteLine($"{score} is below average");
                }
                else //average and above
                {
                    if ( score == 100)
                    {
                        Console.WriteLine($"{score} is average");
                    }
                    else
                    {
                        Console.WriteLine($"{score} is above average");
                    }
                }
            }
            else
            {
                Console.WriteLine($"{score} is an invalid scores");
            }
        }
    }
}
