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

namespace Schelendar.CourseForms
{
    public partial class CourseTemplateForm : UIForm
    {
        /// <summary>
        /// 保存事件的列表
        /// </summary>
        public List<TemplateAdd> TemplateAdds = new List<TemplateAdd>();
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="courseId">如果是修改原有，则courseId应该可以查到，否则为-1</param>
        public CourseTemplateForm(int courseId)
        {
            
            InitializeComponent();
        }
        
        public class TemplateAdd
        {
            /// <summary>
            /// 事件名
            /// </summary>
            public String Name;

            /// <summary>
            /// 事件时间
            /// </summary>
            public DateTime Time;

            public TemplateAdd(String name, DateTime time)
            {
                Name = name;
                Time = time;
            }
        }


        /// TODO：查询返回课程的事件列表并初始化（先不考虑修改）
        /// <summary>
        /// 如果是已存在的课程
        /// </summary>
        /// <param name="courseId"></param>
        private void InitTemplate(int courseId)
        {
            
        }
        
        
        /// <summary>
        /// 添加事件项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addBtn_Click(object sender, EventArgs e)
        {
            UITextBox uiTextBox = new UITextBox();
            uiTextBox.Dock = DockStyle.Fill;
            uiTextBox.Text = String.Empty;
            uiTextBox.TextAlignment = ContentAlignment.MiddleRight;
            UIDatetimePicker uiDatetimePicker = new UIDatetimePicker();
            uiDatetimePicker.Dock = DockStyle.Fill;
            UICheckBox uiCheckBox = new UICheckBox();
            uiCheckBox.Text = "添加";
            uiCheckBox.Dock = DockStyle.Fill;
            uiCheckBox.Checked = true;
            templateTablePanel.Controls.Add(uiTextBox, 0, templateTablePanel.RowCount-1);
            templateTablePanel.Controls.Add(uiDatetimePicker, 1, templateTablePanel.RowCount-1);
            templateTablePanel.Controls.Add(uiCheckBox, 2, templateTablePanel.RowCount-1);
            templateTablePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
            templateTablePanel.RowCount++;
        }

        
        /// <summary>
        /// 返回上一个课程设置窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void preBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;
            Close();
        }


        ///TODO: 1.
        /// <summary>
        /// 完成按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ensureBtn_Click(object sender, EventArgs e)
        {
            for (int i = 2; i < templateTablePanel.RowCount-1; i++)
            {
                Control control = templateTablePanel.GetControlFromPosition(0, i);
                UIDatetimePicker datetimePicker = (UIDatetimePicker) templateTablePanel.GetControlFromPosition(1, i);
                UICheckBox uiCheckBox = (UICheckBox) templateTablePanel.GetControlFromPosition(2, i);
                if (uiCheckBox.Checked)
                {
                    TemplateAdds.Add(new TemplateAdd(control.Text, datetimePicker.Value));
                }
            }

            DialogResult = DialogResult.Yes;
            Close();
        }
    }
}
