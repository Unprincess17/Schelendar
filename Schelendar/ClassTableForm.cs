﻿using System;
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
        private SchClassTable _schClassTable;
        
        
        /// TODO: 构造函数需要传入课表ID
        /// <summary>
        /// 
        /// </summary>
        public ClassTableForm()
        {
            InitializeComponent();
            // InitTableRows(13);

        }


        /// <summary>
        /// 初始化当前第几周
        /// </summary>
        /// <param name="number">当前为第几周</param>
        private void UpdateWeekNumber(int number)
        {
            weekLable.Text = "WEEK " + number;
        }


        /// TODO: 课表初始设定节数和每节课时间，还需考虑如何传入时间
        /// <param name="number">每天课程数量</param>
        private void InitTableRows(int number)
        {
            while (uiClassTableLayoutPanel.RowCount <= number)
            {
                uiClassTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 100));
                uiClassTableLayoutPanel.RowCount++;
            }
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


        /// TODO: 需要根据课表对象，设置显示，使用button来进行课表的显示
        /// <summary>
        /// 刷新当前页面对应周数的课程
        /// </summary>
        private void UpdateClass()
        {
            
        }
    }
}