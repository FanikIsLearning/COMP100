using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/*
 *  A machine purchased for $28,000 depreciates at a rate of $4,000 a year for seven years. Write 
 *  and run a C# program that computes and displays a depreciation table for seven years. The 
 *  32). Your table must have a suitable header and the values in the table must be right-align 
 *  table should have the form: 
 */

namespace Q11_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double machine = 28000, rate = 4000, ad = 0, stop = 0;
            int year = 0;
            Console.Write($"{" ",-6} {" ",-15} {"END-OF-YEAR",-15} {"ACCUMLATED", -13}\n");
            Console.Write($"{"YEAR",-6} {"DEPRECIATION",-18} {"VALUE",-11} {"DEPRECIATION", -13}\n");
            Console.Write($"{"----",-6} {"------------",-15} {"-----------",-14} {"------------", -13}\n");
            do
            {
                year++;
                ad += rate;
                machine -= rate;
                Console.Write($"{year, -8} {$"{rate:c0}", -15} {$"{machine:c0}",-14} {$"{ad:c0}", -13}\n");
            } while (machine > stop);
            
        }
    }
}
