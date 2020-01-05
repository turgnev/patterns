using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public abstract class Duck
    {
        public void Swim()
        {
            Console.WriteLine("Swimming");
        }

        protected IFlyingBehaviour FlightModule;

        public void Fly()
        {
            this.FlightModule.Fly();
        }
    }
}
