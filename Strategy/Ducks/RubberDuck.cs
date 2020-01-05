using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class RubberDuck : Duck
    {
        public RubberDuck(IFlyingBehaviour flyingBehaviour)
        {
            this.FlightModule = flyingBehaviour;
        }
    }
}
