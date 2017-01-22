using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_13
{
    //Write a C# program that takes a number as input and then display a rectangle 3 columns wide and 5 rows tall using that digit. 
    class Program
    {
        static void Main(string[] args)
        {
            int number, counter;
            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}{0}{0}", number);
            for (counter = 0; counter < 3; counter++) 
            {
                Console.WriteLine("{0} {0}", number);
            }
            Console.WriteLine("{0}{0}{0}", number);
            Console.ReadLine();
        }
    }
}
