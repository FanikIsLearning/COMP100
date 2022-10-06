using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * The average cost of a college textbook is $125. 
 * There is a premium of 20% on hardcover text and a discount of 5% on sales of more than 4 textbooks. 
 * Write a program to prompt the user for the appropriate inputs and 
 * compute and display the before-tax cost of the textbooks.
 */

namespace Q7_Textbook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Which textbook do your prefer? Hardcover or normal? ");
            string cover = Console.ReadLine();

            double bookPrice = 125;

            if (cover == "hardcover" || cover == "Hardcover")
            {
                Console.Write("How many textbooks do you want? ");

                int textbook = Convert.ToInt32(Console.ReadLine());
                double price = textbook * bookPrice;
                double premium = price * 0.2;
                double discount = price * 0.05;

                if (textbook > 4)
                {
                    double cost = price + premium - discount;
                    Console.WriteLine($"{textbook} of textbooks cost {cost:c}.");
                }
                else
                {
                    double cost = price + premium;
                    Console.WriteLine($"{textbook} of textbooks cost {cost:c}.");
                }
            }
            else if (cover == "normal" || cover == "Normal")
            {
                Console.Write("How many textbooks do you want? ");
                int textbook = Convert.ToInt32(Console.ReadLine());
                double price = textbook * bookPrice;
                double discount = price * 0.05;

                if (textbook > 4)
                {
                    double cost = price - discount;
                    Console.WriteLine($"{textbook} of textbooks cost {cost:c}.");
                }
                else
                {
                    double cost = price;
                    Console.WriteLine($"{textbook} of textbooks cost {cost:c}.");
                }
            }
            else
            {
                Console.WriteLine("please enter either 'hardcover' or 'normal'");
            }

            Console.ReadLine();
        }
    }
}
