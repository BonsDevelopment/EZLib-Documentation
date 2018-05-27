using System;
using System.Windows.Forms;

namespace EZLib.Test
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextbox.Text.Length < 4 || PasswordTextbox.Text.Length < 6)
            {
                MessageBox.Show("Please fill in all fields.", "EZLib", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Globals.Authentication.Login(UsernameTextbox.Text, PasswordTextbox.Text);

                if (Globals.Authentication.IsLoggedIn())
                {
                    MessageBox.Show("You have succesfully logged in! Check user data on server.", "EZLib",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (Globals.Authentication.HasSerial())
                    {
                        var mainForm = new MainForm();
                        mainForm.Show();
                        Hide();
                    }
                    else
                    {
                        var serialForm = new SerialForm();
                        serialForm.Show();
                        Hide();
                    }
                }
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm();
            registerForm.Show();
        }
    }
}