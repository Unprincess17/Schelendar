using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace Schelendar
{
    public partial class LoginForm : UILoginForm
    {
        public LoginForm()
        {
            this.AutoScaleMode = AutoScaleMode.None; //防止因为屏幕分辨率而导致的窗体变形
            InitializeComponent();
        }

        private void LoginForm_ButtonLoginClick(object sender, EventArgs e)
        {
            UIMessageTip.ShowOk("Link Start");
            this.Dispose();
        }
    }
}