using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class A_100Flat : IFlat
    {
        public string Type => "A-100 Flat";
        public override string ToString()
        {
            return Type;
        }
    }
}
