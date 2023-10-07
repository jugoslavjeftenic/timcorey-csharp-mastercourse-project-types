using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using T32_02_01_HomeworkMiniProject_WinForm.Models;

namespace T32_02_01_HomeworkMiniProject_WinForm
{
    // Build a WinForms application with two forms.
    // Create a form that takes in a person's info and
    // another that takes in addres info (multiple per person).

    public partial class PersonForm : Form
    {
        public static PersonModel person = new PersonModel();
        public static BindingList<AddressModel> addresses = new BindingList<AddressModel>();

        public PersonForm()
        {
            InitializeComponent();

            addressesListBox.DataSource = addresses;
            addressesListBox.DisplayMember = "Street";

            person.Addresses = addresses.ToList();
        }

        private void SavePersonButton_Click(object sender, EventArgs e)
        {
            if (savePersonButton.Text == "Save person")
            {
                person.FirstName = firstNameTextBox.Text;
                person.LastName = lastNameTextBox.Text;
                firstNameTextBox.ReadOnly = true;
                lastNameTextBox.ReadOnly = true;

                savePersonButton.Text = "Edit person";
                savePersonButton.Focus();
            }
            else
            {
                firstNameTextBox.ReadOnly = false;
                lastNameTextBox.ReadOnly = false;
                firstNameTextBox.Focus();

                savePersonButton.Text = "Save person";
            }
        }

        private void AddAddressButton_Click(object sender, EventArgs e)
        {
            AddressForm addressForm = new AddressForm();
            addressForm.ShowDialog();
        }
    }
}
