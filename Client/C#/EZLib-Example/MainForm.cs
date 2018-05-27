using System;
using System.Windows.Forms;

namespace EZLib.Test
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UsernameLabel2.Text = Information.Username;
            EmailLabel2.Text = Information.EmailAddress;

            SerialLabel2.Text = Information.Serial;
            ExpirationDateLabel2.Text = Information.ExpirationDate;
        }

        private void FetchVariableButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Globals.Variable.FetchVariable("VARIABLE_NAME"));
        }

        private void FetchHWIDButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Information.HardwareId);
        }

        private void FetchNewsButton_Click(object sender, EventArgs e)
        {
            var newsForm = new NewsForm(Information.News);
            newsForm.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}