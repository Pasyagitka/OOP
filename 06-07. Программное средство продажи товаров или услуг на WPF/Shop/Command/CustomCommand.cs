using System.Windows.Input;

namespace Shop.Command
{
    public class CustomCommand
    {
        public static readonly RoutedUICommand Exit = new RoutedUICommand
        (
            //HACK CustomCommand RoutedUICommand
            "Exit",
            "Exit",
            typeof(CustomCommand),
            new InputGestureCollection()
            {
                new KeyGesture(Key.Escape, ModifierKeys.Alt)
            }
        );
    }
}