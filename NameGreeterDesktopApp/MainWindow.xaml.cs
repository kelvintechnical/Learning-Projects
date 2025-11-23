using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NameGreeterDesktopApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GreetButton_Click(object sender, RoutedEventArgs e)
        {
            // Get the name from the TextBox
            string userName = NameTextBox.Text;

            // Use your existing method to generate the greeting
            string greeting = $"Hello, {userName}!";

            // Display it in the TextBlock
            GreetingLabel.Text = greeting;
        }
    }
}