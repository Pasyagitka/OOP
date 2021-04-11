using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Product
{
    class Candy : Sweetness
    {
        internal Candy(string name, double weight, int calories, string description, string trademark)
        {
            this.name = name;
            this.weight = weight;
            this.calories = calories;
            this.description = description;
            this.trademark = trademark;
        }
    }
}
