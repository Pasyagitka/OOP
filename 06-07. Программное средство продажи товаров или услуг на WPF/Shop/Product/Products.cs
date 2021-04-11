using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Product
{
    public class Products
    {
        private static Products instance;
        private List<Sweetness> products;

        private Products() 
        {
            products = new List<Sweetness>();
        }

        public static Products GetInstance()
        {
            if (instance == null) instance = new Products();
            return instance;
        }

        #region Commands
        public void Add(Sweetness sweetness)
        {
            products.Add(sweetness);
        }
        public void Remove(Sweetness sweetness)
        {
            products.Remove(sweetness);
        }

        public void Sort()
        {
            
        }
        #endregion

        #region Serialization
        public void Serialize()
        {

        }
        public void Deserialize()
        {

        }
        #endregion
    }
}
