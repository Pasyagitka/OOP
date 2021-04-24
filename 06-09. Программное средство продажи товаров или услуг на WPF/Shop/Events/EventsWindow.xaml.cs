using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;

namespace Shop.Events
{
    public partial class EventsWindow : Window
    {
        public EventsWindow()
        {
            InitializeComponent();
        }
        private void InnerBubble_Click(object sender, RoutedEventArgs e) { 
            txt1.Background = new SolidColorBrush(Colors.Beige);
            txt1.Text += "Inner Bubble\n";
        } 
        private void OuterBubble_Click(object sender, RoutedEventArgs e) { 
            txt1.Background = new SolidColorBrush(Colors.Bisque);
            txt1.Text += "Outer Bubble\n";
        } 
        private void InnerTunnel_Click(object sender, RoutedEventArgs e)
        {
            txt21.Background = new SolidColorBrush(Colors.Beige);
            txt21.Text += "Inner Tunnel\n";
        }
        private void OuterTunnel_Click(object sender, RoutedEventArgs e)
        {
            txt21.Background = new SolidColorBrush(Colors.Bisque);
            txt21.Text += "Outer Tunnel\n";
        }

        private void InnerDirect_Click(object sender, RoutedEventArgs e)
        {
            txt31.Background = new SolidColorBrush(Colors.Beige);
            txt31.Text += "Inner Direct\n";
        }
        private void OuterDirect_Click(object sender, RoutedEventArgs e)
        {
            txt31.Background = new SolidColorBrush(Colors.Bisque);
            txt31.Text += "Outer Direct\n";
        }
    }
}