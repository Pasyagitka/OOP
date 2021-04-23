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
            Sweetness sw = SweetsFactory.CreateSweet((Sweets)AddProductUserControl.typeCB.SelectedIndex, 
                AddProductUserControl.NameTextBlockText, 
                AddProductUserControl.ImageTextBlockText, 
                Convert.ToDouble(AddProductUserControl.WeightTextBlockText), 
                Convert.ToInt32(AddProductUserControl.CaloriesTextBlockText),
                AddProductUserControl.DescriptionTextBlockText, 
                AddProductUserControl.TrademarkTextBlockText, 
                Convert.ToInt32(AddProductUserControl.PriceTextBlockText));
            
            invoker ??= new Invoker();
            var command = new AddCommand(sw);
            invoker.SetCommand(command);
            invoker.Run();
            this.Close();
        }

        // private void AddProductUserControl_OnTap(object sender, RoutedEventArgs e)
        // {
        //     this.Background = new SolidColorBrush(Colors.Black );
        // }
    }
}
