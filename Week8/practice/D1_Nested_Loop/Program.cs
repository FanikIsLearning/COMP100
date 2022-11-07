using System;
/*
 
 */

namespace D1_Nested_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int COLS = 25, ROWS = 25;

            /*do
            {

                int col = 0;
                do
                {
                    Console.Write($"{row % 10}{col % 10} ");
                    col++;
                } while (col < COLS);
                Console.WriteLine();
                row++;
            } while (row < ROWS);
            */
            for (int row = 0; row < ROWS; row++)
            {
                for ( int col = 0; col < COLS; col++)
                {
                    if (row == col || row % 5 == 0 || row + col == 9)
                    {
                        Console.Write($"  ");
                    }
                    else
                    {
                        Console.Write($"{row % 10}{col % 10} ");
                    }
                    
                }
                Console.WriteLine();
            }
            

            
            
        }
    }
}
