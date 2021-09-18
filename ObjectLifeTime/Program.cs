using System;
using ObjectLifTime;

namespace ObjectLifeTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            //myCar.Maker = "Porsche";
            //myCar.Model = "Taycan";
            //myCar.Year = 2020;
            //myCar.Color = "OceanBlue";

            Console.WriteLine("{0} {1} {2} {3}", myCar.Maker, myCar.Model, myCar.Year, myCar.Color);

            Car myOtherCar;
            myOtherCar = myCar;
            //myOtherCar.Maker = "Porsche";
            myOtherCar.Model = "Macan";
            myOtherCar.Year = 2020;
            myOtherCar.Color = "OceanBlue";

            Console.WriteLine("{0} {1} {2} {3}", myOtherCar.Maker, myOtherCar.Model, myOtherCar.Year, myOtherCar.Color);
            myOtherCar = null;
            //Console.WriteLine("{0} {1} {2} {3}", myOtherCar.Maker, myOtherCar.Model, myOtherCar.Year, myOtherCar.Color);
            Console.WriteLine("{0} {1} {2} {3}", myCar.Maker, myCar.Model, myCar.Year, myCar.Color);

            var result = myCar.MarketValue();
            Console.WriteLine("{0:C}", result);
            Car.IShout();
        }
    }

    
}
