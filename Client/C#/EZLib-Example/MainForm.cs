using System;
using System.Windows.Forms;
using EZLib;

namespace EZLib_Example
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowNewsButton_Click(object sender, EventArgs e)
        {
            new News().ShowNews();
        }

        private void GetVariableButton_Click(object sender, EventArgs e)
        {
            new Variable().FetchVariable("VARIABLE_NAME");
        }

        private void GetNameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(UserInformation.Name, "EZLib", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GetSerialButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SerialInformation.Serial, "EZLib", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SilverRequirementSerial_Click(object sender, EventArgs e)
        {
            if (SerialInformation.Type == "Silver")
            {
                MessageBox.Show("You have a silver type serial!", "EZLib", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("You do not have a silver type serial! Please buy a silver type serial.", "EZLib", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
