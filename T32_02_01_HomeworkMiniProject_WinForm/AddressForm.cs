using System;
using System.Windows.Forms;
using T32_02_01_HomeworkMiniProject_WinForm.Models;

namespace T32_02_01_HomeworkMiniProject_WinForm
{
    public partial class AddressForm : Form
    {
        public AddressForm()
        {
            InitializeComponent();
        }

        private void AddAddressButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(streetTextBox.Text))
            {
                MessageBox.Show("Please enter street name", "Street Name Empty",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (string.IsNullOrWhiteSpace(streetNumberTextBox.Text))
            {
                MessageBox.Show("Please enter street number", "Street Number Empty",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (string.IsNullOrWhiteSpace(cityTextBox.Text))
            {
                MessageBox.Show("Please enter City", "City Empty",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (string.IsNullOrWhiteSpace(countryTextBox.Text))
            {
                MessageBox.Show("Please enter Country", "Country Empty",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            AddressModel address = new AddressModel()
            {
                Street = streetTextBox.Text,
                StreetNumber = streetNumberTextBox.Text,
                City = cityTextBox.Text,
                Country = countryTextBox.Text
            };

            PersonForm.addresses.Add(address);
            this.Close();
        }
    }
}
