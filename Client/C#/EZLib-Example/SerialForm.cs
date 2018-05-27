using System;
using System.Windows.Forms;

namespace EZLib.Test
{
    public partial class SerialForm : Form
    {
        public SerialForm()
        {
            InitializeComponent();
        }

        private void SuffixCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (SuffixCheckbox.Checked)
                CustomTextbox.Enabled = true;
            else
                CustomTextbox.Enabled = false;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            string serial;

            if (!SuffixCheckbox.Checked)
                serial = $"{Slot1Textbox.Text}-{Slot2Textbox.Text}-{Slot3Textbox.Text}-{Slot4Textbox.Text}";
            else
                serial =
                    $"{Slot1Textbox.Text}-{Slot2Textbox.Text}-{Slot3Textbox.Text}-{Slot4Textbox.Text}-{CustomTextbox.Text}";

            Globals.Authentication.SerialRegistration(serial);

            if (Globals.Authentication.HasSerial())
                MessageBox.Show("You have successfully registered your serial!", "EZLib", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }
    }
}