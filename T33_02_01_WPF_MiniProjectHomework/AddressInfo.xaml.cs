using System.Windows;
using T33_02_01_WPF_MiniProjectHomework.Models;

namespace T33_02_01_WPF_MiniProjectHomework
{
    /// <summary>
    /// Interaction logic for AddressInfo.xaml
    /// </summary>
    public partial class AddressInfo : Window
    {
        PersonInfo _parent;

        public AddressInfo(PersonInfo personInfo)
        {
            InitializeComponent();
            _parent = personInfo;
        }

        private void SaveAddressButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(streetAddressTextBox.Text))
            {
                MessageBox.Show("Please enter Street address.", "Street Address missing",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            if (string.IsNullOrEmpty(cityTextBox.Text))
            {
                MessageBox.Show("Please enter City.", "City missing",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            if (string.IsNullOrEmpty(stateTextBox.Text))
            {
                MessageBox.Show("Please enter State.", "State missing",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            if (string.IsNullOrEmpty(zipCodeTextBox.Text))
            {
                MessageBox.Show("Please enter Zip Code.", "Zip Code missing",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

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
