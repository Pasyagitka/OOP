using Shop.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Shop.Command;

namespace Shop
{
    /// <summary>
    /// Логика взаимодействия для AddProduct.xaml
    /// </summary>
    public partial class AddProduct : Window
    {
        private Invoker invoker;
        public AddProduct()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            //
            Sweetness sw = SweetsFactory.CreateSweet((Sweets)typeCB.SelectedIndex, nameTB.Text, imageTB.Text, Convert.ToDouble(weightTB.Text), 
                Convert.ToInt32(caloriesTB.Text), descriptionTB.Text, trademarkTB.Text, Convert.ToInt32(priceTB.Text));
            
            invoker ??= new Invoker();
            var command = new AddCommand(sw);
            invoker.SetCommand(command);
            invoker.Run();
            this.Close();
        }
    }
}
