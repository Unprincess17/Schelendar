using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Schelendar.Models;
using Sunny.UI;

namespace Schelendar
{
    public partial class CourseTableAddForm : UIForm
    {
        public int CourseTableAddId;
        
        public CourseTableAddForm()
        {
            InitializeComponent();
        }

        
        /// <summary>
        /// 下一步按钮，切换时间设置界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ensureBtn_Click(object sender, EventArgs e)
        {
            if (courseTableNameTB.Text.IsNullOrEmpty())
            {
                UIMessageDialog.ShowErrorDialog(this, "课表名称不能为空");
            }
            else
            {
                Visible = false;
                CourseTableAddTimeSettingForm courseTableAddTimeSettingForm =
                    new CourseTableAddTimeSettingForm(totalCourseNumIUD.Value);
                courseTableAddTimeSettingForm.ShowDialog();
                if (courseTableAddTimeSettingForm.DialogResult == DialogResult.Retry)
                {
                    Show();
                }
                if (courseTableAddTimeSettingForm.DialogResult == DialogResult.Yes)
                {
                    CourseTableAddId = CourseTableManager.AddCourseTable(new SchCourseTable(0, courseTableNameTB.Text,  totalCourseNumIUD.Value, totalWeekIUD.Value, courseTableAddTimeSettingForm.EveryCourseTime, this.startTimeDP.Value));
                    if(SchUserManager.CurrentUser.DefaultSemester == -1)
                    {
                        SchUserManager.CurrentUser.DefaultSemester = CourseTableAddId;
                        SchUserManager.UpdateUser(SchUserManager.CurrentUser);
                    }
                    DialogResult = DialogResult.Yes;
                    Close();
                }
            }
        }


        /// <summary>
        /// 取消时关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}