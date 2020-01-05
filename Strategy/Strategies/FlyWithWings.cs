using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class FlyWithWings : IFlyingBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("Flying");
        }
    }
}
