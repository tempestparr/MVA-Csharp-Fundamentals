using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            // lists and dictionaries

            //Car car1 = new Car();
            //car1.Make = "Oldsmobile";
            //car1.Model = "Cutlas Supreme";
            //car1.VIN = "1234567";

            //Car car2 = new Car();
            //car2.Make = "Geo";
            //car2.Model = "Prism";
            //car2.VIN = "65453";

            //Book b1 = new Book();
            //b1.Author = "Robert Tabor";
            //b1.Title = "Microsoft .NET XML Web Services";
            //b1.ISBN = "0-000-00000-0";

            // OLD STYLE ArrayLists - no restriction on type
            // that can be added to the list
            //ArrayList myArrayList = new ArrayList();
            //myArrayList.Add(car1);
            //myArrayList.Add(car2);
            //myArrayList.Add(b1);

            //foreach (Car car in myArrayList)
            //{
            //    Console.WriteLine(car.Make);
            //}

            // NEW STYLE 
            // List<T>
            //List<Car> myList = new List<Car>();
            //myList.Add(car1);
            //myList.Add(car2);
            //myList.Add(b1);

            //foreach (Car car in myList)
            //{
            //    Console.WriteLine(car.Model);
            //}

            // Dictionary<TKey, TValue>
            //Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            //myDictionary.Add(car1.VIN, car1);
            //myDictionary.Add(car2.VIN, car2);

            //Console.WriteLine(myDictionary["65453"].Make);


            // Initialize objects at the point of instantiation
            // No need for constructor
            //Car car1 = new Car() { Make = "BMW", Model = "750li", VIN = "012345" };
            //Car car2 = new Car() { Make = "Toyota", Model = "4Runner", VIN = "4231" };

            // Collection initializer
            List<Car> myList = new List<Car>()
            {
                new Car { Make = "Oldsmobile", Model = "Cutlas Supreme", VIN = "12" },
                new Car { Make = "Nissan", Model = "Altima", VIN = "32" }
            };

            Console.ReadLine();

        }

        class Car
        {
            public string VIN { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
        }

        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public string ISBN { get; set; }
        }
    }
}
