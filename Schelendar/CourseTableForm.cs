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
        /// 当前课表的总周数
        /// </summary>
        private int totalWeekNumber = 20;

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
            // InitTableRows(13);
            InitTableRows(_schCourseTable.DayCourseNumber);
            totalWeekNumber = _schCourseTable.WeekLength;
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
                    uiClassTableLayoutPanel.Controls.Add(uiClassLabel, i+1, uiClassTableLayoutPanel.RowCount-1);
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

        
        /// TODO: 需要弹出一个新的界面来实现添加课程的功能
        /// <summary>
        /// 双击添加课程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uiClassLabel_DoubleClick(object sender, EventArgs e)
        {
            UILabel uiLabel = (UILabel) sender;
            uiLabel.Text = "双击处";
        }


        /// TODO: 课表的数据绑定，如何传入课程数据
        private void BindingClass()
        {
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
            return displayedWeekNumber >= totalWeekNumber;
        }


        /// TODO: 需要调用绑定课程的方法来刷新
        /// <summary>
        /// 展示前一周课程的按钮
        /// </summary>
        private void btnPre_Click(object sender, EventArgs e)
        {
            if (!IsFirstWeek())
            {
                displayedWeekNumber--;
                UpdateWeekNumber(displayedWeekNumber);
            }
        }


        /// TODO: 需要调用绑定课程的方法来刷新
        /// <summary>
        /// 展示下一周课程的按钮
        /// </summary>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!IsLastWeek())
            {
                displayedWeekNumber++;
                UpdateWeekNumber(displayedWeekNumber);
            }
        }


        /// TODO: 需要根据系统时间，与传入课表的初始时间做差计算当前周数
        /// <summary>
        /// 获取系统时间，计算当前周数
        /// </summary>
        private void SetCurWeekNumber()
        {
            
        }


        /// TODO: 需要根据课表对象，设置显示，使用UILabel来进行课表的显示
        /// <summary>
        /// 刷新当前页面对应周数的课程
        /// </summary>
        private void UpdateClass()
        {
            
        }

        
        /// <summary>
        /// 判断课程是否在当前展示
        /// </summary>
        private bool IsCourseShow(SchCourse schClass)
        {
            return schClass.StartWeek <= displayedWeekNumber && schClass.EndWeek >= displayedWeekNumber;
        }


        private void addClickListener()
        {
            
        }
    }
}