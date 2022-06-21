using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Sunny.UI;

namespace Schelendar
{
    public partial class SettingForm : UIForm
    {
        private static string path = null;
        public SettingForm()
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToShortDateString().ToString();
            using (StreamReader sr = new StreamReader("TomatoPath.txt"))
            {
                path = sr.ReadLine();
                lblPath.Text = path;
            }
        }

        private void btnChangePath_Click(object sender, System.EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog folder = new System.Windows.Forms.FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                this.lblPath.Text = folder.SelectedPath;
                path = this.lblPath.Text;
                File.WriteAllText("TomatoPath.txt", path);
            }
        }

        private void btnSignOut_Click(object sender, System.EventArgs e)
        {

        }

    }
}