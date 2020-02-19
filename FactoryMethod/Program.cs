using System;

namespace FactoryMethod
{

    abstract class Door
    {
        public string Material;

    }

    class WoodenDoor : Door
    {
        public WoodenDoor()
        {
            this.Material = "wood";
        }
    }

    class SteelDoor : Door
    {
        public SteelDoor()
        {
            this.Material = "steel";
        }
    }

    abstract class DoorMaker
    {
        public abstract Door Create();

    }

    class WDoorMaker : DoorMaker
    {
        public override Door Create()
        {
            return new WoodenDoor();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DoorMaker maker = new WDoorMaker();

            Door a = maker.Create();
            Console.Write(a.Material);

            Console.Read();
        }
    }
}
