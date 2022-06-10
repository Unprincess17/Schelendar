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
        
        
        ///TODO: 如何进行窗体间的交互
        /// <summary>
        /// 下一步按钮，切换时间设置界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ensureBtn_Click(object sender, EventArgs e)
        {
            if (courseTableNameTB.Text.IsNullOrEmpty())
            {
                MessageBox.Show("");
            }
            else
            {
                Close();
                CourseTableAddTimeSettingForm courseTableAddTimeSettingForm =
                    new CourseTableAddTimeSettingForm(totalCourseNumIUD.Value);
                courseTableAddTimeSettingForm.Show();
            }
        }

        
        /// <summary>
        /// 取消时关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
