using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    // Write a C# Sharp program that takes userid and password as input (type string). After 3 wrong attempts user will be rejected
    class Program
    {
        static void Main(string[] args)
        {
            string username = "", password = "";
            int counter = 0;
            Console.WriteLine("Check username and password:");
            Console.WriteLine("Default username and password is: username and password");
            while ((username != "username" && password != "password") && counter < 3)
            {
                if (counter != 0)
                {
                    Console.WriteLine("Wrong username or password!");
                }
                Console.Write("Input a username: ");
                username = Console.ReadLine();
                Console.Write("Input a passsword: ");
                password = Console.ReadLine();
                counter++;
            }
            if (username == "username" && password == "password")
            {
                Console.WriteLine("Password entered successfull!");
            } else {
                Console.WriteLine("Login attemp more than three times. Try later!");
            }
            Console.ReadKey();
            
        }
    }
}
