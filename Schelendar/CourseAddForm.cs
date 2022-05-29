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
        /// 要修改的课程
        /// </summary>
        private int courseId;

        /// <summary>
        /// 当前课表的学期
        /// </summary>
        private int semaster;

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

        public CourseAddForm(int courseId, int dayCourseNumber, int dayOfWeek, int weekLength, int semaster)
        {
            InitializeComponent();
            InitTextBox();
            this.courseId = courseId;
            this.dayCourseNumber = dayCourseNumber;
            this.dayOfWeek = dayOfWeek;
            this.weekLength = weekLength;
            this.semaster = semaster;
            startTimeIUD.Minimum = 1;
            endTimeIUD.Minimum = 1;
            startTimeIUD.Maximum = endTimeIUD.Minimum;
            endTimeIUD.Maximum = dayCourseNumber;
            startWeekIUD.Minimum = 1;
            endWeekIUD.Minimum = 1;
            startWeekIUD.Maximum = endTimeIUD.Minimum;
            endWeekIUD.Maximum = weekLength;
        }


        /// TODO: 根据传入课程ID来在查找课程信息以及显示到界面
        /// <summary>
        /// 假如原位置已有课程，则需要先将原课程信息显示，然后修改
        /// </summary>
        private void InitCourseInfo()
        {
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


        /// TODO: Manager中调用数据库添加函数，返回为true时新建课程对象来传递，储存新创建或修改的课程信息，返回到成员变量SchCourse来使课表界面刷新
        /// <summary>
        /// 确认点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ensureBtn_Click(object sender, EventArgs e)
        {
            SchCourse = new SchCourse(courseNameTB.Text, locationDistrictTB.Text, locationBuildingTB.Text,
                locationRoomTB.Text, teacherNameTB.Text, startWeekIUD.Value, endWeekIUD.Value, dayOfWeek, semaster,
                startTimeIUD.Value, endTimeIUD.Value);
        }

        /// <summary>
        /// 动态改变结束时间最小值为开始时间的值，保证逻辑正确
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="value"></param>
        private void startTimeIUD_ValueChanged(object sender, int value)
        {
            endTimeIUD.Minimum = ((UIIntegerUpDown) sender).Value;
        }

        /// <summary>
        /// 动态改变开始时间最大值为结束时间的值，保证逻辑正确
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="value"></param>
        private void endTimeIUD_ValueChanged(object sender, int value)
        {
            startTimeIUD.Maximum = ((UIIntegerUpDown) sender).Value;
        }

        /// <summary>
        /// 动态改变结束周数最小值为开始周数的值，保证逻辑正确
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="value"></param>
        private void startWeekIUD_ValueChanged(object sender, int value)
        {
            endWeekIUD.Minimum = ((UIIntegerUpDown) sender).Value;
        }

        /// <summary>
        /// 动态改变开始周数最大值为结束周数的值，保证逻辑正确
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="value"></param>
        private void endWeekIUD_ValueChanged(object sender, int value)
        {
            startWeekIUD.Maximum = ((UIIntegerUpDown) sender).Value;
        }
    }
}