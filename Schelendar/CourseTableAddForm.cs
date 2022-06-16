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
    public partial class CourseTableAddForm : UIForm
    {
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
                if (!courseTableAddTimeSettingForm.Visible)
                {
                    Show();
                }
                if (courseTableAddTimeSettingForm.DialogResult == DialogResult.Yes)
                {
                    //TODO: 数据库添加课表，利用CourseTableAddTimeSettingForm的EveryCourseTime
                    DialogResult = DialogResult.Yes;
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