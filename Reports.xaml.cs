using System.Windows;

namespace Data_Sanitization
{
    public partial class Reports : Window
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void NavHome_Click(object sender, RoutedEventArgs e)
        {
            var home = new HomeLayout();
            home.Show();
            this.Close();
        }

        private void NavSanitize_Click(object sender, RoutedEventArgs e)
        {
            var sanitize = new SanitizeDrive();
            sanitize.Show();
            this.Close();
        }
    }
}
