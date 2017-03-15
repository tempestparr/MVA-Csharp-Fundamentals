using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingScope
{
    class Program
    {
        // available to all members of the class
        private static string k = "";

        static void Main(string[] args)
        {
            // Testing how variable scope works

            string j = "";
            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);

                if (i == 9)
                {
                    string l = i.ToString();
                }

                // l is outside of if scope
                //Console.WriteLine(l);
            }

            // i is outside of for scope
            //Console.WriteLine(i);

            Console.WriteLine("outside of the for: " + j);
            Console.WriteLine("outside of the for: " + k);

            HelperMethod();

            Car myCar = new Car();
            // only the public methods are visible to us
            myCar.DoSomething();

            Console.ReadLine();
        }

        static void HelperMethod()
        {
            Console.WriteLine("Value of k from the HelperMethod " + k);
        }
    }

    class Car
    {
        public void DoSomething()
        {
            Console.WriteLine(helperMethod());
        }

        private string helperMethod()
        {
            return "Hello World";
        }
    }
}
