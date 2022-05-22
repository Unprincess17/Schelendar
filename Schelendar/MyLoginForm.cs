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
using Schelendar.Models;

namespace Schelendar
{
    public partial class MyLoginForm : UIForm
    {
        //用于登录验证、注册
        SchUserManager schUserManager;

        public MyLoginForm()
        {
            InitializeComponent();
            schUserManager = new SchUserManager();
            //schUserManager.ImportUsers
        }

        private void uiButton_Login_Click(object sender, EventArgs e)
        {
            Console.WriteLine("clicked");
            Task LoadingForm = Task.Run(() => { });
            Task CheckValidation = Task.Run(() => { });
        }

        
        public bool LoginCheck(string account, string passwd, int isRmbMe, int isRmbPasswd, int isAutoLogin) 
        {
            return false;
        }
    }

}
