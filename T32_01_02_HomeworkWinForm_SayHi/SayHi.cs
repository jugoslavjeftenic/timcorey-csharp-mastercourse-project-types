using System;
using System.Windows.Forms;

namespace T32_01_02_HomeworkWinForm_SayHi
{
    // Build a WinForms application that has a simple data-entry screen
    // with First and Last name fields.
    // Have a button say "Hi {FN} {LN}" when pressed.

    public partial class SayHiApp : Form
    {
        public SayHiApp()
        {
            InitializeComponent();
        }

        private void SayHiButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text))
            {
                MessageBox.Show("Please enter first name", "First Name Empty",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                firstNameTextBox.Focus();
                return;
            }
            else if (string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                MessageBox.Show("Please enter last name", "Last Name Empty",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lastNameTextBox.Focus();
                return;
            }

            MessageBox.Show
                ($"Hi {firstNameTextBox.Text} {lastNameTextBox.Text}", "",
                 MessageBoxButtons.OK);
            firstNameTextBox.Text = string.Empty;
            lastNameTextBox.Text = string.Empty;
        }
    }
}
