using System.Windows;
using System.Windows.Input;

namespace Data_Sanitization
{
    public partial class HomeLayout : Window
    {
        public HomeLayout()
        {
            InitializeComponent();
        }

        // Button Click → Sanitize Drive
        private void NavSanitize_Click(object sender, RoutedEventArgs e)
        {
            var sanitize = new SanitizeDrive();
            sanitize.Show();
            this.Close();
        }

        // TextBlock MouseLeftButtonDown → Sanitize Drive
        private void NavSanitizeText_Click(object sender, MouseButtonEventArgs e)
        {
            var sanitize = new SanitizeDrive();
            sanitize.Show();
            this.Close();
        }

        // Button Click → Reports
        private void NavReports_Click(object sender, RoutedEventArgs e)
        {
            var reports = new Reports();
            reports.Show();
            this.Close();
        }

        // TextBlock MouseLeftButtonDown → Reports
        private void NavReportsText_Click(object sender, MouseButtonEventArgs e)
        {
            var reports = new Reports();
            reports.Show();
            this.Close();
        }
    }
}
