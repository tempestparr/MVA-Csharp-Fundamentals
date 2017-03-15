using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingLINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            // Language Integrated Query
            List<Car> myCars = new List<Car>()
            {
                new Car() { VIN = "A1", Make = "BMW", Model = "550i", Year = 2016, StickerPrice = 55000 },
                new Car() { VIN = "B1", Make = "Toyota", Model = "Prius", Year = 2016, StickerPrice = 35000 },
                new Car() { VIN = "C1", Make = "Ford", Model = "Fiesta", Year = 2017, StickerPrice = 35000 },
                new Car() { VIN = "D1", Make = "Subaru", Model = "BRZ", Year = 2015, StickerPrice = 28000 },
                new Car() { VIN = "E1", Make = "Toyota", Model = "Camry", Year = 2014, StickerPrice = 35000 },
            };

            // LINQ query
            //var toyotas = from car in myCars
            //              where car.Make == "Toyota"
            //              && car.Year == 2014
            //              select car;

            //var orderedCars = from car in myCars
            //                  orderby car.Year descending
            //                  select car;

            // LINQ method
            var toyotas = myCars.Where(p => p.Make == "Toyota" && p.Year == 2014);
            // given p, an instance of the collection, only return back the instances
            // where the car make is equal to toyota and the car year is 2014

            var orderedCars = myCars.OrderByDescending(p => p.Year );

            //var firstToyota = myCars.OrderByDescending(p => p.Year).First(p => p.Make == "Toyota");
            //Console.WriteLine(firstToyota.VIN);

            //foreach (var car in orderedCars)
            //{
            //    Console.WriteLine("{0} {1} {2}", car.Model, car.VIN, car.Year  );
            //}

            //Console.WriteLine(myCars.TrueForAll(p => p.Year > 2016));
            
            //myCars.ForEach(p => p.StickerPrice -= 3000);
            //myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.StickerPrice));

            //Console.WriteLine(myCars.Exists(p => p.Model == "Prius"));

            //Console.WriteLine("{0:C}", myCars.Sum(p => p.StickerPrice));

            //Console.WriteLine(myCars.GetType());

            //Console.WriteLine(orderedCars.GetType());

            //Console.WriteLine(toyotas.GetType());

            var newCars = from car in myCars
                          where car.Make == "Toyota"
                          && car.Year == 2010
                          select new { car.Make, car.Model };

            Console.WriteLine(newCars.GetType());


            Console.ReadLine();
        }
    }

    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double StickerPrice { get; set; }
    }
}
