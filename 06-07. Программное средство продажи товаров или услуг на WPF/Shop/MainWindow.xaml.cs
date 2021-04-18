using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Shop.Controls;
using Shop.Product;

namespace Shop
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
          //TODO вернуть курсор
          this.Cursor = new Cursor("D:\\4 семестр\\ООП\\06-07. Программное средство продажи товаров или услуг на WPF\\Shop\\Cursors\\donut.ani");
          
            App.LanguageChanged += LanguageChanged;
            CultureInfo currLang = App.Language;
            //Заполняем меню смены языка:
            menuLanguage.Items.Clear();
            foreach (var lang in App.Languages)
            {
                MenuItem menuLang = new MenuItem();
                menuLang.Header = lang.DisplayName;
                menuLang.Tag = lang;
                menuLang.IsChecked = lang.Equals(currLang);
                menuLang.Click += ChangeLanguageClick;
                menuLanguage.Items.Add(menuLang);
            }
            //try
            //{
            //    Products.GetInstance().ImportProducts();
            //    _listingDataView = (CollectionViewSource)Products.GetInstance().SweetnessesList;
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show("Ошибка импорта", "Ошибка!");
            //    Console.WriteLine(e.Message);
            //}

            // try
            // {
            //     Products.GetInstance().ExportProducts();
            // }
            // catch
            // {
            //     MessageBox.Show("Ошибка экспорта", "Ошибка!");
            // }
            // foreach (var p in Products)
            // {
            //     
            // }
            //Test.Children.Add(new ProductItem()); 

        }

        #region Local

        private void LanguageChanged(Object sender, EventArgs e)
        {
            CultureInfo currLang = App.Language;
            //Отмечаем нужный пункт смены языка как выбранный язык
            foreach (MenuItem i in menuLanguage.Items)
            {
                CultureInfo ci = i.Tag as CultureInfo;
                i.IsChecked = ci != null && ci.Equals(currLang);
            }
        }

        private void ChangeLanguageClick(Object sender, EventArgs e)
        {
            MenuItem mi = sender as MenuItem;
            if (mi != null)
            {
                CultureInfo lang = mi.Tag as CultureInfo;
                if (lang != null) {
                    App.Language = lang;
                }
            }

        }
        #endregion

        #region WindowButtons
        private void MainWindowClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MainWindowMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void MainWindowTop_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void MainWindowResize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState != WindowState.Maximized)
            {
                this.WindowState = WindowState.Maximized;
                MainWindowResizeIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.WindowMaximize;
            }
            else
            {
                this.WindowState = WindowState.Normal;
                MainWindowResizeIcon.Kind = MaterialDesignThemes.Wpf.PackIconKind.Resize;
            }
        }
        #endregion

        private void SelectCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
             Test.CategoryUpdate(SelectCategory.SelectedIndex);
        }

        private void Sort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Test.SortUpdate(Sort.SelectedIndex);
        }
        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            AddProduct addnewproductwindow = new AddProduct();
            addnewproductwindow.Show();
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            Test.SearchUpdate(SearchTextBox.Text, 0);
        }

        private void SearchDenyButton_Click(object sender, RoutedEventArgs e)
        {
            Test.SearchUpdate(SearchTextBox.Text, 1);
            SearchTextBox.Clear();
        }
    }
}
