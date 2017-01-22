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
           
            Mercedes mercedes = new Mercedes();
            //Course 3
            Console.WriteLine(mercedes.StartEngine());
            Console.WriteLine("Remaining km: " + mercedes.ShowRemainingNoOFKM(150,100));   

                //Course 2
            //ICar car = new Mercedes();
            //AbstractCar car2 = new Mercedes();

            //Console.WriteLine("Mercedes is " + mercedes.description);
            //Console.WriteLine("Mercedes costs " + mercedes.price);

            //mercedes.Description = "E Class ";
            //mercedes.Price = 50;
            //Console.WriteLine(mercedes.Description);
            //Console.WriteLine(mercedes.Price);
            //EngineStruct engine = new EngineStruct();

            //Console.WriteLine("This is my first C# project!");
            Console.ReadKey();
        }
    }

    struct EngineStruct
    {
    }
}
