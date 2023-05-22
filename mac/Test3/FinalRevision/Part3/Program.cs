using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Q1 CalculateDifference(int firstNumber, int secondNumber)
            Console.WriteLine("Question 1: CalculateDifference()\n");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Enter the firt number: ");
                int first = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter the second number: ");
                int second = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"The result is {CalculateDifference(first, second)}");
                Console.WriteLine("-------------------------------------------------------------");
            }
            Console.WriteLine("\n==============================================================\n");
            #endregion

            #region Q2 CalculatePower(double current, double resistance)
            Console.WriteLine("Question 2: CalculatePower()\n");
            for (int i = 0; i < 2; i++)
            {
                Console.Write("Enter the current: ");
                double current = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the resistance: ");
                double r = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"The power is {CalculatePower(current, r)}");
                Console.WriteLine("-------------------------------------------------------------");
            }
            Console.WriteLine("\n==============================================================\n");
            #endregion

            #region Q3 CaculateTuitionFee(int numberOfCourses
            Console.WriteLine("Question 3: CalculateTuitionFee()\n");
            for (int i = 0; i < 1; i++)
            {
                const double CostPerCourse = 449.99;
                Console.Write("Enter the number of course(s): ");
                int course = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"The tuition fee is {CalculateTuitionFee(course, CostPerCourse):c2}");
                Console.WriteLine("-------------------------------------------------------------");
            }
            Console.WriteLine("\n==============================================================\n");
            #endregion

            #region Q4 CalculateCommission(double saleAmount)
            Console.WriteLine("Question 4: CalculateCommission()\n");
            double[] commission = { 900, 1000, 1001, 2000 };
            for (int i = 0; i <= commission.Length - 1; i++)
            {
                Console.WriteLine($"{CalculateCommission(commission[i]):c2}");
            };
            Console.WriteLine("\n==============================================================\n");
            #endregion

            #region Q5 Question 5: CostOfBurgers()
            Console.WriteLine("Question 5: CostOfBurgers()\n");
            Console.WriteLine($"the total cost of burgers is {CostOfBurgers():c2}");
            Console.WriteLine("\n==============================================================\n");
            #endregion

            #region Q6 Question 6: CalculateGravitationalAttraction()
            Console.WriteLine("Question 6: CalculateGravitationalAttraction()\n");
            double earth = 5.972e+24;
            double moon = 7.348e+22;
            double distance = 384400000;
            Console.WriteLine($"earth: {earth:e}");
            Console.WriteLine($"moon: {moon:e}");
            Console.WriteLine($"distance: {distance:e}");
            Console.WriteLine($"force: {CalculateGravitationalAttraction(earth, moon, distance):e}");
            Console.WriteLine("\n==============================================================\n");
            #endregion

            #region Q7 HeronFormula()
            Console.WriteLine("Question 7: HeronFormula()\n");
            double a = 5.83;
            double b = 4.24;
            double c = 8;
            Console.WriteLine($"a:{a:f2} b:{b:f2} c:{c:f2} area:{HeronFormula(a, b, c):f2}");
            Console.WriteLine("\n==============================================================\n");
            #endregion

            #region Q8 ConvertCelsiusToFahrenheit()
            Console.WriteLine("Question 8: ConvertCelsiusToFahrenheit()\n");
            double[] celsius = { 0, 50, 100 };
            for (int i = 0; i < celsius.Length; i++)
            {
                Console.WriteLine($"C:{celsius[i]:f2} F:{ConvertCelsiusToFahrenheit(celsius[i]):f2}");
            }
            Console.WriteLine("\n==============================================================\n");
            #endregion

            #region Q9 ConvertFahrenheitToCelsius()
            Console.WriteLine("Question 9: ConvertFahrenheitToCelsius()\n");
            double[] fahrenheit = { 0, 123.8, 212 };
            for (int i = 0; i < fahrenheit.Length; i++)
            {
                Console.WriteLine($"C:{fahrenheit[i]:f2} F:{ConvertFahrenheitToCelsius(fahrenheit[i]):f2}");
            }
            Console.WriteLine("\n==============================================================\n");
            #endregion

            #region Q10 ConvertCelsiusToKelvin()
            Console.WriteLine("Question 10: ConvertCelsiusToKelvin()\n");
            double[] secondCelsius = { -196, 0, 100 };
            for (int i = 0; i < secondCelsius.Length; i++)
            {
                Console.WriteLine($"C:{secondCelsius[i]:f2} K:{ConvertCelsiusToKelvin(secondCelsius[i]):f2}");
            }
            Console.WriteLine("\n==============================================================\n");
            #endregion

            #region Q11 ConvertFahrenheitToKelvin()
            Console.WriteLine("Question 11: ConvertFahrenheitToKelvin()\n");
            double[] thirdCelsius = { -196, 0, 100 };
            for (int i = 0; i < thirdCelsius.Length; i++)
            {
                Console.WriteLine($"C:{thirdCelsius[i]:f2} K:{ConvertFahrenheitToKelvin(thirdCelsius[i]):f2}");
            }
            Console.WriteLine("\n==============================================================\n");
            #endregion
        }

        #region Q1
        /*
         * 1. Write a method called CalculateDifference(int firstNumber, int secondNumber).  
         * This method will calculate and return the difference between the two numbers 
         * i.e. it will subtract the smaller one from the larger one and then return that value. 
         * Call the CaculateDifference() method four times from your program Main() method supplying different arguments each time. 
         * You must display the returned value for each call.
         */
        static int CalculateDifference(int firstNumber, int secondNumber)
        {
            int result = firstNumber - secondNumber;
            return result;
        }

        #endregion

        #region Q2
        /*
         * 2.	Write a method called CalculatePower(double current, double resistance). 
         * The method will calculate and return the electrical power dissipated in a circuit. [P=I^2R].
         * Call the CalculatePower() method two times from your program Main() 
         * method supplying different arguments each time and displaying the returned value each time.
         */
        static double CalculatePower(double current, double resistance)
        {
            double power = current * current * resistance;
            return power;
        }
        #endregion

        #region Q3
        /*
         * 3.	Write a method called CaculateTuitionFee(int numberOfCourses, 
         * double costPerCourse = 449.99). 
         * This method will calculate and return the required fees amount. 
         * [Fees = number of courses * cost per course + 15.25]. 
         * Call the CaculateTuitionFee() method four times from your program Main() method 
         * supplying different arguments each time.
         */
        static double CalculateTuitionFee(int numberOfCourses, double costPerCourse)
        {
            double fees = numberOfCourses * costPerCourse + 15.25;
            return fees;
        }
        #endregion

        #region Q4
        /*
         * 4.	Write a method called CalculateCommission(double saleAmount). 
         * This method will calculate and return a sales representation’s commission. 
         * [over $1000 the commission will be 1%].
         * Call the CalculateCommission() method three times from your program Main() method, 
         * supplying arguments 900, 1000, 1001 and 2000.
         */
        static double CalculateCommission(double saleAmount)
        {
            if (saleAmount > 1000)
            {
                double commission = saleAmount * 0.1;
                return commission;
            }
            return 0;
        }
        #endregion

        #region Q5
        /*
         * 5.	Write a method that does not take any argument. 
         * The method will prompt the user for the number of burgers that he wants to buy. 
         * The method will calculate and return the amount of money that will be required. 
         * [One burger cost $1.39]. 
         * From your program Main() method, call the above method two times 
         */
        static double CostOfBurgers()
        {
            Console.Write("How many burgers? ");
            int burgers = Convert.ToInt32(Console.ReadLine());

            double cost = burgers * 1.39;
            return cost;
        }
        #endregion

        #region Q6
        /*
         * “Newton's law of universal gravitation states that every point mass in the universe attracts 
         * every other point mass with a force that is directly proportional to the product of their masses 
         * and inversely proportional to the square of the distance between them.” 
         * Write a method called CalculateGravitationalAttraction() that takes three double arguments 
         * (masses of the two bodies and the distance between them). 
         * The method will calculate and return the force of attraction between them.
         * 
         * In your main call this method with the masses of the earth, moon and the distance between them and display the resulting force. 
         * Mass of Earth = 5.972 × 10^24, moon = 7.348 × 10^22, Distance = 384,400000m. 
         * [Answer 1.982 x 1020N] 
         */
        static double CalculateGravitationalAttraction(double firstMass, double secondMass, double distance)
        {
            double g = 6.673e-11;
            double f = (g * firstMass * secondMass) / (distance * distance);
            return f;
        }
        #endregion

        #region Q7
        /*
         * 7.	Heron’s formula allows you to calculate the area of any triangle given the length of the three sides. 
         * Write a method that takes the length of the three sides and return the area of the specified triangle. 
         * 
         * In your main call this method with arguments 5.83, 4.24 and 8.00, and display the area.
         */
        static double HeronFormula(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }
        #endregion

        #region Q8
        /*
         * 8.	Write a method called ConvertCelsiusToFahrenheit that takes a double argument. 
         * The method will calculate and return the Fahrenheit equivalent of the argument. [F = C * 9 / 5 + 32]. 
         * In your main call this method three times with arguments 0, 51 and 100 respectively and display the results.
         */
        static double ConvertCelsiusToFahrenheit(double c)
        {
            double f = c * 9.0 / 5 + 32;
            return f;
        }
        #endregion

        #region Q9
        /*
         * 9.	Write a method called ConvertFahrenheitToCelsius that takes a double argument. 
         * The method will calculate and return the Celsius equivalent of the argument. [C = (F – 32) * 5 / 9]. 
         * In your main call this method three times with arguments 0, 123.8 and 212 respectively and display the results.
         */
        static double ConvertFahrenheitToCelsius(double f)
        {
            double c = (f - 32) * 5.0 / 9;
            return c;
        }
        #endregion

        #region Q10
        /*
         * 10.	Write a method called ConvertCelsiusToKelvin that takes a double argument. 
         * The method will calculate and return the Kelvin equivalent of the argument.  [K = C + 273.15]. 
         * In your main call this method three times with arguments -196, 0 and 100 respectively and display the results.
         */
        static double ConvertCelsiusToKelvin(double c)
        {

            double k = c + 273.15;
            return k;
        }
        #endregion

        #region Q11
        /*
         * 11. Write a method call ConvertFahrenheitToKelvin that takes a double argument. 
         * The method will calculate and return the Kelvin equivalent of the argument.  
         * [DO NOT RE-CODE THIS METHOD. Use the two previous methods to assist in your computation]. 
         * In your main call this method three times and display the results.
         */
        static double ConvertFahrenheitToKelvin(double c)
        {
            double f = ConvertFahrenheitToCelsius(c);
            double k = ConvertCelsiusToKelvin(f);
            return k;
        }
        #endregion
    }
}
