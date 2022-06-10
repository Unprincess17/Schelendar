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
    public partial class CourseTableAddTimeSettingForm : UIForm
    {
        private int courseNumber = 11;
        public CourseTableAddTimeSettingForm(int courseNumber)
        {
            this.courseNumber = courseNumber;
            InitializeComponent();
            InitTableRows(courseNumber);
        }

        /// <summary>
        /// number为每天的课程节数
        /// </summary>
        /// <param name="number"></param>
        private void InitTableRows(int number)
        {
            uiTimeSettingTableLayoutPanel.RowCount = 1;
            for (int i = 1; uiTimeSettingTableLayoutPanel.RowCount < number + 1; i++)
            {
                uiTimeSettingTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
                uiTimeSettingTableLayoutPanel.RowCount++;
                UILabel uiLabel = new UILabel();
                uiLabel.Dock = DockStyle.Fill;
                uiLabel.TextAlign = ContentAlignment.MiddleRight;
                uiLabel.Text = "第" + i + "节";
                uiTimeSettingTableLayoutPanel.Controls.Add(uiLabel, 0, uiTimeSettingTableLayoutPanel.RowCount - 1);
                for (int j = 0; j < 2; j++)
                {
                    UITimePicker uITimePicker = new UITimePicker();
                    uITimePicker.Name = j == 0 ? "start" : "end" + " TP" + i;
                    uITimePicker.TimeFormat = "HH:mm";
                    uITimePicker.Dock = DockStyle.Fill;                   
                    uiTimeSettingTableLayoutPanel.Controls.Add(uITimePicker, j == 0 ? 1 : 3 , uiTimeSettingTableLayoutPanel.RowCount - 1);
                }
            }
        }

        
        ///TODO: 如何窗口之间交互切换
        /// <summary>
        /// 返回上一个设置界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        
        ///TODO: 调用逻辑部分来在数据库添加课表
        /// <summary>
        /// 确定添加课程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void ensureBtn_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
