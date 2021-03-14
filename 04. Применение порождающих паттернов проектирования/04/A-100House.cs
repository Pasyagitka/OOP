using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class A_100House : IHouse
    {
        public string Type => "A-100 House";
        public override string ToString()
        {
            return Type;
        }
    }
}
