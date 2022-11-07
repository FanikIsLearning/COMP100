using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8_practice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char start = 'a';
            const char END = 'i';

            for (; start <= END; start++)
            {
                Console.Write($" {start}"); 
            }
        }
    }
}
