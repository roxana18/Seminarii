using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Program
    {
        //. Write a C# Sharp program that takes the radius of a circle as input and calculate the perimeter and area of the circle
        static void Main(string[] args)
        {
            double radius, perimeter;
            double PI = 3.14;
            Console.Write("Input the radius of the circle: ");
            radius = Convert.ToDouble(Console.ReadLine());
            perimeter = 2 * PI * radius;
            Console.WriteLine("Perimeter of Circle : {0}", perimeter);
            Console.ReadKey();


        }
    }
}
