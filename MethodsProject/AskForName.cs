using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsProject
{
    public class AskForName
    {
        public static string RequestName()
        {
            Console.Write("What is your name?: ");

            string guestName = Console.ReadLine();

            return guestName;
        }




        public static void GreetUser(string name)
        {

            Console.WriteLine($"Hello, {name}!");
        }
    }
}