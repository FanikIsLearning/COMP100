using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 
 */

namespace method1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DisplayPersonalInformation();
            //DisplayAreaOfCircle(1);
            //DisplayAreaOfCircle(10);
            //double tax = CalculateTax(10);
            //Console.WriteLine($"The tax is {tax:C}");
            double r = 10, h = 5;
            bool topAndBottom = true;
            Console.WriteLine($"Radius:{r:F}, height:{h:F} and topAndBottom:{topAndBottom}");
            Console.WriteLine($"the return value is {CalculateSurfaceAreaOfCylinder(r, h, topAndBottom)}");
            Console.WriteLine($"the return value is {CalculateSurfaceAreaOfCylinder(h, r, topAndBottom)}");
        }
        #region Question 1
        /*
         * 1.	Write a method with the following specifications:
         * name: DisplayPersonalInformation
         * arguments: none
         * return value: none
         * tasks: displays your name, program and favorite course. 
         * Call this method from your main.
         */
        static void DisplayPersonalInformation()
        {
            Console.WriteLine("Ivan Fan");
            Console.WriteLine("Software - web");
            Console.WriteLine("Programming 1");
        }
        #endregion

        #region Question 2
        /*
         * 2.	Write a method with the following specifications:
         * name: DisplayAreaOfCircle
         * arguments: double representing the radius of the circle 
         * return value: none
         * tasks: calculates and display the area of the circle. Area = πr2
         * In your main you will call this method twice, with argument 1 and 10;
         */
        static void DisplayAreaOfCircle(double radius)
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine($"A circle of radius {radius:F} will have an area {area:F}");
        }
        #endregion

        #region Question 3
        /*
         * 3.	Write a method with the following specifications:
         * name: CalculateTax
         * arguments: double representing the price of an item 
         * return value: double representing the tax of this item 
         * displays: nothing 
         * tasks: calculates and return the tax on this item. Tax =14% of price.
         * 
         * In your main you will call this method with a value of 10 and assign the return value to a variable tax, 
         * then print the value of tax using the currency specifier.
         */
        static double CalculateTax(double price)
        {
            double tax = price * 0.13;
            return tax;
            
        }
        #endregion

        #region Question 4
        /*
         * 3. Write a method to calculate and return the surface area of a cylinder.
         * The method requires radius, height and a bool indicating if to include
         * the top and bottom in the computation.
         */
        static double CalculateSurfaceAreaOfCylinder(double radius, double height, bool includeTopAndBottom)
        {
            double area = 2 * Math.PI * radius * height;
            if(includeTopAndBottom)
            {
                area += 2 * Math.PI * radius * radius;
            }
            return area;
        }
        #endregion

    }
}
