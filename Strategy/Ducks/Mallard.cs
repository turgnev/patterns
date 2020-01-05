using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class Mallard : Duck
    {
        public Mallard(IFlyingBehaviour flyingBehaviour)
        {
            this.FlightModule = flyingBehaviour;
        }
    }
}
