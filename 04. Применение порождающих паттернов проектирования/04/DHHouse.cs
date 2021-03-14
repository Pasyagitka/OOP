using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class DHHouse : IHouse
    {
        public string Type => "Dana Holdings House";
        public override string ToString()
        {
            return Type;
        }
    }
}
