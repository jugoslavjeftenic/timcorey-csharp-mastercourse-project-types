using System.Windows;

namespace T33_01_03_WPF_Homework
{
    // Build a WPF application that has a simple data entry screen
    // with First and Last name fields.
    // Have a button say "Hi {FN} {LN}" when pressed.

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            firstNameTextBox.Focus();
        }

        private void SayHiButton_Click(object sender, RoutedEventArgs e)
        {
            sayHiLabel.Text = $"Hi {firstNameTextBox.Text} {lastNameTextBox.Text}";
        }
    }
}
