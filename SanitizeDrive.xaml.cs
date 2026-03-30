using System.Windows;

namespace Data_Sanitization
{
    public partial class SanitizeDrive : Window
    {
        public SanitizeDrive()
        {
            InitializeComponent();
        }

        private void NavHome_Click(object sender, RoutedEventArgs e)
        {
            var home = new HomeLayout();
            home.Show();
            this.Close();
        }

        private void NavReports_Click(object sender, RoutedEventArgs e)
        {
            var reports = new Reports();
            reports.Show();
            this.Close();
        }
    }
}
