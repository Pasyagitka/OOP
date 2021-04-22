using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Shop.Product
{
    public class Products
    {
        private static Products instance;
        private ObservableCollection<Sweetness> products;
        const string filepath = "..//..//Files/Products.json";
        static DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(ObservableCollection<Sweetness>));

        private Products() 
        {
            products = new ObservableCollection<Sweetness>();
        }

        public static Products GetInstance()
        {
            if (instance == null) instance = new Products();
            return instance;
        }

        public ObservableCollection<Sweetness> SweetnessesList
        {
            get => products;
            set => products = value;
        }

        public Sweetness FindByName(string sweetness)
        {
            return products.Where(x => x.Name == sweetness).FirstOrDefault();
        }

        #region Commands
        //HACK Фк-ции Command
        public void Add(Sweetness sweetness)
        {
            products.Add(sweetness);
        }
        public void Remove(string sweetness)
        {
            products.Remove(products.Where(x => x.Name == sweetness).FirstOrDefault());
        }

        #endregion

        #region Serialization
        public void ExportProducts()
        {
            using (var fs = new FileStream(filepath, FileMode.Create))
            {
                jsonFormatter.WriteObject(fs, products);
            }
        }
        public void ImportProducts()
        {
            using (var file = new FileStream(filepath, FileMode.OpenOrCreate))
            {
                
                var list = jsonFormatter.ReadObject(file) as ObservableCollection<Sweetness>;
                if (list != null)
                { 
                    foreach (var f in list)
                        products.Add(f);
                }
            }
        }
        #endregion
    }
}
