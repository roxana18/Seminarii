using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise 4
            Mercedes mercedes = new Mercedes();
            //AbstractCar aCar = new AbstractCar(); =>abstract classes cannot be instantiated

            //Exercise 6
            ICar car = new Mercedes();
            AbstractCar car2 = new Mercedes();

            //Exercise 7
            Console.WriteLine("Mercedes is " + mercedes.description);
            Console.WriteLine("Mercedes costs " + mercedes.price);

            //Exercise 8 
            mercedes.Description = "E Class ";
            mercedes.Price = 50;
            Console.WriteLine(mercedes.Description);
            Console.WriteLine(mercedes.Price);

            //Exercise 5
            EngineStruct engine = new EngineStruct();

            //Exercise 1
            Console.WriteLine("This is my first C# project!");
            Console.ReadKey();
        }
    }

    struct EngineStruct
    {
    }
}
