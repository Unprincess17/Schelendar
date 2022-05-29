using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Sunny.UI;
using Schelendar.Models;


namespace Schelendar
{
    public partial class ClassTableForm : UIForm
    {
        /// <summary>
        /// 当前实际的周数
        /// </summary>
        private int curWeekNumber = 1;

        /// <summary>
        /// 当前页面所展示的课表的周数
        /// </summary>
        private int displayedWeekNumber = 1;

        /// <summary>
        /// 当前课表的Id
        /// </summary>
        private int classTableId;

        /// <summary>
        /// 课表对象
        /// </summary>
        private SchCourseTable _schCourseTable = new SchCourseTable(12, "KK");

        /// <summary>
        /// 课表中提取的课程列表
        /// </summary>
        private List<SchCourse> _schCourses;


        /// TODO: 构造函数需要传入课表ID
        /// <summary>
        /// 
        /// </summary>
        public ClassTableForm()
        {
            InitializeComponent();
            InitTableRows(_schCourseTable.DayCourseNumber);
            // 初始化时间
            for (int i = 0; i < _schCourseTable.DayCourseNumber; i++)
            {
                UILabel uiTimeLable = new UILabel();
                uiTimeLable.Dock = DockStyle.Fill;
                uiTimeLable.TextAlign = ContentAlignment.MiddleCenter;
                uiTimeLable.Text = _schCourseTable.EveryCourseTime[i].GetValue("StartTime") + Environment.NewLine +
                                   _schCourseTable.EveryCourseTime[i].GetValue("EndTime");
                uiClassTableLayoutPanel.Controls.Add(uiTimeLable, 0, i);
            }
        }


        /// <summary>
        /// 初始化当前第几周
        /// </summary>
        /// <param name="number">当前为第几周</param>
        private void UpdateWeekNumber(int number)
        {
            weekLable.Text = "WEEK " + number;
        }


