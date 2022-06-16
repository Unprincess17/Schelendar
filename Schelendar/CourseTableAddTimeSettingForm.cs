using System;
using System.Drawing;
using System.Windows.Forms;
using Sunny.UI;
using Schelendar.Models;
using System.Collections.Generic;


namespace Schelendar
{
    public partial class CourseTableAddTimeSettingForm : UIForm
    {
        /// <summary>
        /// 初始化课表每节课的时间
        /// </summary>
        private readonly DateTime _initTime = DateTime.Parse("00:00:00");
        
        /// <summary>
        /// 设置的时间
        /// </summary>
        public List<Dictionary<String, CourseTime>> EveryCourseTime = new List<Dictionary<string, CourseTime>>();


        public CourseTableAddTimeSettingForm(int dayCourseNumber)
        {
            InitializeComponent();
            InitTableRows(dayCourseNumber);
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
                    UITimePicker uiTimePicker = new UITimePicker();
                    uiTimePicker.Value = _initTime;
                    uiTimePicker.Name = j == 0 ? "start" : "end" + " TP" + i;
                    uiTimePicker.TimeFormat = "HH:mm";
                    uiTimePicker.Dock = DockStyle.Fill;
                    uiTimePicker.ValueChanged += uiTimePicker_ValueChanged;
                    uiTimeSettingTableLayoutPanel.Controls.Add(uiTimePicker, j == 0 ? 1 : 3,
                        uiTimeSettingTableLayoutPanel.RowCount - 1);
                }
            }
        }


        /// <summary>
        /// 保证每次设置的时间大小合乎事实，绑定到时间控件的ValueChanged事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="value"></param>
        private void uiTimePicker_ValueChanged(object sender, DateTime value)
        {
            UITimePicker uiTimePicker = (UITimePicker) sender;
            TableLayoutPanelCellPosition position = uiTimeSettingTableLayoutPanel.GetCellPosition(uiTimePicker);

            if (position.Row == 1 && position.Column == 1)
            {
                UITimePicker next =
                    (UITimePicker) uiTimeSettingTableLayoutPanel.GetControlFromPosition(3, position.Row);
                if (IsTimeAfter(value, next.Value))
                {
                    UIMessageDialog.ShowErrorDialog(this, "时间设置错误");
                    uiTimePicker.Value = next.Value;
                }
            }
            else if (position.Row == uiTimeSettingTableLayoutPanel.RowCount - 1 && position.Column == 3)
            {
                UITimePicker pre = (UITimePicker) uiTimeSettingTableLayoutPanel.GetControlFromPosition(1, position.Row);
                if (IsTimeBefore(value, pre.Value))
                {
                    UIMessageDialog.ShowErrorDialog(this, "时间设置错误");
                    uiTimePicker.Value = pre.Value;
                }
            }
            else
            {
                UITimePicker pre = (UITimePicker) uiTimeSettingTableLayoutPanel
                    .GetControlFromPosition((position.Column + 2) % 4, position.Row - (position.Column == 3 ? 0 : 1));
                UITimePicker next = (UITimePicker) uiTimeSettingTableLayoutPanel
                    .GetControlFromPosition((position.Column + 2) % 4, position.Row + (position.Column == 1 ? 0 : 1));
                if (IsTimeBefore(value, pre.Value) || IsTimeAfter(value, next.Value))
                {
                    uiTimePicker.Value = pre.Value;
                    UIMessageDialog.ShowErrorDialog(this, "时间设置错误");
                }
            }
        }


        /// <summary>
        /// 比较当前时间是否早于前面的时间
        /// </summary>
        /// <param name="cur"></param>
        /// <param name="pre"></param>
        /// <returns></returns>
        private bool IsTimeBefore(DateTime cur, DateTime pre)
        {
            return cur.TimeOfDay < pre.TimeOfDay && pre.TimeOfDay != _initTime.TimeOfDay;
        }


        /// <summary>
        /// 比较当前时间是否晚于后面的时间
        /// </summary>
        /// <param name="cur"></param>
        /// <param name="next"></param>
        /// <returns></returns>
        private bool IsTimeAfter(DateTime cur, DateTime next)
        {
            return cur.TimeOfDay > next.TimeOfDay && next.TimeOfDay != _initTime.TimeOfDay;
        }

        
        /// <summary>
        /// 返回上一个设置界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        /// <summary>
        /// 确定添加课程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void ensureBtn_Click(object sender, EventArgs e)
        {
            
            for (int i = 1; i < uiTimeSettingTableLayoutPanel.RowCount; i++)
            {
                UITimePicker start = (UITimePicker) uiTimeSettingTableLayoutPanel.GetControlFromPosition(1, i);
                UITimePicker end = (UITimePicker) uiTimeSettingTableLayoutPanel.GetControlFromPosition(3, i);
                if (start.Value.TimeOfDay.Equals(_initTime.TimeOfDay) ||
                    end.Value.TimeOfDay.Equals(_initTime.TimeOfDay))
                {
                    UIMessageDialog.ShowErrorDialog(this, "时间设置存在错误");
                    return;
                }
                EveryCourseTime.Add(new Dictionary<string, CourseTime>()
                    {{"StartTime", new CourseTime(start.Value.TimeOfDay.Hours, start.Value.TimeOfDay.Minutes)},
                        {"EndTime", new CourseTime(end.Value.TimeOfDay.Hours, end.Value.TimeOfDay.Minutes)}});
            }
            DialogResult = DialogResult.Yes;
            Close();
        }
    }
}