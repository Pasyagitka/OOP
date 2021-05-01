using System.Windows;
using System.Windows.Controls;

namespace Shop.Controls
{
    public partial class AddProduct : UserControl
    {  
        private static readonly ValidateValueCallback validateValueCallback = new ValidateValueCallback(ValidateIntValue);
        public static readonly DependencyProperty NameTextBlockTextProperty =  DependencyProperty.Register("NameTextBlockText", typeof(string), typeof(AddProduct), new UIPropertyMetadata(""));
        public static readonly DependencyProperty ImageTextBlockTextProperty = DependencyProperty.Register("ImageTextBlockText", typeof(string), typeof(AddProduct), new UIPropertyMetadata("..\\..\\ProductImages\\nophoto.png"));
        public static readonly DependencyProperty WeightTextBlockTextProperty = DependencyProperty.Register("WeightTextBlockText", typeof(int), typeof(AddProduct), new UIPropertyMetadata(0),  validateValueCallback);
        public static readonly DependencyProperty CaloriesTextBlockTextProperty = DependencyProperty.Register("CaloriesTextBlockText", typeof(int), typeof(AddProduct), new UIPropertyMetadata(0), validateValueCallback);
        public static readonly DependencyProperty DescriptionTextBlockTextProperty = DependencyProperty.Register("DescriptionTextBlockText", typeof(string), typeof(AddProduct), new UIPropertyMetadata(""));
        public static readonly DependencyProperty TrademarkTextBlockTextProperty = DependencyProperty.Register("TrademarkTextBlockText", typeof(string), typeof(AddProduct), new UIPropertyMetadata(""));
        public static readonly DependencyProperty PriceTextBlockTextProperty;
        
        public string NameTextBlockText
        {
            get { return (string)GetValue(NameTextBlockTextProperty); }
            set { SetValue(NameTextBlockTextProperty, value); }
        }
        public string ImageTextBlockText
        {
            get { return (string)GetValue(ImageTextBlockTextProperty); }
            set { SetValue(ImageTextBlockTextProperty, value); }
        }
        public int WeightTextBlockText
        {
            get { return (int)GetValue(WeightTextBlockTextProperty); }
            set { SetValue(WeightTextBlockTextProperty, value); }
        }
        public int CaloriesTextBlockText
        {
            get { return (int)GetValue(CaloriesTextBlockTextProperty); }
            set { SetValue(CaloriesTextBlockTextProperty, value); }
        }
        public string DescriptionTextBlockText
        {
            get { return (string)GetValue(DescriptionTextBlockTextProperty); }
            set { SetValue(DescriptionTextBlockTextProperty, value); }
        }
        public string TrademarkTextBlockText
        {
            get { return (string)GetValue(TrademarkTextBlockTextProperty); }
            set { SetValue(TrademarkTextBlockTextProperty, value); }
        }
        public int PriceTextBlockText
        {
            get { return (int)GetValue(PriceTextBlockTextProperty); }
            set { SetValue(PriceTextBlockTextProperty, value); }
        }
        
       
        public AddProduct()
        {
            InitializeComponent();
            DataContext = this;
        }

        static AddProduct()
        {
            FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata();
            metadata.CoerceValueCallback = new CoerceValueCallback(CorrectIntValue);
            PriceTextBlockTextProperty = DependencyProperty.Register("PriceTextBlockText", typeof(int), typeof(AddProduct), metadata, new ValidateValueCallback(ValidateIntValue));
        }
        
        private static bool ValidateIntValue(object value)
        {
            int currentValue = (int)value;
            if (currentValue >= 0) 
                return true;
            return false;
        }
        
        private static object CorrectIntValue(DependencyObject d, object baseValue)
        {
            int currentValue = (int)baseValue;
            if (currentValue > 10) 
                return 10;
            return currentValue;
        }
 
        
    }
}