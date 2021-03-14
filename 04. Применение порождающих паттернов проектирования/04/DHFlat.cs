using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class DHFlat : IFlat
    {
        public string Type => "Dana Holdings Flat";
        public override string ToString()
        {
            return Type;
        }
    }
}
