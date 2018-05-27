using System;
using System.Windows.Forms;

namespace EZLib.Test
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Globals.Authentication.Register(NameTextbox.Text, EmailAddressTextbox.Text, UsernameTextbox.Text, PasswordTextbox.Text);
        }
    }
}
