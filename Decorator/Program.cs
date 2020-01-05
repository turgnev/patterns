using System;

namespace Decorator
{
    abstract class Coffee
    {
        public string Description;

        public decimal Price;
    }

    class Cappuccinno : Coffee
    {
        public Cappuccinno()
        {
            Description = nameof(Cappuccinno);
            Price = 5;
        }
    }

    class MilkDecorator : Coffee
    {
        Coffee baseBeverage;

        public MilkDecorator(Coffee baseBeverage)
        {
            this.baseBeverage = baseBeverage;
            Description = baseBeverage.Description + " + Milk";
            Price = baseBeverage.Price + 3;
        }     
    }

    class SoyDecorator : Coffee
    {
        Coffee baseBeverage;

        public SoyDecorator(Coffee baseBeverage)
        {
            this.baseBeverage = baseBeverage;
            Description = baseBeverage.Description + " + Soy";
            Price = baseBeverage.Price + 2;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var coffee = new SoyDecorator(new MilkDecorator(new Cappuccinno()));

            Console.WriteLine($"{coffee.Description} - {coffee.Price}");
            Console.ReadLine();
        }
    }
}
