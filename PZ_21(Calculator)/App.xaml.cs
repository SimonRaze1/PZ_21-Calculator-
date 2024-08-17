using System.Configuration;
using System.Data;
using System.Windows;

namespace PZ_21_Calculator_
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void press7Button_Click(object sender, RoutedEventArgs e)
        {
            press7Button.Text += "7";
        }
        private void resultButton_Click(object sender, RoutedEventArgs e)
        {
            string expression = infoBlockText.Text;
            infoBlockText.Text = Calculation(expression). ToString();
        }
        private double Calculation(string expression)
        {
            return 0;
        }
    }

}
