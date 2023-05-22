﻿using System;
/*
 ********************************************************************************
 * Programming I -  Test 3 (Version P)
 * Name:
 * Date:
 * Student #:
 * Test 3 - 25% of final grade
 * 
 ******************************************************************************** 
 */

namespace VersionP
{
    class VerP
    {
        static void Main(string[] args)
        {
            bool run = true;
            do
            {
                DisplayMenu();
                string option = Console.ReadLine();
                switch (option.ToLower())
                {
                    case "q":
                        /*DemoQuestion3();*/
                        break;
                    case "r":
                        DemoQuestion4();
                        break;
                    case "s":
                        DemoQuestion5();
                        break;
                    case "t":
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

        #region Question 1 - 11 marks
        /* 
         * Write a method that does not take any argument nor does it
         * return a value. The method only displays the following text.
         * 
         * YOU MUST INSERT YOUR NAME IN THE TOP LINE OF THE MENU 
         * 
         * --------------------COMP100--------------------------
         *             q) Working with array of characters 
         *             r) Metric to Imperial Conversion                  
         *             s) Using Stokes's Law       
         *             t) Calculate Tax                 
         *                                                       
         *             x) To exit the program");
         * ------------------------------------------------------
         * Press the letter corresponding to your choice-> ");
         * 
         */

        static void DisplayMenu()
        {
            Console.WriteLine("--------------------COMP100--------------------------");
            Console.WriteLine("            q) Working with array of characters ");
            Console.WriteLine("            r) Metric to Imperial Conversion      ");
            Console.WriteLine("            s) Using Stokes's Law    ");
            Console.WriteLine("            t) Calculate Tax                 ");
            Console.WriteLine("");
            Console.WriteLine("            t) Calculate Tax     ");
            Console.WriteLine("------------------------------------------------------");

        }

        #endregion

        #region Question 2 - 20 marks
        /* 
         * In your Main() method, using a suitable looping structure, write the 
         * code to call this method repeatedly. 
         * Using a suitable branching structure, write the code to implement the 
         * following required functionality for all valid responses.
         * Valid responses includes both upper and lower case of the input. The 
         * following must be implemented:
         * q will call the DemoQuestion3() method
         * r will call the DemoQuestion4() method
         * s will call the DemoQuestion5() method
         * t will call the DemoQuestion6() method
         * x will terminate the program
         * Any other key will produce an error message
         * 
         * YOU DON'T HAVE TO CREATE A NEW METHOD FOR THIS QUESTION
         */
        #endregion

        #region Question 3 - 36 marks
        /* Question 3c (10 marks)
         * 
         * Write a method with the following specification
         * name     : DisplayOnlyVowels
         * arguments: array of char
         * returns  : nothing
         * display  : only the vowels in the array separated by a space
         * task     : use a suitable looping structure to send each
         *            vowel to the screen.
         * 
         * Hint: You may assume that you are dealing only with lowercase
         *       letters
         *            
         * YOU MUST USE A FOREACH loop
         */


        /* Question 3b (8 marks)
         * 
         * Write a method with the following specification
         * name     : DisplayCharAray
         * arguments: array of char
         * returns  : nothing
         * display  : all the items in the array seperated by a space
         * task     : use a suitable looping structure to send each
         *            item to the screen.
         *            
         * YOU MUST USE A FOR loop
         */


        /* Question 3a (11 marks)
         * 
         * Write a method with the following specification
         * name     : GenerateCharAray
         * arguments: int representing the number of char to generate
         *            i.e. the size of the resulting array
         * returns  : char array
         * display  : nothing
         * task     : 1) create the random object to generate random numbers
         *            2) declare and allocate storage for the array
         *            3) using a suitable looping structure get a random value 
         *               and assign it the element of the array
         *               use (char)random.Next('a', 'z' + 1) to obtain a random char
         *            4) return the array
         */


        /* The driver for question 3 (7 marks)
         * 
         * 1) Call GenerateCharArray with argument 40 and assign the 
         *    returned value to a suitable variable
         * 2) Use DisplayCharArray to print the above stored value
         * 3) Print an empty line
         * 4) Use DisplayOnlyNonVowels to print the consonants in the 
         *    above stored value
         * 5) Print an empty line
         * 6) Use DisplayCharArray to print the above stored value
         */
        static void DemoQuestion3()
        {
            Console.WriteLine("\n\n**********Begin Question 3 **********");
            //code for invoking question 3 goes here
            char[] charArray = GenerateCharArray(40);
            DisplayCharArray(charArray);
            Console.WriteLine();
            DisplayOnlyVowels(charArray);
            Console.WriteLine();

            DisplayCharArray(charArray);
            Console.WriteLine("\n**********End Question 3 **********\n\n");
        }

        static int[] DisplayOnlyVowels(char[] value)
        {
            char[] result = new char[10];
            foreach (char item in value)
            {
                char position = item;
                result[position]++;
            }
            return result;
        }

        static void DisplayCharArray(char[] characters)
        {
            foreach (var x in characters)
                Console.Write($"{x} + ");
        }

        static char[] GenerateCharArray(int numberOfItems, char largestValue)
        {
            Random generator = new Random();
            char[] result = new char[size];

            for (int i = 0; i < numberOfItems; i++)
                result[i] = (char)random.Next('a', 'z' + 1);
            return result;
        }
        #endregion

        #region Question 4 - 19 marks
        /* Question 4 (12 marks)
         * 
         * Write a method with the following specification
         * name     : MetricToImperial
         * arguments: a double representing the weight in kg to convert
         *            a double to store the pound equivalent
         *            a double to store the ounces equivalent
         *            a double to store the tons equivalent
         * returns  : nothing
         * display  : nothing
         * task     : converts the first argument (number of kilograms) into 
         *            pounds, ounces and tons
         *           
         * hint     : 1kg = 2.2046 pounds
         *          : 1kg = 35.274 ounces
         *          : 1kg = 0.0011 tons
         */


        /* The driver for question 4 (7 marks) 
         * 
         * 1) Declare a double variable (this will be your first argument) 
         *    and initialized it to 0.15
         * 2) Declare three other variables to store the pounds, ounces and tons
         * 3) Call the TimeConversion with the appropriate arguments. Print all of the 
         *    arguments after the method call 
         * 4) Now change the first argument to 150 and repeat step 3.  
         */
        static void DemoQuestion4()
        {
            Console.WriteLine("\n\n**********Begin Question 4 **********");
            //code for invoking question 4 goes here
            TimeConversion();
            Console.WriteLine("\n**********End Question 4 **********\n\n");
        }
        static double start = 0.15, pound, ounces, tons;
        static void TimeConversion()
        {
            
            pound = start * 2.2046;
            ounces = start * 35.274;
            tons = start * 0.0011;
 
            Console.WriteLine($"{start}kg is equivalent to {pound:f2}llb {ounces:f2}oz {tons:f2}tons");
            MetricToImperial(start, out pound, out ounces, out tons);
        }
        

        static void MetricToImperial( double start, out double pound,out double ounces,out double tons)
        {
            pound = start * 1000;
            ounces = start * 1000;
            tons = start * 1000;
            Console.WriteLine($"{start*1000}kg is equivalent to {pound:f2}llb {ounces:f2}oz {tons:f2}tons");
        }
        #endregion

        #region Question 5 - 16 marks
        /* Question 5 (10 marks)
         * 
         * Stokes's law states that the drag force of a small
         * body moving in a liquid depends on the size and speed
         * of the body as well as the viscousity of the liquid. 
         * (See attached word document for the formula.) 
         * Write a method that calculates and returns the force between the two bodies. 
         * The specifications is as follows:
         * 
         * Name: 
         *  Stokes
         *  
         * Argument: 
         *  a double representing the viscosity of the liquid
         *  a double representing the radius of the object
         *  a double representing the speed of the object
         *  
         * Returns:
         *  a double indicating the drag force on the object
         *  
         * Action:
         *  Calculates and return the drag force according to Stokes's law. The 
         *  equation is given in the attached word document
         *  
         * Displays:
         *  nothing.
         *         
         */


        /* The driver for question 5 (6 mark)
         * 
         * In the DemoQuestion5() method, write the code to call this method two
         * times with arguments ( 1.3, 3.17E-3, 0.108 ) and 
         * (1.4, 3.32e-3, 0.0474) respectively and display the 
         * return value after each call
         * 
         */
        static void DemoQuestion5()
        {
            Console.WriteLine("\n\n**********Begin Question 5 **********");
            //code for invoking question 5 goes here
            double liquid = 1.3, liquid1 = 1.4, radius = 3.17e-3, radius1 = 3.32e-3, speed = 0.108, speed1 = 0.0474;
            double box = Stokes(liquid, radius, speed);
            double box1 = Stokes(liquid1, radius1, speed1);
            Console.WriteLine($"The drag on a body of radius {radius:f5} with speed {speed} thru a liquid of viscosity {liquid} is {box:f4}N");
            Console.WriteLine($"The drag on a body of radius {radius1:f5} with speed {speed1} thru a liquid of viscosity {liquid1} is {box1:f4}N");
            Console.WriteLine("\n**********End Question 5 **********\n\n");
        }

        static double Stokes(double liquid, double radius, double speed)
        {
            double S = 6 * Math.PI * liquid * radius * speed;
            return S;
        }
        #endregion

        #region Question 6 - 22 marks
        /* Question 6 (14 marks)
         * 
         * All Canadian are required to pay federal and provincial taxes. This question deals 
         * with federal tax calculation. The question specification are as follows:
         * 
         * Name: 
         *  CalculateTax
         *  
         * Argument: 
         *  a double representing the annual taxable income
         *  
         * Returns:
         *  a double indicating the federal tax owned to the government 
         *    
         * Action:
         *  Calculates and return the tax based on the following abridge table:
         *  $48,535 or less     15%
         *  $48,535 to $97,069  20.5%
         *  $97,069 or more     26%
         * N.B. If someone earns $115,000 then she pays the first $48,535 at 15%
         * and then the next $48,534 at 20.5% and then $17,931 at 26%
         * Displays: nothing.
         *         
         */


        /* The driver for question 6 (8 marks)
         * 
         * 1) Declare an double variable and initialized it to 45000
         * 2) Invoke the FederalTax method with this variable and print the returned value
         * 3) Change the variable to 75000 and repeat step 2
         * 4) Change the variable to 115000 and repeat step 2
         */
        static void DemoQuestion6()
        {
            Console.WriteLine("\n\n**********Begin Question 6 **********");
            //code for invoking question 6 goes here
            double[] initial = { 45000, 75000, 115000 };
            for (int i = 0; i<initial.Length; i++)
            {
                CalculateTax(initial[i]);
                Console.WriteLine($"Your federal tax will be {CalculateTax(initial[i]):c2} if your income is {initial[i]:c2}");
            }
            Console.WriteLine("\n**********End Question 6 **********\n\n");
        }

        static double CalculateTax(double earning)
        {
            if (earning < 48535)
            {
                double tax = earning * 0.15;
                return tax;
            }
            else if (earning > 48535 || earning < 97069)
            {
                double tax = earning * 0.205;
                return tax;
            }
            else if (earning > 97069)
            {
                double tax = earning * 0.26;
                return tax;
            }
            return 0;
        }
        #endregion
    }
}
