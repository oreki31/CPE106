using System.Windows;

namespace LoginRegistrationApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsernameLogin.Text;
            string password = txtPasswordLogin.Password;

            // Perform login authentication logic here
            if (IsAuthenticated(username, password))
            {
                // Successful login, navigate to homepage
                HomePage homePage = new HomePage();
                this.Content = homePage;
            }
            else
            {
                // Failed login
                lblLoginMessage.Text = "Invalid username or password.";
            }
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUsernameRegister.Text;
            string password = txtPasswordRegister.Password;

            // Perform registration logic here
            if (IsValidRegistration(username, password))
            {
                // Successful registration, navigate to homepage
                HomePage homePage = new HomePage();
                this.Content = homePage;
            }
            else
            {
                // Failed registration
                lblRegisterMessage.Text = "Invalid username or password.";
            }
        }

        private bool IsAuthenticated(string username, string password)
        {
            // Dummy authentication logic, replace with actual authentication mechanism
            return username == "admin" && password == "admin";
        }

        private bool IsValidRegistration(string username, string password)
        {
            // Dummy registration logic, replace with actual registration mechanism
            // For simplicity, we'll just check if both fields are non-empty
            return !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password);
        }
    }
}
