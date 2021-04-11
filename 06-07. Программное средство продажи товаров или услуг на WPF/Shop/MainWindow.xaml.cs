using System;
using System.Collections.Generic;
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

namespace Shop
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
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


            Test.Children.Add(new ProductItem()); //TODO TEST ADD
            Test.Children.Add(new ProductItem());
            Test.Children.Add(new ProductItem());
            Test.Children.Add(new ProductItem());
            Test.Children.Add(new ProductItem());
            Test.Children.Add(new ProductItem());
            Test.Children.Add(new ProductItem());
            Test.Children.Add(new ProductItem());
            Test.Children.Add(new ProductItem());
            Test.Children.Add(new ProductItem());
        }

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

        private void MenuDockPanel_MouseEnter(object sender, MouseEventArgs e)
        {
            WaffleDockPanel.Background = new SolidColorBrush(Colors.SeaShell);
        }

        private void MenuDockPanel_MouseLeave(object sender, MouseEventArgs e)
        {
            WaffleDockPanel.Background = new SolidColorBrush(Colors.White);
        }
    }
}
