using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Harmonised tax exists in Ontario, New Brunswick, 
 * New Foundland, Nova Scotia, and British Columbia.
 *  Use a suitable e a switch statement to prompt 
 *  the user for a province and display a
 *  message HST exist or HST does not exist. 
 *  Possible province {ON, QC, NS, NB, MB, BC, PE, SK, AB, NL, YT, NT, NV} 
 */

namespace Q8_ON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter THE TWO LETTER PROVINCE CODE: ");
            string province = Console.ReadLine();

            switch (province.ToLower())
            {
                case "ON":
                    Console.WriteLine($"'{province}' HST exist!");
                    Console.ReadLine();
                    break;
                case "QC":
                case "NS":
                case "MB":
                case "BC":
                default:
                    Console.WriteLine($"In '{province}' HST does not exist");
                    Console.ReadLine();
                    break;

            }
        }
    }
}
