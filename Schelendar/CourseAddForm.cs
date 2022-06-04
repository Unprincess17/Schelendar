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
        private readonly int _courseId;

        /// <summary>
        /// 当前课表的学期
        /// </summary>
        private readonly int _semester;

        /// <summary>
        /// 当前要添加的为星期几的课
        /// </summary>
        private readonly int _dayOfWeek;

        /// <summary>
        /// 课表界面用来刷新UI
        /// </summary>
        public SchCourse SchCourse;


        /// <summary>
        /// 原位置有课程基础
        /// </summary>
        /// <param name="course"></param>
        /// <param name="dayCourseNumber"></param>
        /// <param name="dayOfWeek"></param>
        /// <param name="weekLength"></param>
        /// <param name="semester"></param>
        public CourseAddForm(SchCourse course, int dayCourseNumber, int dayOfWeek, int weekLength, int semester)
        {
            InitializeComponent();
            // deleteBtn.Style = UIStyle.Red;
            InitCourseInfo(course);
            InitIudMaxAndMin(weekLength, dayCourseNumber);
            this._dayOfWeek = dayOfWeek;
            this._semester = semester;
            this._courseId = course.SchCourseID;
        }


        /// <summary>
        /// 原位置无课程基础
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="dayCourseNumber"></param>
        /// <param name="dayOfWeek"></param>
        /// <param name="weekLength"></param>
        /// <param name="semester"></param>
        public CourseAddForm(int startTime, int dayCourseNumber, int dayOfWeek, int weekLength, int semester)
        {
            InitializeComponent();
            InitTextBox();
            startTimeIUD.Value = startTime;
            endTimeIUD.Value = startTime;
            InitIudMaxAndMin(weekLength, dayCourseNumber);
            this._dayOfWeek = dayOfWeek;
            this._semester = semester;
            this._courseId = -1;
        }


        /// <summary>
        /// 初始化IntegerUpDown的最大值和最小值
        /// </summary>
        private void InitIudMaxAndMin(int weekLength, int dayCourseNumber)
        {
            startTimeIUD.Minimum = 1;
            endTimeIUD.Minimum = startTimeIUD.Value;
            startTimeIUD.Maximum = endTimeIUD.Value;
            endTimeIUD.Maximum = dayCourseNumber;
            startWeekIUD.Minimum = 1;
            endWeekIUD.Minimum = 1;
            startWeekIUD.Maximum = endTimeIUD.Value;
            endWeekIUD.Maximum = weekLength;
        }


        /// TODO: 根据传入课程ID来在查找课程信息以及显示到界面
        /// <summary>
        /// 假如原位置已有课程，则需要先将原课程信息显示，然后修改
        /// </summary>
        private void InitCourseInfo(SchCourse schCourse)
        {
            courseNameTB.Text = schCourse.SchCourseName;
            locationDistrictTB.Text = schCourse.ClassLocation.District;
            locationBuildingTB.Text = schCourse.ClassLocation.Building;
            locationRoomTB.Text = schCourse.ClassLocation.Classroom;
            teacherNameTB.Text = schCourse.TeacherName;
            startTimeIUD.Value = schCourse.StartTime;
            endTimeIUD.Value = schCourse.EndTime;
            startWeekIUD.Value = schCourse.StartWeek;
            endWeekIUD.Value = schCourse.EndWeek;
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


        /// TODO: Manager添加或修改课程，返回是否成功来判断如何交互
        /// <summary>
        /// 确认点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ensureBtn_Click(object sender, EventArgs e)
        {
            SchCourse = new SchCourse(0, courseNameTB.Text, locationDistrictTB.Text, locationBuildingTB.Text,
                locationRoomTB.Text, teacherNameTB.Text, startWeekIUD.Value, endWeekIUD.Value, _dayOfWeek, _semester,
                startTimeIUD.Value, endTimeIUD.Value);
            DialogResult = DialogResult.OK;
            Close();
        }


        /// TODO: Manager删除对应课程
        /// <summary>
        /// 删除确认
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (_courseId != -1)
            {
                DialogResult = DialogResult.Abort;
                Close();
            }
            else
            {
                UIMessageTip.ShowError(text: "课程不存在");
            }
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