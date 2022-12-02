using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part1
            ShowMenu();
            #endregion
        }

        #region Part1

        #region Q1
        /*
         * 1. Write a method called DisplayPersonalInfo(). 
         * This method will display your name, school, program and your favorite course.
         * Call the DisplayPersonalInfo() method from your program Main() method
         */
        static void DisplayPersonalInfo()
        {
            string name = "My name is HOI KIT FAN";
            string school = "My school is Centennial College";
            string program = "My program is 3408 software engineering technician";
            string course = "My favourite course is COMP100";

            Console.WriteLine($"{name}\n{school}\n{program}\n{course}");
        }
        #endregion

        #region Q2
        /*
         * 2.	Write a method called CalculateTuition(). 
         * This method will prompt the user for the number of courses that she is currently taking and then calculate and display the tuition cost.
         * Call the DisplayPersonalInfo() method from your program Main() method
         */
        static void CalculateTuition()
        {
            Console.Write("How many courses did you take? ");
            int courses = Convert.ToInt32(Console.ReadLine());

            double cost = courses * 569.99;
            Console.WriteLine($"the total cost of {courses} courses is {cost:c2}.");
        }
        #endregion

        #region Q3
        /*
         * 3.	Write a method call CalculateAreaOfCircle(). 
         * This method will prompt the user for the radius of a circle and then calculate and display the area.[A = πr2]. 
         * Call the CalculateAreaOfCircle() method twice from the same Main() method as in question 1. Use Math.Pi for the value of π
         */
        static void CalculateAreaOfCircle()
        {
            Console.Write("Enter radius: ");
            double radius = Convert.ToInt32(Console.ReadLine());

            double area = Math.PI * radius * radius;
            Console.WriteLine($"the area of circle is {area:f2}.");
        }
        #endregion

        #region Q4
        /*
         * 4.	Write a method call CalculateAreaOfTriangle(), 
         * that prompts the user for the base and height of a triangle and then calculate and display the area.[ A=bt/2 ] 
         * Call the CalculateAreaOfTriangle() method twice from the same Main() method as in question 1.
         */
        static void CalculateAreaOfTriangle()
        {
            Console.Write("Enter base: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double area = (length * height)/2 ;
            Console.WriteLine($"the area of triangle is {area:f2}.");
        }
        #endregion

        #region Q5
        /*
         * 5.	Write a method call CalculateSaleCommission(),
         * that prompts the user for his sales figure, and then calculate and display his commission. 
         * (commission = 25% of sales in excess of 1000. If sales is equal to or below $1000.00 there is no commission) 
         * Call the CalculateSaleCommission() method three times from the same Main() method as in question 1.
         */
        static void CalculateSaleCommission()
        {
            Console.Write("Enter the sales figure: ");
            double sales = Convert.ToDouble(Console.ReadLine());

            if (sales > 1000)
            {
                double commission = sales * 0.25;

                Console.WriteLine($"The commission is {commission:c2}.");
            }
            else
            {
                Console.WriteLine($"Sorry! Sales is equal to or below $1000.00 there is no commission");
            }
        }
        #endregion

        #region Q6
        /*
         * 6.	Write a method call DisplaySineTable(), 
         * that prompts the user for a starting value and an step size. 
         * The method will calculate and display a table (10 rows) of sine values based on the user input. 
         * Use the built-in method Math.Sin() to obtain the sine of an angle. 
         * e.g. if the starting value is 0.5 and the step size is 0.03 the method will display the following table:
         * 0.50	0.4794
         * 0.53	0.5055
         * 0.56	0.5311
         * 
         * 0.77	0.6961
         * The numbers in both columns MUST be right aligned. Call the DisplaySineTable() method from the same Main() method as in question 1.
         */
        static void DisplaySineTable()
        {
            Console.Write("Enter the start value: ");
            double start = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the step size: ");
            double size = Convert.ToDouble(Console.ReadLine());

            for(int i = 0; i < 10; i++)
            {
                double sine = Math.Sin(start);
                Console.WriteLine($"{start,5:f2} {sine,5:f4}");
                start += size;
            }
        }
        #endregion

        #region Q7
        /*
         * 7.	In a write a method called DisplayMenu() to display the following text on screen:
         * ===============Ivan’s Computer Systems================
         * |       1. Display My Personal Information           |
         * |       2. Calculate Tuition                         |
         * |       3. Calculate Area Of A Circle                |
         * |       4. Calculate the Area Of A Triangle          |
         * |       5. Calculate Sales Commission                |
         * |       6. Display Sine Table                        |
         * |       0. End program                               |
         * |                                                    |
         * ======================================================
         *           Enter the number of your choice ->
         * You may replace the instructor’s name with your name.
         */
        static void DisplayMenu()
        {
            Console.WriteLine("===============Ivan’s Computer Systems================");
            Console.WriteLine("|       1. Display My Personal Information           |");
            Console.WriteLine("|       2. Calculate Tuition                         |");
            Console.WriteLine("|       3. Calculate Area Of A Circle                |");
            Console.WriteLine("|       4. Calculate the Area Of A Triangle          |");
            Console.WriteLine("|       5. Calculate Sales Commission                |");
            Console.WriteLine("|       6. Display Sine Table                        |");
            Console.WriteLine("|       0. End program                               |");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("======================================================");
            //Take care of this!!!
            Console.Write("          Enter the number of your choice ->");
        }
        #endregion

        #region Q8
        /*
         * 8. Add another method called ShowMenu() to your project. 
         * This method will call the method in question 7 continuously until the user presses 0. 
         * (You will have to invoke the method in a loop body, read in the user input as well as check the input). 
         * You will need to hook up all the methods that you wrote previously i.e. questions 1 to 6. 
         * Replace all the code from your Main() method with a single call to the ShowMenu() method.
         */
        static void ShowMenu()
        {
            bool start = true;
            for(; start ;) /*do-while loop better*/
            {
                DisplayMenu();
                int option = Convert.ToInt32(Console.ReadLine());
                /*switch (option)
                {
                    case 1:
                        DisplayPersonalInfo();
                        DisplayPersonalInfo();
                        //stop = false;
                        break;
                    case 2:
                        CalculateTuition();
                        CalculateTuition();
                        break;
                    case 3:
                        CalculateAreaOfCircle();
                        CalculateAreaOfCircle();
                        break;
                    case 4:
                        CalculateAreaOfTriangle();
                        CalculateAreaOfTriangle();
                        break;
                    case 5:
                        CalculateSaleCommission();
                        CalculateSaleCommission();
                        CalculateSaleCommission();
                        break;
                    case 6:
                        DisplaySineTable();
                        break;
                    case 0:
                        Console.WriteLine("0. End program");
                        stop = false;
                        break;
                    default:
                        Console.WriteLine("ERROR: Invalid option");
                        break;
                }*/

                if (option == 1)
                {
                    DisplayPersonalInfo();
                }
                else if (option == 2)
                {
                    CalculateTuition();
                }
                else if (option == 3)
                {
                    CalculateAreaOfCircle();
                }
                else if (option == 4)
                {
                    CalculateAreaOfTriangle();
                }
                else if (option == 5)
                {
                    CalculateSaleCommission();
                }
                else if (option == 6)
                {
                    DisplaySineTable();
                }
                else if (option == 0)
                {
                    Console.WriteLine("0. End program");
                    start = false;
                }
            }
        }
        #endregion

        #endregion
    }
}
