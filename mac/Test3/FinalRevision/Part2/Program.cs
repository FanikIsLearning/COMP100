using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Part2
{
    internal class Program
    {
        static int[] sphere = { 1, 2, 10 };
        static bool start = true;
        static int[] cm = { 90, 120, 175 };

        static void Main(string[] args)
        {
            int[] sphere = { 1, 2, 10 };
            int a = 0, b = 5, c = 10, d = 1, e = 2, f = 10;
            #region Q1 DisplayHorizontalStars(int numberOfStars)
            Console.WriteLine("Q1");
            DisplayHorizontalStars(a);
            DisplayHorizontalStars(b);
            DisplayHorizontalStars(c);
            Console.WriteLine("-------------------------------------------------------------");
            #endregion

            #region Q2 DisplayVerticalStars(int numberOfStars)
            Console.WriteLine("Q2");
            DisplayVerticalStars(a);
            DisplayVerticalStars(b);
            DisplayVerticalStars(c);
            Console.WriteLine("-------------------------------------------------------------");
            #endregion

            #region Q3 CalculateSphereVolume(int radius)
            Console.WriteLine("Q3");
            CalculateSphereVolume(d);
            CalculateSphereVolume(e);
            CalculateSphereVolume(f);
            Console.WriteLine("-------------------------------------------------------------");
            //Q3.1
            //CalculateSphereVolumeOnce();
            #endregion

            #region Q4 CalculateTax(double cost, string province)
            Console.WriteLine("Q4");
            while (start)
            {
                Console.Write("Enter a cost: ");
                double cost = Convert.ToDouble(Console.ReadLine());
                if (cost == 0)
                {
                    break;
                }
                Console.Write("Enter two letters province: ");
                string province = Console.ReadLine();
                if (province.ToLower() == "stop")
                {
                    break;
                }
                CalculateTax(cost, province);
            }
            Console.WriteLine("-------------------------------------------------------------");
            #endregion

            #region Q5 Temperature(double celsius)
            Console.WriteLine("Q5");
            double aa = 1, bb = 100;
            Temperature(aa);
            Temperature(bb);
            Console.WriteLine("-------------------------------------------------------------");
            #endregion

            #region Q6 ConvertKilometerToMiles(double km, double size, int line)
            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter a starting km: ");
                double km = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter an increment size: ");
                double size = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter a number of lines: ");
                int lines = Convert.ToInt32(Console.ReadLine());
                ConvertKilometerToMiles(km, size, lines);
            }
            Console.WriteLine("-------------------------------------------------------------");
            #endregion

            #region Q7 DisplaySineTableVer2()
            DisplaySineTableVer2();
            Console.WriteLine("-------------------------------------------------------------");
            #endregion

            #region Q8 nvertCMtoM()
            ConvertCMtoM();
            Console.WriteLine("-------------------------------------------------------------");
            #endregion
        }

        #region Q1
        /*
         * 1. Write a method called DisplayHorizontalStars(int numberOfStars). This method will output the number of stars horizontally specified by its argument. 
         * Call the DisplayHorizontalStars() method three times from your program Main() method, supplying 0, 5 and 10 respectively for the number of stars.
         */
        static void DisplayHorizontalStars(int numberOfStars)
        {
            for (int i = 0; i < numberOfStars; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
        #endregion

        #region Q2
        /*
         * 2.	Write a method similar to the one above that displays a vertical line of stars. 
         * Call this method three times with arguments 0, 5 and 10 respectively.
         */
        static void DisplayVerticalStars(int numberOfStars)
        {
            for (int i = 0; i < numberOfStars; i++)
            {
                Console.WriteLine("*");
            }
            Console.WriteLine();
        }
        #endregion

        #region Q3
        /*
         * 3.	Write a method that accepts an argument of type double. The method will calculate and display the volume of a sphere with radius specified by its argument. 
         * [V=4/3  πr^3]. 
         * Call this method from your main three times, with arguments 1, 2, and 10 respectively. 
         * The answers are 4.1888, 33.5103 and 4188.7902 respectively.
         * Use Math.PI for the value of π
         */
        static void CalculateSphereVolume(int radius)
        {
            double volume = (4.0 / 3) * Math.PI * radius * radius * radius;
            Console.WriteLine($"{volume:f4}");
        }
        #endregion

        #region Q3.1
        /*
         * 3.	Write a method that accepts an argument of type double. The method will calculate and display the volume of a sphere with radius specified by its argument. 
         * [V=4/3  πr^3]. 
         * Call this method from your main three times, with arguments 1, 2, and 10 respectively. 
         * The answers are 4.1888, 33.5103 and 4188.7902 respectively.
         * Use Math.PI for the value of π
         */
        static void CalculateSphereVolumeOnce()
        {
            for (int i = 0; i < sphere.Length; i++)
            {
                double volume = (4.0 / 3) * Math.PI * sphere[i] * sphere[i] * sphere[i];
                Console.WriteLine($"{volume:f4}");
            }
            Console.WriteLine();
        }
        #endregion

        #region Q4
        /*
         * 4.	Write a method that takes two arguments: a cost price and a two-letter province code. 
         * It will calculate and display the selling price. (If province is Ontario a tax of 13% is added to the price, if the province is Quebec a tax of 17% is added to the cost price. 
         * There is no tax for the rest of the provinces and territories). In your main, call this method enough times to fully test it
         */
        static void CalculateTax(double cost, string province)
        {
            if (province.ToLower() == "on")
            {
                double tax = cost * 0.13;
                double sum = tax + cost;
                Console.WriteLine($"The total is {sum:c2} and the tax is {tax:c2} in {province}.");
            }
            else if (province.ToLower() == "qu")
            {
                double tax = cost * 0.17;
                double sum = tax + cost;
                Console.WriteLine($"The total is {sum:c2} and the tax is {tax:c2} in {province}.");
            }
            else
            {
                Console.WriteLine($"No Tax in {province}, the cost is {cost}");
            }
        }
        #endregion

        #region Q5
        /*
         * 5.	Write a method that takes a single argument of type double. The will display a Celsius to Fahrenheit conversion table. 
         * The starting temperature is indicated by the argument and it will display 10 lines in increments of 1. 
         * [Fahrenheit = 9/5 Celsius + 32]. 
         * In your main call this method two times, each time with a different start value.
         */
        static void Temperature(double celsius)
        {
            Console.Write("\nFahrenheit   Celsius \n");
            Console.Write("----------   ------- \n");
            int i = 0;
            while (i < 10)
            {
                double fahrenheit = (9.0 / 5) * celsius + 32;
                Console.WriteLine($"{fahrenheit,6} {celsius,12:f2}");
                celsius += 1;
                i++;
            }
        }
        #endregion

        #region Q6
        /*
         * 6.	Write a method that takes the following arguments: a starting km value of type double, 
         * an increment size of type double and the number of lines of type int. 
         * The display a kilometer to miles conversion table. [miles = km * 0.621371]. 
         * In your main call this method three times, each time with different values.
         */
        static void ConvertKilometerToMiles(double km, double size, int line)
        {
            Console.Write("\nkilometers    miles \n");
            Console.Write("----------   ------- \n");
            for (int i = 0; i < line; i++)
            {
                double miles = km * 0.621371;

                Console.WriteLine($"{km,8:f2} {miles,10:f2}");
                km += size;
            }
        }
        #endregion

        #region Q7
        /*
         * Modify the DisplaySineTable() method in the previous section to accept the 
         * start value, the step size and number of rows as argument to the method.
         */
        static void DisplaySineTableVer2()
        {
            Console.Write("Enter the start value: ");
            double start = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the step size: ");
            double size = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                double sine = Math.Sin(start);
                Console.WriteLine($"{start,5:f2} {sine,5:f4}");
                start += size;
            }
        }

        #endregion;

        #region Q8
        /*
         * 8.	Write a method that converts a person’s height 
         * from centimeter to meters and centimeters and display the result on the console. 
         * In your main method, you should call this method three times with argument 90, 120 and 275.
         * Input	Result
         * 90cm	    0m 90cm
         * 120cm	1m 20 cm
         * 275cm	2m 75cm
         */
        static void ConvertCMtoM()
        {
            Console.WriteLine("Input   Result");
            for (int i = 0; i < cm.Length; i++)
            {
                int centimeter = cm[i];
                double meter = cm[i] / 100;
                double box = centimeter - (meter * 100);
                Console.WriteLine($"{centimeter,3}cm {meter,3}m {box,2}cm");
            }

        }
        #endregion
    }
}
