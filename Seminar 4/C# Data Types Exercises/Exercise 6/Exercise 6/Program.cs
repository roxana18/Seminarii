using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_6
{
    // Write a C# Sharp program to display certain values of the function x = y2 + 2y + 1 (using integer numbers for y , ranging from -5 to +5). 
    class Program
    {
        static void Main(string[] args)
        {
            int y;
            double x;
            for (y = -5; y <= 5; y++)
            {
                x = y * y + 2 * y + 1;
                Console.WriteLine("y = {0}; \nx = {0} * {0} + 2 * {0} + 1 = {1} \n", y, x); 
            }
            Console.ReadKey();
        }
    }
}
