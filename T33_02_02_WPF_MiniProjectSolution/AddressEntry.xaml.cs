using System.Windows;
using T33_02_02_WPF_MiniProjectSolution.Interfaces;
using T33_02_02_WPF_MiniProjectSolution.Models;

namespace T33_02_02_WPF_MiniProjectSolution
{
    /// <summary>
    /// Interaction logic for AddressEntry.xaml
    /// </summary>
    public partial class AddressEntry : Window
    {
        readonly ISaveAddress _parent;

        public AddressEntry(ISaveAddress parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            AddressModel address = new()
            {
                StreetAddress = streetAddressTextBox.Text,
                City = cityTextBox.Text,
                State = stateTextBox.Text,
                ZipCode = zipCodeTextBox.Text
            };

            _parent.SaveAddress(address);

            this.Close();
        }
    }
}
