using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x;
            //int y;

            //x = 7;
            //y = x + 3;
            //Console.WriteLine(y);
            //Console.ReadLine();

            Console.WriteLine("What is your first name?");
            Console.Write("Type your first name here: ");
            string myFirstName;
            myFirstName = Console.ReadLine();

            //Console.Write("Type your last name here: ");
            //string myLastName;
            //myLastName = Console.ReadLine();

            Console.Write("Type your last name here: ");
            string myLastName = Console.ReadLine();

            Console.WriteLine("Hello " + myFirstName + " " + myLastName);
            Console.ReadLine();
        }
    }
}
