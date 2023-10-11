using System.ComponentModel;
using System.Windows;

namespace T33_01_01_WPF_MessageWall
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly BindingList<string> messages = new();

        public MainWindow()
        {
            InitializeComponent();
            messageList.ItemsSource = messages;
        }

        private void AddMessage_Click(object sender, RoutedEventArgs e)
        {
            messages.Add(messageText.Text);
            messageText.Text = string.Empty;
        }
    }
}
