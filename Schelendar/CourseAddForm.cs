using System;
using System.Drawing;
using System.Windows.Forms;
using Schelendar.Models;
using Sunny.UI;

namespace Schelendar
{
    public partial class CourseAddForm : UIForm
    {
        /// <summary>
        /// 要修改的课程名
        /// </summary>
        private int courseId;

        /// <summary>
        /// 一天中的课程数量
        /// </summary>
        private int dayCourseNumber;

        /// <summary>
        /// 当前要添加的为星期几的课
        /// </summary>
        private int dayOfWeek;

        /// <summary>
        /// 课表最大周数
        /// </summary>
        private int weekLength;

        /// <summary>
        /// 课表界面用来刷新UI
        /// </summary>
        public SchCourse SchCourse;

        public CourseAddForm(int courseId, int dayCourseNumber, int dayOfWeek, int weekLength)
        {
            InitializeComponent();
            InitTextBox();
            this.courseId = courseId;
            this.dayCourseNumber = dayCourseNumber;
            this.dayOfWeek = dayOfWeek;
            this.weekLength = weekLength;
        }


        /// TODO: 根据传入课程ID来在查找课程信息
        /// <summary>
        /// 假如原位置已有课程，则需要先将原课程信息显示，然后修改
        /// </summary>
        private void InitCourseInfo()
        {
        }


        /// TODO: 使用SchCourseManage
        /// <summary>
        /// 判断课程事件设置是否合法
        /// </summary>
        private bool IsTimeRule()
        {
            return true;
        }


        /// TODO: 使用SchCourseManger
        /// <summary>
        /// 判断课程上课周数设置是否合法
        /// </summary>
        private bool IsWeekRule()
        {
            return true;
        }


        /// <summary>
        /// 因为SunnyUI原因只能在代码中动态改变颜色
        /// </summary>
        private void InitTextBox()
        {
            locationDistrictTB.ForeColor = Color.Gray;
            locationBuildingTB.ForeColor = Color.Gray;
            locationRoomTB.ForeColor = Color.Gray;
        }

        /// <summary>
        /// 实现输入框的提示功能
        /// </summary>
        private void locationTB_MouseClick(object sender, EventArgs e)
        {
            UITextBox uiTextBox = (UITextBox) sender;
            if (uiTextBox.Text.Equals("学区") || uiTextBox.Text.Equals("教学楼") || uiTextBox.Text.Equals("教室"))
            {
                uiTextBox.Text = String.Empty;
                uiTextBox.ForeColor = Color.Black;
            }
        }


        /// <summary>
        /// 学区输入框焦点离开后事件
        /// </summary>
        private void locationDistrictTB_Leave(object sender, EventArgs e)
        {
            UITextBox uiTextBox = (UITextBox) sender;
            if (uiTextBox.Text.Equals(String.Empty))
            {
                uiTextBox.Text = "学区";
                uiTextBox.ForeColor = Color.Gray;
            }
        }


        /// <summary>
        /// 教学楼输入框焦点离开后事件
        /// </summary>
        private void locationBuildingTB_Leave(object sender, EventArgs e)
        {
            UITextBox uiTextBox = (UITextBox) sender;
            if (uiTextBox.Text.Equals(String.Empty))
            {
                uiTextBox.Text = "教学楼";
                uiTextBox.ForeColor = Color.Gray;
            }
        }


        /// <summary>
        /// 教室输入框焦点离开后事件
        /// </summary>
        private void locationRoomTB_Leave(object sender, EventArgs e)
        {
            UITextBox uiTextBox = (UITextBox) sender;
            if (uiTextBox.Text.Equals(String.Empty))
            {
                uiTextBox.Text = "教室";
                uiTextBox.ForeColor = Color.Gray;
            }
        }


        /// TODO: 储存新创建或修改的课程信息，返回到成员变量SchCourse来使课表界面刷新
        /// <summary>
        /// 确认点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ensureBtn_Click(object sender, EventArgs e)
        {
            if (IsTimeRule() && IsWeekRule())
            {
            }
        }
    }
}