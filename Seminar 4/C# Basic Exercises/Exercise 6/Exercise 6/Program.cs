using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    //Write a C# Sharp program to print the output of multiplication of three numbers which will entered by the user
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number3;
            Console.Write("Input the first number to multiply: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Input the second number to multiply: ");
            number2 = int.Parse(Console.ReadLine());
            Console.Write("Input the third number to multiply: ");
            number3 = int.Parse(Console.ReadLine());
            Console.WriteLine(number1 + " x " + number2 + " x " + number3 + " = " + (number1 * number2 * number3));
            Console.ReadKey();
        }
    }
}
