using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_12
{
    //Write a C# program to that takes a number as input and display it four times in a row (separated with blank spaces), and then four times in the next row, with no separation. You should do it two times: Use Console. Write and then use {0}
    class Program
    {
        static void Main(string[] args)
        {
            int number, counter;
            Console.Write("Enter a digit: ");
            number = Convert.ToInt32(Console.ReadLine());
            for (counter = 0; counter < 2; counter++)
            {
                Console.WriteLine("{0} {0} {0} {0}", number);
                Console.WriteLine("{0}{0}{0}{0}", number);
            }
            Console.ReadKey();
        }
    }
}
