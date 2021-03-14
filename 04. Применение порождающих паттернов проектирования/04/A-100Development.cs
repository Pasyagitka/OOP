using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class A_100Development : IDeveloper
    {
        public IFlat GetFlat()
        {
            return new A_100Flat();
        }

        public IHouse GetHouse()
        {
            return new A_100House();
        }
    }
}
