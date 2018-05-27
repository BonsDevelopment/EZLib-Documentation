using System.Windows.Forms;

namespace EZLib.Test
{
    public partial class ViewNewsPost : Form
    {
        public ViewNewsPost(string title, string body)
        {
            InitializeComponent();

            TitleLabel.Text = $"You're reading {title}.";
            BodyTextbox.Text = body;
        }
    }
}