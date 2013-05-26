using System.Diagnostics;
using System.Windows.Forms;

namespace IntelligentFrameCorrection
{
    public partial class Project : UserControl
    {
        public Project()
        {
            InitializeComponent();
        }

        private void linkLabelHomepage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var sInfo = new ProcessStartInfo(linkLabelHomepage.Text);
            Process.Start(sInfo);
        }

        private void linkLabelOnlineDocumentation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var sInfo = new ProcessStartInfo(linkLabelOnlineDocumentation.Text);
            Process.Start(sInfo);
        }
    }
}
