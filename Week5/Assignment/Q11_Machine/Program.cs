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
            Console.Write(String.Format("{0,-7}{1,-16}{2,-16}{3,10}", "", "", "END-OF-YEAR", "ACCUMLATED\n"));
            Console.Write(String.Format("{0,-7}{1,-19}{2,-12}{3,10}", "YEAR", "DEPRECIATION","VALUE", "DEPRECIATION\n"));
            Console.Write(String.Format("{0,-7}{1,-16}{2,-15}{3,10}", "----", "------------", "-----------", "------------\n"));
            do
            {
                year++;
                ad += rate;
                machine -= rate;
                Console.Write(String.Format("{0,-7}{1,-16}{2,-15}{3,10}", $"{year}", $"{rate:c}", $"{machine:c}", $"{ad:c}\n"));
            } while (machine > stop);
            
        }
    }
}
