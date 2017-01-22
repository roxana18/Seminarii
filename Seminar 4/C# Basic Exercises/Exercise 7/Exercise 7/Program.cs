using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    //Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing of two numbers which will entered by the user. 
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            Console.Write("Input the first number: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Input the second number: ");
            number2 = int.Parse(Console.ReadLine());
            Console.WriteLine(number1 + " + " + number2 + " = " + (number1 + number2));
            Console.WriteLine(number1 + " - " + number2 + " = " + (number1 - number2));
            Console.WriteLine(number1 + " x " + number2 + " = " + (number1 * number2));
            Console.WriteLine(number1 + " / " + number2 + " = " + (number1 / number2));
            Console.WriteLine(number1 + " mod " + number2 + " = " + (number1 % number2));
            Console.ReadLine();
        }
    }
}
