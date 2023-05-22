﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            do
            {
                callMenu();
                string option = Console.ReadLine();
                switch (option.ToLower())
                {
                    case "a":
                        DemoQuestion3();
                        break;
                    case "b":
                        DemoQuestion4();
                        break;
                    case "c":
                        DemoQuestion5();
                        break;
                    case "d":
                        DemoQuestion6();
                        break;
                    case "x":
                        Console.WriteLine("x. Program exited");
                        run = false;
                        break;
                    default:
                        Console.WriteLine("ERROR: Invalid option");
                        break;
                }
            } while (run);
        }

        #region Question 1 - 13 marks
        /* 
         * Write a method that does not take any argument nor does it
         * return a value. The method only displays the following text.
         * 
         * YOU MUST INSERT YOUR NAME IN THE TOP LINE OF THE MENU 
         * 
         * +---------------------COMP100------------------------+
         * |           a) Working with Newton's Law             |
         * |           b) Height Converter                      |
         * |           c) Sine and Cosine Table                 |
         * |           d) Number Frequency                      |
         * |                                                    |
         * |           x) To exit the program                   |
         * +----------------------------------------------------+
         * Press the letter corresponding to your choice-> 
         * 
         */
        static void callMenu()
        {
            Console.WriteLine("+---------------------COMP100------------------------+");
            Console.WriteLine("|           a) Working with Newton's Law             |");
            Console.WriteLine("|           b) Height Converter                      |");
            Console.WriteLine("|           c) Sine and Cosine Table                 |");
            Console.WriteLine("|           d) Number Frequency                      |");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("|           x) To exit the program                   |");
            Console.WriteLine("+----------------------------------------------------+");

        }
        #endregion

        #region Question 2 - 26 marks
        /* 
         * In your Main() method, using a suitable looping structure, write the 
         * code to call this method repeatedly. 
         * Using a suitable branching structure, write the code to implement the 
         * following required functionality for all valid responses.
         * Valid responses includes both upper and lower case of the input. The 
         * following must be implemented:
         * a will call the DemoQuestion3() method
         * b will call the DemoQuestion4() method
         * c will call the DemoQuestion5() method
         * d will call the DemoQuestion6() method
         * x will terminate the program
         * Any other key will produce an error message
         * 
         * YOU DON'T HAVE TO CREATE A NEW METHOD FOR THIS QUESTION
         */
        #endregion

        #region Question 3 - 15 marks
        /*  CalculateGravitationalForce - 9 marks
         * 	“Newton's law of universal gravitation states that every point mass in the 
         * 	universe attracts every other point mass with a force that is directly 
         * 	proportional to the product of their masses and inversely proportional to 
         * 	the square of the distance between them.” 
         * 	
         * Write a method with the following specifications:
         * Name     : CalculateGravitationalAttraction
         * Parameter: 
         * 	          A double representing the mass of the first body
         * 	          A double representing the mas of the second body
         * 	          A double representing the distance between them. 
         * Returns  : a double representing the attractive force between the bodies
         * Displays : Nothing
         * Task     : Calculate and return the force of attraction between them. 
         * 	[F=G (m_1 m_2)/d^2  , where G = 6.673e-11]. See word file for equation
         */


        /* Driver for question 3 - 6 marks
         * 
         * Write the statements to call the above method with the masses of the earth, 
         * moon and the distance between them and display the resulting force. 
         * 
         * 	Mass of Earth = 5.972E24, moon = 7.348E22, Distance = 3.844E8.
         * 	[Answer 1.99e020]
         * 	You shoul use E as a format specifier in your output
         */
        static void DemoQuestion3()
        {
            Console.WriteLine("\n\n**********Begin Question 3 **********");
            //code for invoking question 3 goes here
            double earth = 5.972e+24;
            double moon = 7.348e+22;
            double distance = 384400000;
            Console.WriteLine($"Mass of earth: {earth:e}kg");
            Console.WriteLine($"Mass of moon: {moon:e}kg");
            Console.WriteLine($"The distance between them: {distance:e}m");
            Console.WriteLine($"The force of attraction:{CalculateGravitationalAttraction(earth, moon, distance):e}N");
            Console.WriteLine("\n**********End Question 3 **********\n\n");
        }

        static double CalculateGravitationalAttraction(double firstMass, double secondMass, double distance)
        {
            double G = 6.673e-11;
            double F = (G * firstMass * secondMass) / (distance * distance);
            return F;
        }
        #endregion

        #region Question 4 - 10 marks
        /* Write a method with the following specifications: - 9 marks
         * Name     : HeightConversion
         * Parameter: an int representing the height value in cm
         * Returns  : Nothing
         * Displays : the meter and  centimeter equivalent
         * Tasks: Converts the argument to metres and cm and display
         * it on the console. 
         */

        /* Driver for question 4 - 3 marks
         * Write the code to call the above method below three times
         * with argument 75, 100 and 290.
         */
        static void DemoQuestion4()
        {
            Console.WriteLine("\n\n**********Begin Question 4 **********");
            //code for invoking question 4  here
            int[] cm = { 75, 100, 290 };
            for (int i = 0; i<cm.Length; i++)
            {
                HeightConversion(cm[i]);
            
            }
            Console.WriteLine("\n\n**********End Question 4 **********\n\n");
        }

        static void HeightConversion(int cm)
        {
            double m = cm / 100;
            double newCm = cm-m*100;
            Console.WriteLine($"{cm}cm {m}m {newCm}cm");
        }
        #endregion

        #region Question 5 - 18 marks
        /* SineCosine - 10 marks
         * Write a method with the following specifications:
         * Name     : SineCosine
         * Parameter: 
         *           A double that represents an angle in radians
         *           A double that represents the sine to the first argument
         *           A double that represents the cosine of the first argument
         * Returns  : Nothing
         * Displays : Nothing
         * Task     : Calculates the sine and cosine of the first argument and
         * assigns the result values to the second and third Parameter
         * 
         * NOTE: the second and thred arguemnts are decorated so that the 
         * method is able to change the actual value of the variable
         */

        /* Driver for question 5 - 8 marks 
         * Write the code statements to call this method ten times with values 
         * 0.500, 0.501, 0.502 … 0.509  and printout the values for angle, 
         * sine and cosine in a tabular format. It is expected to use some
         * kind of repetitive structure
         */

        static void DemoQuestion5()
        {
            Console.WriteLine("\n\n**********Begin Question 5 **********");
            //code for invoking question 5 goes here
            double values = 0.5, sine, cosine;
            Console.WriteLine($" Angle   Sine       Cosine");
            while (values <= 0.6)
            {
                SineCosine(values, out sine, out cosine);
                Console.WriteLine($"{values,5:f2} {sine,9:f4} {cosine,10:f4}");
                values += 0.01;
            }
            Console.WriteLine("\n**********End Question 5 **********\n\n");
        }

        private static void SineCosine(double values, out double sine, out double cosine)
        {
            sine = Math.Sin(values);
            cosine = Math.Cos(values);
        }
        #endregion

        #region Question 6 - 20 marks
        /* Write a method with the following specifications: //13 marks
         * Name: CalculateNumberFrequencies
         * Argument: an int array with values ranging from 0 to 99
         * Returns: int array of 10 integers. The first element will 
         *          indicate the number or unit values in the argument 
         *          (i.e. values 0-9), the second element will indicate 
         *          the number of 10 values (i.e. values 10-19), the 
         *          third element will indicate the number of 20 values 
         *          (i.e. values 20-29) etc.
         * Display: Nothing
         * Tasks  : The method will create an int array of 10 elements 
         *          (call this the result). 
         *          Each item of the argument is examined and the 
         *          appropriate element of the result array is incremented. 
         */


        /* Driver for Question 6 - 7 marks
         * Write the code to do the following:
         *   Call the GenerateRandomIntArray() and assign the results to a suitable variable
         *   Use the DisplayIntArray() method to display the above variable
         *   Print an empty line
         *   Call CalculateNumberFrequencies() method and display the resulting value
         */
        static void DemoQuestion6()
        {
            Console.WriteLine("\n\n**********End Question 6 **********");
            //code for invoking question 6 goes here
            int[] box = GenerateRandomIntArray(20, 100);
            DisplayIntArray(box);
            Console.WriteLine();
            DisplayIntArray(CalculateNumberFrequencies(box));
            Console.WriteLine("\n**********End Question 6 **********\n\n");
        }

        static int[] CalculateNumberFrequencies(int[] value)
        {
            int[] result = new int[10];
            foreach (int item in value)
            {
                int position = item / 10;
                result[position]++;
            }
            return result;
        }
        /*
         * FREE CODE
         */
        static void DisplayIntArray(int[] numbers)
        {
            foreach (var x in numbers)
                Console.Write($"{x,3}");
        }
        /*
         * FREE CODE
         */
        static int[] GenerateRandomIntArray(int numberOfItems, int largestValue)
        {
            int[] result = new int[numberOfItems];
            Random generator = new Random();
            for (int i = 0; i < numberOfItems; i++)
                result[i] = generator.Next(largestValue);
            return result;
        }
        #endregion
    }
}
