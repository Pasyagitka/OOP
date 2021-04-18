using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Controls;
using Shop.Product;

namespace Shop.Controls
{
    public partial class ProductContainer : UserControl
    {
        public ProductContainer()
        {
            InitializeComponent();
            ShoppingCardsList.ItemsSource = Products.GetInstance().SweetnessesList;
        }

        public void CategoryUpdate(int filterIndex)
        {
            switch (filterIndex)
            {
                case 0:
                    {
                        ShoppingCardsList.ItemsSource = new ObservableCollection<Sweetness>(Products.GetInstance().SweetnessesList.Where(x => x is Candy));
                        break;
                    }
                case 1:
                    {
                        ShoppingCardsList.ItemsSource = new ObservableCollection<Sweetness>(Products.GetInstance().SweetnessesList.Where(x => x is Chocolate));
                        break;
                    }
                case 2:
                    {
                        ShoppingCardsList.ItemsSource = new ObservableCollection<Sweetness>(Products.GetInstance().SweetnessesList.Where(x => x is Marmalade));
                        break;
                    }
                case 3:
                    {
                        ShoppingCardsList.ItemsSource = new ObservableCollection<Sweetness>(Products.GetInstance().SweetnessesList.Where(x => x is Waffles));
                        break;
                    }
                default:
                    {
                        ShoppingCardsList.ItemsSource = Products.GetInstance().SweetnessesList;
                        break;
                    }
            }
        }

        public void SortUpdate(int sortIndex)
        {
            switch (sortIndex)
            {
                case 0:
                    {
                        ShoppingCardsList.ItemsSource = new ObservableCollection<Sweetness>(Products.GetInstance().SweetnessesList.OrderByDescending(x=>x.Price));
                        break;
                    }
                case 1:
                    {
                        ShoppingCardsList.ItemsSource = new ObservableCollection<Sweetness>(Products.GetInstance().SweetnessesList.OrderBy(x => x.Price));
                        break;
                    }
                case 2:
                    {
                        ShoppingCardsList.ItemsSource = new ObservableCollection<Sweetness>(Products.GetInstance().SweetnessesList.OrderBy(x => x.Name));
                        break;
                    }
                default:
                    {
                        ShoppingCardsList.ItemsSource = Products.GetInstance().SweetnessesList;
                        break;
                    }
            }
        }

        public void SearchUpdate(string search, int i)
        {
            if (i == 0)
            {
                ShoppingCardsList.ItemsSource = new ObservableCollection<Sweetness>(Products.GetInstance().SweetnessesList.Where(x => x.ToString().Contains(search)).ToList());
            }
            else
            {
                ShoppingCardsList.ItemsSource = Products.GetInstance().SweetnessesList;
            }
        }
    }
}