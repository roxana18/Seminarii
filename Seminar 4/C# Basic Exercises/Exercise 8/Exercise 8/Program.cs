using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8
{
    //Write a C# Sharp program that takes a number as input and print its multiplication table. 
    class Program
    {
        static void Main(string[] args)
        {
            int number1, counter;
            Console.Write("Expected Output: ");
            number1 = int.Parse(Console.ReadLine());
            for (counter = 0; counter <= 10; counter++)
            {
                Console.WriteLine(number1 + " * " + counter + " = " + (number1 * counter));
            }
            Console.ReadKey();
        }
    }
}
