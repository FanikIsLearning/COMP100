using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DisplayMenu();
        }
        #region Question 1&2
        /*
         * Write a method with the following specifications:
         * name: DisplayMenu
         * arguments: none
         * return value: none
         * tasks: display the following menu choice on the screen
         * Calculation Menu
         * 3) Calculate Sum
         * 4) Calculate Sum of Squares
         * 5) Calculate Sum of Cubes
         * 0) To Exit
         * 
         * Enter the number that corresponds to your choice:
         * 
         * You may beautify the output to your own likings. You don’t have to implement the functionalities of the
         * various menu choices at this stage
         * Call this method from your main
         */
        static void DisplayMenu()
        {
            bool stop = true;
    
            do {
                Console.WriteLine("Calculation Menu");
                Console.WriteLine("3) Calculate Sum");
                Console.WriteLine("4) Calculate Sum of Squares");
                Console.WriteLine("5) Calculate Sum of Cubes");
                Console.WriteLine("6) Calculate Average");
                Console.WriteLine("0) To Exit");
                Console.WriteLine("Enter the number that corresponds to your choice: ");
            int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                    {
                    case 3:
                        Console.Write("3) Calculate Sum, how many inputs? ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(CalculateSum(a));
                        //stop = false;
                        break;
                    case 4:
                        Console.Write("4) Calculate Sum of Squares, how many inputs? ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(CalculateSumOfSquares(b));
                        break;
                    case 5:
                        Console.WriteLine(CalculateSumOfCubes());
                        break;
                    case 6:
                        Console.WriteLine(CalculateAverage());
                        break;
                    case 0:
                        Console.WriteLine("0) To Exit");
                        stop = false;
                        break;
                    default:
                    
                        Console.WriteLine("ERROR: Invalid option");
                        break;
                }
            }while (stop);
        }
        #endregion

        #region Question 3
        /*
         * 3.	Write a method with the following specifications:
         * name	: CalculateSum
         * arguments	: a single int representing the number of inputs that will constitute the sum
         * return value	: int representing the sum of all the user inputs
         * displays	: only the prompt for the user inputs, but does not display the sum 
         * tasks	: prompt and accepts inputs (as many as specified by the argument), and sum them, Finally the method will return the sum of all the inputs (the sum) 
         * 
         * In your main you will call this method when the user enters 3 in response to the menu choices. You will invoke this method with argument 5 and then display the resulting value from the method.
         */
        static int CalculateSum(int end)
        {
            int sum = 0;
            for ( int i = 0; i < end; i++)
            {  
                Console.Write($"Input #{i+1}: ");
                int input = Convert.ToInt32(Console.ReadLine());
                sum += input;
            }
            return sum;
        }
        #endregion

        #region Question 4
        /*
         * 4.	Write a method with the following specifications:
         * name	: CalculateSumOfSquares
         * arguments	: int representing the number of input that will constitute the sum
         * return value	: int representing the sum of the squares of its input
         * displays	: the user prompts but NOT the sum of the squares 
         * tasks: prompt the user for inputs and accumulates the sum of the squares of the input. This is repeated as specified by the argument. Returns the final sum 
         * 
         * In your main you will call this method when the user enters 3 in response to the menu choices. You will invoke this method with argument 5 and then display the resulting value from the method.
         */
        static int CalculateSumOfSquares(int end)
        {
            int sum = 0;
            for (int i = 0; i < end; i++)
            {
                Console.Write($"Input #{i + 1}: ");
                int input = Convert.ToInt32(Console.ReadLine());
                int square = input * input;
                sum += square;
            }
            return sum;
        }
        #endregion

        #region Question 5
        /*
         * 5.	Write a method with the following specifications:
         * name	: CalculateSumOfCubes
         * arguments	: none
         * return value	: int representing the sum of the cubes of its input
         * displays	: the user prompts but NOT the sum of the cubes 
         * tasks: 
        •	prompt the user for the number of inputs that she will be working with
        •	read in the user input
        •	Prompts the user for their input
        •	Accumulates the sum of the cubes input
        •	Repeat the above two steps are many times as required
        •	Returns the final sum 

         * 
         * In your main when the user enters 5 in response to the menu choices, you will invoke this method and display the resulting value.
         */
        static int CalculateSumOfCubes()
        {
            int sum = 0;
            Console.Write("5) Calculate Sum of Cubes, how many inputs? ");
            int end = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < end; i++)
            {
                Console.Write($"Input #{i + 1}: ");
                int input = Convert.ToInt32(Console.ReadLine());
                int cube = input * input * input;
                sum += cube; 
            }
            return sum;
        }
        #endregion

        #region Question 6
        /*
         * 6.	Write a method with the following specifications:
         * name	: CalculateAverage
         * arguments	: none
         * return value	: double representing the mathematical average of its inputs
         * displays	: the user prompts but NOT the average
         * tasks	: prompt and accept for the number of inputs that she will be working with. Prompts the user 
         * for the required number of inputs. Calculate and return the average of the inputs.
         * 
         * Modify your DisplayMenu method by adding another choice below CalculateSumOfCubes. 
         * In your main when the user enters the appropriate choice in response to the menu choices, 
         * you will invoke this method and display the resulting value
         */
        static double CalculateAverage()
        {
            double sum = 0, average = 0;
            Console.Write("6) Calculate Average, how many inputs? ");
            int end = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < end; i++)
            {
                Console.Write($"Input #{i + 1}: ");
                int input = Convert.ToInt32(Console.ReadLine());
                sum += input;
                average = sum / end;
            }
            return average;
        }
        #endregion

    }
}
