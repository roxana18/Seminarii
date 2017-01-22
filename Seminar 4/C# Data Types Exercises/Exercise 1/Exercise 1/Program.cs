using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            char letter1, letter2, letter3;
            Console.Write("Enter letter: ");
            letter1 = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter letter:");
            letter2 = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter letter: ");
            letter3 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("{0} {1} {2}", letter3, letter2, letter1);
            Console.ReadLine();
        }
    }
}
