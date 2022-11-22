using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] vowles = { 'a', 'e', 'i', 'o', 'u' };
            int[] primes = { 2, 3, 5, 7, 11, 17, 19 };

            string[] poem = "Mary had a little lamb".Split();
            char[] letters = "Narendra".ToCharArray();


            Console.WriteLine(primes[2]);
            Console.WriteLine(vowles[0]);

            Console.WriteLine(poem[3]);
            Console.WriteLine(letters[1]);
        }
    }
}
