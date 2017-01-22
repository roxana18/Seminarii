using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_10
{
    //Write a C# Sharp program to that takes three numbers(x,y,z) as input and print the output of (x+y)·z and x·y + y·z. 
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number3, result1, result2;
            Console.Write("Enter first number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter third number: ");
            number3 = Convert.ToInt32(Console.ReadLine());
            result1 = (number1 + number2) * number3;
            result2 = number1 * number2 + number1 * number3;
            Console.WriteLine("Result of specified numbers {0}, {1} and {2}, (x + y)*z is {3} and x * y + x * z is {4}", number1, number2, number3, result1, result2);
            Console.ReadKey();

        }
    }
}
