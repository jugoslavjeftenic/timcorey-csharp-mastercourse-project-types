using System.ComponentModel;
using System.Windows.Forms;

namespace T32_01_01_WinForm_MessageWall
{
    public partial class Dashboard : Form
    {
        BindingList<string> messages = new BindingList<string>();

        public Dashboard()
        {
            InitializeComponent();
            WireUpLists();
        }

        private void WireUpLists()
        {
            messageListBox.DataSource = messages;
        }

        private void AddMessage_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(messageTextBox.Text))
            {
                MessageBox.Show(
                    "Please enter a message before trying to add it to the list.",
                    "Blank Message Field",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                messages.Add(messageTextBox.Text);
                messageTextBox.Text = string.Empty;
            }

            messageTextBox.Focus();
        }
    }
}
