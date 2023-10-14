using System.ComponentModel;
using System.Linq;
using System.Windows;
using T33_02_02_WPF_MiniProjectSolution.Interfaces;
using T33_02_02_WPF_MiniProjectSolution.Models;

namespace T33_02_02_WPF_MiniProjectSolution
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ISaveAddress
    {
        readonly BindingList<AddressModel> addresses = new();

        public MainWindow()
        {
            InitializeComponent();

            addressesList.ItemsSource = addresses;
        }

        public void SaveAddress(AddressModel address)
        {
            addresses.Add(address);
        }

        private void AddAddresButton_Click(object sender, RoutedEventArgs e)
        {
            AddressEntry entry = new(this);
            entry.Show();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            PersonModel person = new()
            {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                IsActive = activeCheckBox.IsChecked ?? false,
                Addresses = addresses.ToList()
            };
        }
    }
}
