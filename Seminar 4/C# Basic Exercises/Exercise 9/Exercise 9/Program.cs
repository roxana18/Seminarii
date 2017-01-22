using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9
{
    //Write a C# Sharp program that takes four numbers as input to calculate and print the average. 
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number3, number4, average;
            Console.Write("Enter the First number: ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the Second number: ");
            number2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            number3 = int.Parse(Console.ReadLine());
            Console.Write("Enter the four number: ");
            number4 = int.Parse(Console.ReadLine());
            average = (number1 + number2 + number3 + number4) / 4;
            Console.WriteLine("The average of " + number1 + ", " + number2 + ", " + number3 + ", " + number4 + " is: " + average);
            Console.ReadKey();
        }
    }
}
