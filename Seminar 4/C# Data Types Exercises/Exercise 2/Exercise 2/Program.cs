using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    //Write a C# Sharp program that takes a number and a width also a number, as input and then displays a triangle of that width, using that number. 
    class Program
    {
        static void Main(string[] args)
        {
            int number, width, row, temp, counter;
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the desired width: ");
            width = Convert.ToInt32(Console.ReadLine());
            temp = width;
            for (row = 0; row < width; row++)
            {
                for (counter = 0; counter < temp; counter++)
                {
                    Console.Write(number);
                }
                temp--;
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
