using System;
namespace ObjectLifTime
{
    public class Car
    {
        public string Maker { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public Car()
        {
            Maker = "Porsche";
        }
        //public Car(string maker, string model, int year, string color)
        //{
        //    Maker = maker;
        //    Model = model;
        //    Year = year;
        //    Color = color;

        //}
        public static void IShout()
        {
            Console.WriteLine("I've learned in last two days more than in entire month!");
        }
        public decimal MarketValue()
        {
            decimal value;
            if (Year < 2010)
            {
                value = 2000.0M;
            }
            value = 10000.0M;
            return value;
            
        }
    }
}
