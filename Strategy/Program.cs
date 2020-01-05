using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var Duck1 = new DecoyDuck(new FlyNoWay());

            var Duck2 = new Mallard(new FlyWithWings());

            var Duck3 = new RubberDuck(new FlyNoWay());

            Duck1.Fly();
            Duck2.Fly();
            Duck3.Fly();

            Console.ReadKey();
        }
    }
}
