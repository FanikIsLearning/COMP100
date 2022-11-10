using System;

namespace q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int COLS = 8, ROWS = 3;

            for (int row = 0; row < ROWS; row++)
            {
                for (int col = 0; col < COLS; col++)
                {
                    Console.Write($"*");
                }
                Console.WriteLine();
            }
        }
    }
}
