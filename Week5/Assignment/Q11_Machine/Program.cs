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
 *  
 *                         END-OF-YEAR         ACCUMULATED
YEAR      DEPRECIATION        VALUE           DEPRECIATION
----      ------------      ------------      ------------
 1            4000            24000               4000
 2            4000            20000               8000
 3            4000            16000              12000
 4            4000            12000              16000
 5            4000             8000              20000
 6            4000             4000              24000
 7            4000                0              28000
 */

namespace Q11_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double machine = 28000, rate = 4000, ad = 0, stop = 0;
            int year = 0;
            Console.Write($"{" ", 6} {" ", 12} {"END-OF-YEAR", 15} {"ACCUMLATED", 16}\n");
            Console.Write($"{"YEAR",5} {"DEPRECIATION",15} {"VALUE",10} {"DEPRECIATION", 19}\n");
            Console.Write($"{"----",5} {"------------",15} {"-----------",14} {"------------", 15}\n");
            do
            {
                year++;
                ad += rate;
                machine -= rate;
                Console.Write($"{year, 3} {rate,13} {machine,14} {ad, 15}\n");
            } while (machine > stop);
            
        }
    }
}
