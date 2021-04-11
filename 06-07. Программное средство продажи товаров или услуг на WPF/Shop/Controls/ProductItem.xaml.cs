using System.Windows.Controls;
using System.Windows.Media;

namespace Shop.Controls
{
    public partial class ProductItem : UserControl
    {
        public ProductItem()
        {
            InitializeComponent();
        }

        private void Item_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            MainGrid.Background = new SolidColorBrush(Colors.SeaShell);
        }

        private void Item_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            MainGrid.Background = new SolidColorBrush(Colors.White);
        }
    }
}