using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of rows: ");
            int r = Convert.ToInt32(Console.ReadLine());

            Console.Write("Number of columns: ");
            int c = Convert.ToInt32(Console.ReadLine());

            for (int row = 0; row < r; row++)
            {
                for (int col = 0; col < c; col++)
                {
                    if (row % 5== 0 || col % 5 == 0)
                    {
                        Console.Write($"+");
                    }
                    else
                    {
                        Console.Write($" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
