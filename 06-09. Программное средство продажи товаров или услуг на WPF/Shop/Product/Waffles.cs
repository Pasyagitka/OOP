﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Shop.Product
{
    [Serializable]
    class Waffles : Sweetness
    {
        internal Waffles(string name, string image, double weight, int calories, string description, string trademark, int price)
        {
            this.name = name;
            this.image = image;
            this.weight = weight;
            this.calories = calories;
            this.description = description;
            this.trademark = trademark;
            this.price = price;
        }
    }
}
