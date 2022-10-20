using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

/*
 * To display the sum of all the multiples of 3 between 1000000 and 2000000. 
 *  (Answer = 499, 999, 500, 000). If you suspect that a value might be larger than 2 billion 
 *  (as is the case here), then the type of sum should be a long and not an int. 
 *  [Hint: like the C (currency) and the F (decimal) format specifiers, there is also a N specifier]
 */

namespace Q9_3Multiples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 1000000, stop = 2000000;
            long sum = 0;

            do
            {
                if (start % 3 == 0)
                {
                    sum += start;
                    Console.WriteLine($"the sum of multiple of 3 between {start} and {stop} is {sum:N}");
                }
                start++;

            } while (start <= stop);

        }
    }
}
