using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
using Shop.Product;

namespace Shop
{
    /// <summary>
    /// Логика взаимодействия для EditProduct.xaml
    /// </summary>
    public partial class EditProduct : Window
    {
        Sweetness tsw;
        public EditProduct(Sweetness sw)
        {
            InitializeComponent();

            tsw = sw;
            nameTB.Text = tsw.Name;
            imageTB.Text = tsw.Image;
            weightTB.Text = tsw.Weight.ToString();
            caloriesTB.Text = tsw.Calories.ToString();
            descriptionTB.Text = tsw.Description;
            trademarkTB.Text = tsw.Trademark;
            priceTB.Text = tsw.Price.ToString();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            Window_Closing();
            this.Close();
        }

        private void Deny_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Window_Closing()
        {
            tsw.Name = nameTB.Text;
            tsw.Image = imageTB.Text;
            tsw.Weight = Convert.ToDouble(weightTB.Text);
            tsw.Calories = Convert.ToInt32(caloriesTB.Text);
            tsw.Description = descriptionTB.Text;
            tsw.Trademark = trademarkTB.Text;
            tsw.Price = Convert.ToInt32(priceTB.Text);
            
        }
    }
}
