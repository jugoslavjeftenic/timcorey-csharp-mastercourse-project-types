using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using T32_02_02_SolutionMiniProject_WinForm.Interfaces;
using T32_02_02_SolutionMiniProject_WinForm.Models;

namespace T32_02_02_SolutionMiniProject_WinForm
{
    public partial class PersonEntry : Form, ISaveAddress
    {
        BindingList<AddressModel> addresses = new BindingList<AddressModel>();

        public PersonEntry()
        {
            InitializeComponent();

            addressesListBox.DataSource = addresses;
            addressesListBox.DisplayMember = nameof(AddressModel.AddresDisplayValue);
        }

        private void AddAddressButton_Click(object sender, EventArgs e)
        {
            AddressEntry addressEntry = new AddressEntry(this);
            addressEntry.ShowDialog();
        }

        public void SaveAddress(AddressModel address)
        {
            addresses.Add(address);
        }

        private void SaveRecordButton_Click(object sender, EventArgs e)
        {
            PersonModel person = new PersonModel
            {
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                IsActive = isActiveCheckBox.Checked,
                Addresses = addresses.ToList()
            };
        }
    }
}
