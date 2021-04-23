using System.Windows;
using System.Windows.Input;
using Shop.Roles;

namespace Shop
{
    public partial class Authorization : Window
    {
        public Authorization()
        {
            InitializeComponent();
        }
        
        private void LoginButton_OnClick(object sender, RoutedEventArgs e)
        {
            var roleList = RoleList.GetInstance();
            if (roleList.VerifyUsers(LoginTextBox.Text, PasswordBox.Password))
            {
                var mainWindow = new MainWindow();
                this.Close();
                mainWindow.Show();
            }
            else
            {
                MessageBox.Show("Проверьте правильность введенных данных");
            }
        }

        private void RegisterButton_OnClick(object sender, RoutedEventArgs e)
        {
            var roleList = RoleList.GetInstance();
            roleList.Add(new Client(LoginTextBox.Text, PasswordBox.Password));
            roleList.Serialize();
        }
        
        
        private void ExitCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
        	e.CanExecute = true;
        }
        private void ExitCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}