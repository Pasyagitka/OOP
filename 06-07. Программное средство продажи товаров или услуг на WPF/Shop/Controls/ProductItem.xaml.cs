using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Shop.Command;
using Shop.Product;

namespace Shop.Controls
{
    public partial class ProductItem : UserControl
    {
        private Invoker invoker;

        public ProductItem()
        {
            InitializeComponent();
        }

        // public ProductItem(Sweetness sw)
        // {
        //     InitializeComponent();
        //     TitleTextBlock.Text = sw.name;
        //     if (sw.image != null && sw.image.Length>0)
        //     {
        //         ImageSourceConverter imgs = new ImageSourceConverter();
        //         MainItemImage.SetValue(Image.SourceProperty, imgs.ConvertFromString(sw.image));
        //     }
        //     PriceTextBlock.Text = Convert.ToString(sw.price) + "$";
        //     ShortDescriptionTextBlock.Text = sw.description;
        // }
        //private void Item_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        //{
        //    MainGrid.Background = new SolidColorBrush(Colors.SeaShell);
        //}

        //private void Item_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        //{
        //    MainGrid.Background = new SolidColorBrush(Colors.White);
        //}

        private void DeleteProductButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            invoker ??= new Invoker();
            var command = new DeleteCommand(this.TitleTextBlock.Text);
            invoker.SetCommand(command);
            invoker.Run();
        }

        private void EditProductButton_Click(object sender, RoutedEventArgs e)
        {
            EditProduct ep = new EditProduct(Products.GetInstance().FindByName(this.TitleTextBlock.Text));
            ep.Show();
        }
    }
}