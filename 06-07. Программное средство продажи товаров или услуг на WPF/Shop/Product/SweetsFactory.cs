using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Product
{
    public class SweetsFactory
    {
        public Sweetness CreateSweet(Sweets sweets, string name, double weight, int calories, string description,
            string trademark)
        {
            switch (sweets)
            {
                case Sweets.Chocolate:
                {
                    return new Chocolate(name, weight, calories, description, trademark);
                }
                case Sweets.Candy:
                {
                    return new Candy(name, weight, calories, description, trademark);
                }
                case Sweets.Marmelade:
                {
                    return new Marmalade(name, weight, calories, description, trademark);
                }
                case Sweets.Waffle:
                {
                    return new Waffles(name, weight, calories, description, trademark);
                }
                default:
                {
                    return null;
                }
            }
        }
    }
}
