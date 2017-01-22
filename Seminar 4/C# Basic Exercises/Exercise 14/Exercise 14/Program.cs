using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_14
{
    //Write a C# Sharp program to convert from celsius degrees to Kelvin and Fahrenheit.
    class Program
    {
        static void Main(string[] args)
        {
            int celsius, kelvin, fahrenheit;
            Console.Write("Enter amount of celsius: "); 
            celsius = Convert.ToInt32(Console.ReadLine());
            kelvin = celsius + 273;
            fahrenheit = celsius * 18 / 10 + 32;
            Console.WriteLine("Kelvin = {0} \nFahrenheit = {1}", kelvin, fahrenheit);
            Console.ReadKey();
        }
    }
}
