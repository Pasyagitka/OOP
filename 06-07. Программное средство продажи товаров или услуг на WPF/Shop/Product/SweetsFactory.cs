using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Shop.Product
{
    public class SweetsFactory
    {
        public static Sweetness CreateSweet(Sweets sweets, string name, string image, double weight, int calories, string description,
            string trademark, int price)
        {
            switch (sweets)
            {
                case Sweets.Chocolate:
                {
                    return new Chocolate(name, image, weight, calories, description, trademark, price);
                }
                case Sweets.Candy:
                {
                    return new Candy(name, image, weight, calories, description, trademark, price);
                }
                case Sweets.Marmelade:
                {
                    return new Marmalade(name,image, weight, calories, description, trademark, price);
                }
                case Sweets.Waffle:
                {
                    return new Waffles(name, image, weight, calories, description, trademark, price);
                }
                default:
                {
                    return null;
                }
            }
        }
    }
}
