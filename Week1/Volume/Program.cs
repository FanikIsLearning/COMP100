using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volume
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            int length, width, height;
            //Processing

            //output
            int volume;
            //Algorithm
            Console.Write("Enter the length ");
            length = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the width ");
            width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the height ");
            height = Convert.ToInt32(Console.ReadLine());
            volume = length * width * height;
            Console.WriteLine(volume);
            Console.ReadLine();

        }
    }
}
