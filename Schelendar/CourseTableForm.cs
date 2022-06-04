﻿using System;
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
        /// 当前星期数
        /// </summary>
        private int curWeekDay = 1;

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
        /// 课程与显示位置的映射表
        /// </summary>
        private Dictionary<UILabel, SchCourse> courseUILableMap = new Dictionary<UILabel, SchCourse>();


        /// <summary>
        /// 颜色选择
        /// </summary>
        public struct CourseTableColor
        {
            public static readonly Color DefaultColor = Color.FromArgb(243, 249, 255);
            public static readonly Color DodgerBlue = Color.DodgerBlue;
            public static readonly Color WaitForEdit = Color.LightGray;
        }


        /// TODO: 构造函数需要传入课表ID并初始化课表对象和课程
        /// <summary>
        /// 
        /// </summary>
        public ClassTableForm()
        {
            Visible = false;
            InitializeComponent();
            InitTableRows(_schCourseTable.DayCourseNumber);
            // TODO: 初始化时间
            // SetCurWeekNumber();
            // MarkToday();
            for (int i = 0; i < _schCourseTable.DayCourseNumber; i++)
            {
                UILabel uiTimeLable = new UILabel();
                uiTimeLable.Dock = DockStyle.Fill;
                uiTimeLable.TextAlign = ContentAlignment.MiddleCenter;
                uiTimeLable.Text = _schCourseTable.EveryCourseTime[i].GetValue("StartTime") + Environment.NewLine +
                                   _schCourseTable.EveryCourseTime[i].GetValue("EndTime");
                uiClassTableLayoutPanel.Controls.Add(uiTimeLable, 0, i);
            }

            // TODO: 初始化课表,在这里查询得到列表
            // InitMap();
            // UpdateCourseShow();
            Visible = true;
        }


        /// <summary>
        /// 初始化课程与Label的映射表
        /// </summary>
        /// <param name="schCourses">课程列表</param>
        private void InitMap(List<SchCourse> schCourses)
        {
            foreach (SchCourse course in schCourses)
            {
                Control control =
                    uiClassTableLayoutPanel.GetControlFromPosition(course.DayofWeek, course.StartTime - 1);
                courseUILableMap.Add((UILabel) control, course);
            }
        }


        /// <summary>
        /// 初始化当前第几周
        /// </summary>
        /// <param name="number">当前为第几周</param>
        private void UpdateWeekNumber()
        {
            weekLable.Text = "WEEK " + displayedWeekNumber;
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
            Color oldColor = uiLabel.BackColor;
            uiLabel.BackColor = CourseTableColor.WaitForEdit;
            SchCourse course = courseUILableMap.GetValue(uiLabel);
            CourseAddForm courseAddForm;
            if (course == null)
            {
                courseAddForm = new CourseAddForm(uiClassTableLayoutPanel.GetRow(uiLabel) + 1,
                    _schCourseTable.DayCourseNumber,
                    uiClassTableLayoutPanel.GetColumn(uiLabel), _schCourseTable.WeekLength,
                    _schCourseTable.CourseTableId);
            }
            else
            {
                courseAddForm = new CourseAddForm(course, _schCourseTable.DayCourseNumber,
                    uiClassTableLayoutPanel.GetColumn(uiLabel), _schCourseTable.WeekLength,
                    _schCourseTable.CourseTableId);
            }

            courseAddForm.ShowDialog();
            if (courseAddForm.DialogResult == DialogResult.OK)
            {
                courseUILableMap.Remove(uiLabel);
                SchCourse schCourse = courseAddForm.SchCourse;
                courseAddForm.Dispose();
                UpdateCourseShow(uiLabel, schCourse);
                Control control =
                    uiClassTableLayoutPanel.GetControlFromPosition(schCourse.DayofWeek, schCourse.StartTime - 1);
                courseUILableMap.Add((UILabel) control, schCourse);
            }
            else if (courseAddForm.DialogResult == DialogResult.Cancel)
            {
                uiLabel.BackColor = oldColor;
            }
            else if (courseAddForm.DialogResult == DialogResult.Abort)
            {
                courseUILableMap.Remove(uiLabel);
                HideCourse(uiLabel, course);
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
                uiClassTableLayoutPanel.Visible = false;
                displayedWeekNumber--;
                UpdateWeekNumber();
                UpdateCourseShow();
                uiClassTableLayoutPanel.Visible = true;
            }
        }


        /// <summary>
        /// 展示下一周课程的按钮
        /// </summary>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!IsLastWeek())
            {
                uiClassTableLayoutPanel.Visible = false;
                displayedWeekNumber++;
                UpdateWeekNumber();
                UpdateCourseShow();
                uiClassTableLayoutPanel.Visible = true;
            }
        }


        /// <summary>
        /// 获取系统时间，计算当前周数
        /// </summary>
        private void SetCurWeekNumber()
        {
            //_schCourseTable.StartDateTime = new DateTime(2022, 5, 16);
            DateTime now = DateTime.Now;
            TimeSpan timeSpan = now - _schCourseTable.StartDateTime;
            curWeekNumber = timeSpan.Days / 7 + 1;
            curWeekDay = timeSpan.Days % 7 + 1;
            displayedWeekNumber = curWeekNumber;
            UpdateWeekNumber();
        }


        /// <summary>
        /// 标记今天的星期
        /// </summary>
        private void MarkToday()
        {
            Control control = uiTimeTableLayoutPanel.GetControlFromPosition(curWeekDay, 0);
            control.BackColor = Color.Aqua;
        }


        /// <summary>
        /// 刷新全局页面对应周数的课程
        /// </summary>
        private void UpdateCourseShow()
        {
            foreach (UILabel uiLabel in courseUILableMap.Keys)
            {
                SchCourse course = courseUILableMap.GetValue(uiLabel);
                HideCourse(uiLabel, course);
                if (IsCourseShow(course))
                {
                    ShowCourse(course);
                }
            }
        }


        /// <summary>
        /// 针对新添加或修改的课程单独刷新展示
        /// </summary>
        private void UpdateCourseShow(UILabel uiLabel, SchCourse newSchCourse)
        {
            int oldStartTime = uiClassTableLayoutPanel.GetRow(uiLabel) + 1;
            int oldEndTime = oldStartTime + uiClassTableLayoutPanel.GetRowSpan(uiLabel) - 1;
            SchCourse oldCourse = new SchCourse(newSchCourse.DayofWeek, oldStartTime, oldEndTime);
            HideCourse(uiLabel, oldCourse);
            if (IsCourseShow(newSchCourse))
            {
                ShowCourse(newSchCourse);
            }
        }


        /// <summary>
        /// 隐藏或不显示课程
        /// </summary>
        /// <param name="uiLabel"></param>
        /// <param name="course"></param>
        private void HideCourse(UILabel uiLabel, SchCourse course)
        {
            RestoreOriginal(uiLabel);
            SetRangeVisible(course.DayofWeek, course.StartTime, course.EndTime, true);
        }


        /// <summary>
        /// 显示课程
        /// </summary>
        /// <param name="course"></param>
        private void ShowCourse(SchCourse course)
        {
            SetRangeVisible(course.DayofWeek, course.StartTime, course.EndTime, false);
            Control control =
                uiClassTableLayoutPanel.GetControlFromPosition(course.DayofWeek, course.StartTime - 1);
            control.Visible = true;
            WriteCourseInfo((UILabel) control, course);
            uiClassTableLayoutPanel.SetRowSpan(control, course.EndTime - course.StartTime + 1);
        }


        /// <summary>
        /// 将课表某个的label清空
        /// </summary>
        /// <param name="uiLabel"></param>
        private void RestoreOriginal(UILabel uiLabel)
        {
            uiLabel.Text = String.Empty;
            uiLabel.BackColor = CourseTableColor.DefaultColor;
            uiLabel.Visible = true;
            uiClassTableLayoutPanel.SetRowSpan(uiLabel, 1);
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
            return (schClass.StartWeek <= displayedWeekNumber) && (schClass.EndWeek >= displayedWeekNumber);
        }


        /// TODO: 是否还要添加颜色选择功能（待定）
        /// <summary>
        /// 填写课程信息的单元格
        /// </summary>
        /// <param name="uiLabel"></param>
        /// <param name="course"></param>
        private void WriteCourseInfo(UILabel uiLabel, SchCourse course)
        {
            uiLabel.Text = course.SchCourseName + Environment.NewLine + course.ClassLocation +
                           Environment.NewLine + course.TeacherName;
            uiLabel.BackColor = CourseTableColor.DodgerBlue;
        }
    }
}