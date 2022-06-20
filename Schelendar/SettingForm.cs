using System;
using System.Windows.Forms;
using Sunny.UI;

namespace Schelendar
{
    public partial class SettingForm : UIForm
    {
        public static string path = @"C:\TomatoDate";
        public SettingForm()
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToShortDateString().ToString();
        }

        private void btnChangePath_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog folder = new System.Windows.Forms.FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                this.lblPath.Text = folder.SelectedPath;
                path = this.lblPath.Text;
                TomatoClockForm.directoryPath = this.lblPath.Text;
            }
        }

        private void btnSignOut_Click(object sender, System.EventArgs e)
        {

        }
    }
}