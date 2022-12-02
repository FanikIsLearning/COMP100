using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4
{
    internal class Program
    {
        static double degree = 0, sine, cosine, tangent;
        static void Main(string[] args)
        {
            #region Q2
            Console.WriteLine("Q2");
            int [] a = { 5, 2 };
            for (int i = 0; i < a.Length; i++)
            {
                int box = 0;
                Console.Write($"Before method call: {box};");
         
                CubeIt(a[i], ref box);
                Console.Write($" after method call: {box}!");
                Console.WriteLine();
            }
            Console.WriteLine("-------------------------------------------------------------");
            #endregion

            #region Q3
            Console.WriteLine("Q3");
            int[] number = { 5, 5, 10, 10 };
            double[] cost = { 500, 450, 450, 350 }; 
            double box1 = 0;
            for (int i = 0; i < number.Length; i++)
            {
                CalculateTuitionFee(number[i], cost[i], ref box1);   
                Console.WriteLine($"{number[i]} courses @{cost[i]:c2} will cost {box1:c2}!");
            }
            Console.WriteLine("-------------------------------------------------------------");
            #endregion

            #region Q4
            Console.WriteLine("Q4");
            int[] b = { 10, 25, 25 };
            int[] c = { 15, 15, 25 };
            int sum = 0;
            int difference = 0;
            for (int i = 0; i < b.Length; i++)
            {
                SumAndDifference(b[i], c[i], ref sum, ref difference);
                Console.WriteLine($"a:{b[i]}, b:{c[i]}, sum:{sum}, difference:{difference}");
            }
                Console.WriteLine("-------------------------------------------------------------");
            #endregion

            #region Q5
            Console.WriteLine("Q5");
  
            Console.WriteLine($" Angle  Sine      Cosine    Tangent");
            while (degree <= 95)
            {
                CalculateTrigValues(degree, out sine, out cosine, out tangent);
                Console.WriteLine($"{degree,5:n}{sine,9:f4}{cosine,10:f4} {tangent,9:f4}");
                degree += 5;
            }
            Console.WriteLine("-------------------------------------------------------------");
            #endregion

            #region Q6
            Console.WriteLine("Q6");
            double values = 0.5;
            Console.WriteLine($" Angle   Sine       Cosine");
            while (values <= 0.6)
            {
                SineCosine(values, out sine, out cosine);
                Console.WriteLine($"{values,5:n} {sine,9:f4} {cosine,10:f4}");
                values += 0.01;
            }
            Console.WriteLine("-------------------------------------------------------------");
            #endregion
        }

        #region Q2
        /*
         * 2.	Write a method call CubeIt(int x, ref int cube) that takes two arguments and does not return a value. 
         * The method will cube the first argument and assign it to the second argument. 
         * In your main create two variables and print them, 
         * call this method and print the value of both of the parameters after the method call. 
         * Change the first parameter and repeat.
         */

        private static void CubeIt(int x, ref int cube)
        {
            cube = x * x * x;
        }
        #endregion

        #region Q3
        /*
         * 3.	Write a method with the following header: static void CalculateTuitionFee(int numberOfCourses, double costPerCourse, ref double fees). 
         * This method will calculate and assign the required fees amount to the third argument. 
         * [Fees = number of courses * cost per course + 15.25]. [Use variable when invoking the method and when printing.]
         * From your program Main() method, call the CalculateTuitionFee () method 
         * four times supplying different arguments each time and display the value of the third argument after each method call.
         */
        static void CalculateTuitionFee(int numberOfCourses, double costPerCourse, ref double fees)
        {
            fees = costPerCourse * numberOfCourses + 15.25;
        }
        #endregion

        #region Q4
        /*
         * 4.	Write a method that takes four parameter of type int. 
         * The method will assign the sum of the first two arguments to the third and the difference of the first two to the fourth. 
         * This method should be coded so that the calling method will use the value of the third and fourth parameters. 
         * [Do not use the Math.Abs() method.]  
         * Call this method about three times and print out the value of the four parameters after each method call.
         */
        private static void SumAndDifference(int b, int c, ref int sum, ref int difference)
        {
            sum = b + c;
            /*if (sum < 0)
                sum = sum * -1;*/
            difference = b - c;
            if (difference < 0)
                difference = difference * -1;
        }
        #endregion

        #region Q5
        /*
         * 5. Write a method with header static void CalculateTrigValues(double degrees, out double sine, out double cosine, out double tangent). 
         * The method will use the first argument to compute the values of the other three arguments. 
         * Used the method Math.Sin, Math.Cos and Math.Tan to compute the second to fourth arguments respectively. [radians = degrees * Math.Pi /180]. 
         * In the Main() method, invoke this method 20 times with the first argument taking the values 0, 5, 10, … 95 
         * and display the four arguments in a professional tabular format.
         */
        private static void CalculateTrigValues(double degrees, out double sine, out double cosine, out double tangent)
        {
            double radians = degrees * Math.PI / 180;
            sine = Math.Sin(radians);
            cosine = Math.Cos(radians);
            tangent = Math.Tan(radians);
        }
        #endregion

        #region Q6
        /*
         * 6. Write a method that takes three parameters of type double: the first represents an angle, 
         * the other two represents the sine and cosine of the angle respectively. 
         * The method must be able to change the actual value of the second and third argument. 
         * In your Main() method, call this method ten times with values 0.50, 0.51, 0.52 … 0.59 
         * and printout the values for angle, sine and cosine in a tabular format
         */
        private static void SineCosine(double values, out double sine, out double cosine)
        {
            sine = Math.Sin(values);
            cosine = Math.Cos(values);
        }
        #endregion
    }
}
