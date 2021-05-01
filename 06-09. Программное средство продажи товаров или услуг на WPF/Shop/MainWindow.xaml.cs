using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using Shop.Product;
using Shop.UndoRedo;

namespace Shop
{
    public partial class MainWindow : Window
    {
        public static AppHistory history = new AppHistory(Products.GetInstance().SweetnessesList);
        public MainWindow()
        {
            InitializeComponent();
            //this.Cursor = new Cursor("E:\\4 семестр\\ООП\\06-07. Программное средство продажи товаров или услуг на WPF\\Shop\\Resources\\Cursors\\donut.ani");

            
            App.LanguageChanged += LanguageChanged;
            CultureInfo currLang = App.Language;
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

        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            AddProduct addnewproductwindow = new AddProduct();
            addnewproductwindow.Show();
        }

        #region FilterSortSearch
        private void SelectCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
             Test.CategoryUpdate(SelectCategory.SelectedIndex);
        }

        private void Sort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Test.SortUpdate(Sort.SelectedIndex);
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
        #endregion

        #region UndoRedo
        private void UndoButton_OnClick(object sender, RoutedEventArgs e)
        {
            object undo = history.Undo();
            if (undo != null)
            {
                Products.GetInstance().SweetnessesList = ((Memento) undo).sweetnessState;
                Test.Update();
            }
        }

        private void RedoButton_OnClick(object sender, RoutedEventArgs e)
        {
            object redo = history.Redo();
            if (redo != null)
            {
                Products.GetInstance().SweetnessesList = ((Memento) redo).sweetnessState;
                Test.Update();
            }
        }
        #endregion
        //hack themes

        #region Themes
        private void MenuThemesDefault_OnClick(object sender, RoutedEventArgs e)
        {
            Resources.MergedDictionaries.Clear();
            Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri(Path.GetFullPath("../../ResourceDictionary/Themes/Default.xaml"))
            });
        }

        private void MenuThemesOptimistic_OnClick(object sender, RoutedEventArgs e)
        {
            Resources.MergedDictionaries.Clear();
            Resources.MergedDictionaries.Add(new ResourceDictionary()
            {
                Source = new Uri(Path.GetFullPath("../../ResourceDictionary/Themes/Optimistic.xaml"))
            });
        }
        #endregion

        private void CustomCandyButtom_OnClick(object sender, RoutedEventArgs e)
        {
            Events.EventsWindow eventswindow = new Events.EventsWindow();
            eventswindow.Show();
        }
    }
}
