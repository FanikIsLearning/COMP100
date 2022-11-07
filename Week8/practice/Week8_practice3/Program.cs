using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8_practice3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char end = 'i';
            int box = 0;
            for (int i = 0; i < 10; i++)
            { 
                for (char start = 'a'; start <= end; start++)
                {       
                    Console.Write($"{i}{start} ");
                }
                Console.WriteLine();
            }
        }
    }
}
