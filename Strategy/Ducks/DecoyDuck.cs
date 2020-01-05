using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class DecoyDuck : Duck
    {
        public DecoyDuck(IFlyingBehaviour flyingBehaviour)
        {
            this.FlightModule = flyingBehaviour;
        }
    }
}
