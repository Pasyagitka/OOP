using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class DanaHoldings : IDeveloper
    {
        public IFlat GetFlat()
        {
            return new DHFlat();
        }

        public IHouse GetHouse()
        {
            return new DHHouse();
        }
    }
}
