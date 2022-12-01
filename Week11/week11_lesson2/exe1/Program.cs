using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Part 4

namespace exe1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoBroken();
            Console.WriteLine("---------------");

            DemoRef();
            Console.WriteLine("---------------");

            DemoOut();
            Console.WriteLine("---------------");
        }

        #region Demo
        static void DemoBroken()
        {
            int a = 10, b = 12;
            Console.WriteLine($"BEFORE EXCHANGE: {a} {b} ");
            ExchangeBroken(a, b);
            Console.WriteLine($"AFTER EXCHANGE: {a} {b} ");
        }

        private static void ExchangeBroken(int first, int second)
        {
            Console.WriteLine($"IN METHOD BEFORE EXCHANGE: {first} {second} ");
            int temp = first;
            first = second;
            second = temp;

            Console.WriteLine($"IN METHOD AFTER EXCHNAGE: {first} {second} ");

        }
        #endregion

        #region DemoRef
        static void DemoRef()
        {
            int a = 10, b = 12;
            Console.WriteLine($"BEFORE EXCHANGE: {a} {b} ");
            ExchangeRef(ref a, ref b);
            Console.WriteLine($"AFTER EXCHANGE: {a} {b} ");
        }

        private static void ExchangeRef(ref int first, ref int second)
        {
            Console.WriteLine($"IN METHOD BEFORE EXCHANGE: {first} {second} ");
            int temp = first;
            first = second;
            second = temp;

            Console.WriteLine($"IN METHOD AFTER EXCHNAGE: {first} {second} ");

        }
        #endregion

        #region DemoOut
        static void DemoOut()
        {
            double radius = 1, area, volume;
            ComputeSphere(radius, out area, out volume);
            Console.WriteLine($"radius: {radius:F} area: {area:F} volume: {volume:F}");
        }

        private static void ComputeSphere(double r, out double a, out double v)
        {
            //Console.WriteLine(a) //out parameter do not have values
            a = 4 * Math.PI * r * r;
            v = 4 * Math.PI * Math.Pow(r, 3) / 3;
        }
        #endregion
    }
}