        /// <summary>
        /// 单元格初始化
        /// </summary>
        private void InitTableRows(int number)
        {
            uiClassTableLayoutPanel.RowCount = 0;
            while (uiClassTableLayoutPanel.RowCount < number)
            {
                uiClassTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 80));
                uiClassTableLayoutPanel.RowCount++;
                for (int i = 0; i < 7; i++)
                {
                    UILabel uiClassLabel = new UILabel();
                    uiClassLabel.Dock = DockStyle.Fill;
                    uiClassLabel.DoubleClick += uiClassLabel_DoubleClick;
                    uiClassLabel.MouseHover += uiClassLabel_MouseHover;
                    uiClassLabel.MouseLeave += uiClassLabel_MouseLeave;
                    uiClassTableLayoutPanel.Controls.Add(uiClassLabel, i + 1, uiClassTableLayoutPanel.RowCount - 1);
                }
            }
        }


        /// <summary>
        /// 鼠标停留在课程单元格时的提示信息
        /// </summary>
        private void uiClassLabel_MouseHover(object sender, EventArgs e)
        {
            UILabel uiLabel = (UILabel) sender;
            if (uiLabel.Text.Equals(String.Empty))
            {
                uiLabel.Text = "双击添加课程";
                uiLabel.TextAlign = ContentAlignment.MiddleCenter;
            }
        }


        /// <summary>
        /// 鼠标离开课程单元格后的提示信息
        /// </summary>
        private void uiClassLabel_MouseLeave(object sender, EventArgs e)
        {
            UILabel uiLabel = (UILabel) sender;
            if (uiLabel.Text.Equals("双击添加课程"))
            {
                uiLabel.Text = String.Empty;
            }
        }


        /// TODO: 如何根据点击的Label来获取课程的Id来创建add页面
        /// <summary>
        /// 双击添加课程
        /// </summary>
        private void uiClassLabel_DoubleClick(object sender, EventArgs e)
        {
            UILabel uiLabel = (UILabel) sender;

            CourseAddForm courseAddForm = new CourseAddForm(0, _schCourseTable.DayCourseNumber,
                uiClassTableLayoutPanel.GetColumn(uiLabel), _schCourseTable.WeekLength,
                _schCourseTable.CourseTableId);
            courseAddForm.ShowDialog();
            if (courseAddForm.DialogResult == DialogResult.OK)
            {
                SchCourse schCourse = courseAddForm.SchCourse;
                courseAddForm.Dispose();
                UpdateCourseShow(uiLabel,schCourse);
            }
        }


        /// <summary>
        /// 判断所展示的是否为第一周,如果是则上一周按钮功能无反应
        /// </summary>
        private bool IsFirstWeek()
        {
            return displayedWeekNumber <= 1;
        }


        /// <summary>
        /// 判断是否为最后一周，若是，则下一周按钮无反应
        /// </summary>
        private bool IsLastWeek()
        {
            return displayedWeekNumber >= _schCourseTable.WeekLength;
        }


        /// <summary>
        /// 展示前一周课程的按钮
        /// </summary>
        private void btnPre_Click(object sender, EventArgs e)
        {
            if (!IsFirstWeek())
            {
                displayedWeekNumber--;
                UpdateWeekNumber(displayedWeekNumber);
                UpdateCourseShow(displayedWeekNumber);
            }
        }


        /// <summary>
        /// 展示下一周课程的按钮
        /// </summary>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!IsLastWeek())
            {
                displayedWeekNumber++;
                UpdateWeekNumber(displayedWeekNumber);
                UpdateCourseShow(displayedWeekNumber);
            }
        }


        /// TODO: 需要根据系统时间，与传入课表的初始时间做差计算当前周数
        /// <summary>
        /// 获取系统时间，计算当前周数
        /// </summary>
        private void SetCurWeekNumber()
        {
        }


        /// TODO: 根据当前周数，刷新全局课表
        /// <summary>
        /// 刷新全局页面对应周数的课程
        /// </summary>
        private void UpdateCourseShow(int displayWeekNumber)
        {
        }


        /// TODO: 如何重新布局所修改的表格中的Label
        /// <summary>
        /// 针对新添加或修改的课程单独刷新展示
        /// </summary>
        private void UpdateCourseShow(UILabel uiLabel, SchCourse newSchCourse)
        {
            int oldStartTime = uiClassTableLayoutPanel.GetRow(uiLabel) + 1;
            int oldEndTime = oldStartTime + uiClassTableLayoutPanel.GetRowSpan(uiLabel) - 1;
            if (oldStartTime != newSchCourse.StartTime)
            {
                uiLabel.Text = String.Empty;
                uiLabel.BackColor = Color.FromArgb(243, 249, 255);
                uiClassTableLayoutPanel.SetRowSpan(uiLabel, 1);
                SetRangeVisible(newSchCourse.DayofWeek, oldStartTime, oldEndTime, true);
                SetRangeVisible(newSchCourse.DayofWeek, newSchCourse.StartTime, newSchCourse.EndTime, false);

                Control control =
                    uiClassTableLayoutPanel.GetControlFromPosition(newSchCourse.DayofWeek, newSchCourse.StartTime - 1);
                WriteCourseInfo(control, newSchCourse);
                uiClassTableLayoutPanel.SetRowSpan(control, newSchCourse.EndTime - newSchCourse.StartTime + 1);
            }
            else
            {
                if (oldEndTime < newSchCourse.EndTime)
                {
                    SetRangeVisible(newSchCourse.DayofWeek, oldEndTime, newSchCourse.EndTime, false);
                    uiClassTableLayoutPanel.SetRowSpan(uiLabel, newSchCourse.EndTime - newSchCourse.StartTime + 1);
                }
                else
                {
                    SetRangeVisible(newSchCourse.DayofWeek, newSchCourse.EndTime, oldEndTime, true);
                    uiClassTableLayoutPanel.SetRowSpan(uiLabel, newSchCourse.EndTime - newSchCourse.StartTime + 1);
                }
                WriteCourseInfo(uiLabel, newSchCourse);
            }
        }


        /// <summary>
        /// 设置课表单元格对应列的行范围的Visible值
        /// </summary>
        /// <param name="column">列</param>
        /// <param name="rowBegin">开始行数</param>
        /// <param name="rowEnd">结束行数</param>
        /// <param name="visible">是否可见</param>
        private void SetRangeVisible(int column, int rowBegin, int rowEnd, bool visible)
        {
            for (int i = rowBegin; i < rowEnd; i++)
            {
                uiClassTableLayoutPanel.GetControlFromPosition(column, i).Visible = visible;
            }
        }


        /// <summary>
        /// 判断课程是否在当前展示
        /// </summary>
        private bool IsCourseShow(SchCourse schClass)
        {
            return schClass.StartWeek <= displayedWeekNumber && schClass.EndWeek >= displayedWeekNumber;
        }


        /// <summary>
        /// 填写课程信息的单元格
        /// </summary>
        /// <param name="uiLabel"></param>
        /// <param name="course"></param>
        private void WriteCourseInfo(Control uiLabel, SchCourse course)
        {
            uiLabel.Text = course.SchCourseName + Environment.NewLine + course.ClassLocation +
                           Environment.NewLine + course.TeacherName;
            uiLabel.BackColor = Color.Chocolate;
        }
    }
}