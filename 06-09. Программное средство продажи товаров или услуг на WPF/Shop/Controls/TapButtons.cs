using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Shop.Controls
{
    public class TapButton : Button
    {
        public static readonly RoutedEvent TapEvent = EventManager.RegisterRoutedEvent(
            "Tap", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(TapButton));

        public event RoutedEventHandler Tap
        {
            add { AddHandler(TapEvent, value); }
            remove { RemoveHandler(TapEvent, value); }
        }
        void RaiseTapEvent()
        {
            RoutedEventArgs newEventArgs = new RoutedEventArgs(TapButton.TapEvent);
            RaiseEvent(newEventArgs);
        }
        protected override void OnClick()
        {
            RaiseTapEvent();
        }
    }

    public class PreviewTapButton : Button
    {
        private static readonly RoutedEvent PreviewTapEvent = EventManager.RegisterRoutedEvent(
            "PreviewTapEvent", RoutingStrategy.Tunnel, typeof(RoutedEventHandler), typeof(PreviewTapButton));
        
        public event RoutedEventHandler PreviewTap
        {
            add => AddHandler(PreviewTapEvent, value);
            remove => RemoveHandler(PreviewTapEvent, value);
        }
        protected override void OnClick()
        {
            RaiseEvent(new RoutedEventArgs(PreviewTapButton.PreviewTapEvent));
        }
    }
    public class DirectTapButton : Button
    {
        private static readonly RoutedEvent DirectTapEvent = EventManager.RegisterRoutedEvent(
            "DirectTapButton", RoutingStrategy.Direct, typeof(RoutedEventHandler), typeof(DirectTapButton));
        
        public event RoutedEventHandler DirectTap
        {
            add => AddHandler(DirectTapEvent, value);
            remove => RemoveHandler(DirectTapEvent, value);
        }

        protected override void OnClick()
        {
            RaiseEvent(new RoutedEventArgs(DirectTapButton.DirectTapEvent));
        }
    }
}