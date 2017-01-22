using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    //Write a C# Sharp program that takes two numbers as input and perform an operation (+,-,*,x,/) on them and displays the result of that operation. 
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;
            char operation;
            Console.Write("Input first number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input operation: ");
            operation = Convert.ToChar(Console.ReadLine());
            Console.Write("Input second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            switch (operation) {
                case '-':
                    Console.WriteLine("{0} - {1} = {2}", number1, number2, number1 - number2);
                    break;
                case '+':
                    Console.WriteLine("{0} + {1} = {2}", number1, number2, number1 + number2);
                    break;
                case 'x':
                    Console.WriteLine("{0} x {1} = {2}", number1, number2, number1 * number2);
                    break;
                case '/':
                    Console.WriteLine("{0} + {1} = {2}", number1, number2, number1 / number2);
                    break;
                default:
                    Console.WriteLine("Invalid operation! ");
                    break;
            }
            Console.ReadKey();
        }
    }
}
