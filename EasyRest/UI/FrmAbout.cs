using System.Windows.Forms;

namespace EasyRest
{
    public partial class FrmAbout : Form
    {
        public FrmAbout()
        {
            InitializeComponent();
        }

        private void LLbGithubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LLbGithubLink.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/maketmimi");
        }

        private void PbAppLogo_Click(object sender, System.EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/maketmimi/EasyRest");
        }
    }
}
