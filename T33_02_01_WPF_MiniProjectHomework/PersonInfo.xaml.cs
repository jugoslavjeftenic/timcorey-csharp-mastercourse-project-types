using System.ComponentModel;
using System.Windows;
using T33_02_01_WPF_MiniProjectHomework.Models;

namespace T33_02_01_WPF_MiniProjectHomework
{
    // Build a WPF application with two forms.
    // Create a form that takes in person's info and another that
    // takes in address info (multiple per person)

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class PersonInfo : Window
    {
        readonly PersonModel person = new();
        BindingList<AddressModel> addresses = new();

        public void MainWindow()
        {
            InitializeComponent();
            //person.Addresses = addresses.ToList<AddressModel>();
            //addressList.ItemsSource = person.Addresses;
            addressesList.ItemsSource = addresses;
            addresses.Add(new AddressModel()
            {
                StreetAddress = "Bombasticna bb.",
                City = "Bombardija",
                State = "Bombatna",
                ZipCode = "24000"
            });
        }

        private void SavePersonButton_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text))
            {
                MessageBox.Show("Please enter First name.", "First name missing",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            if (string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                MessageBox.Show("Please enter Last name.", "Last name missing",
                    MessageBoxButton.OK, MessageBoxImage.Information);
                return;
            }

            person.FirstName = firstNameTextBox.Text;
            person.LastName = lastNameTextBox.Text;

            if ((string)savePersonButton.Content == "Save Person")
            {
                firstNameTextBox.IsEnabled = false;
                lastNameTextBox.IsEnabled = false;
                savePersonButton.Content = "Edit Person";
                addAddressButton.Focus();
            }
            else
            {
                firstNameTextBox.IsEnabled = true;
                firstNameTextBox.Focus();
                lastNameTextBox.IsEnabled = true;
                savePersonButton.Content = "Save Person";
            }
        }

        public void SaveAddress(AddressModel address)
        {
            addresses.Add(address);
            //person.Addresses.Add(address);
        }

        private void AddAddressButton_Click(object sender, RoutedEventArgs e)
        {
            AddressInfo addressInfo = new(this);
            addressInfo.Show();
        }
    }
}
