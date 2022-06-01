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
        public CourseTableAddTimeSettingForm()
        {
            InitializeComponent();
            InitTableRows(11);
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
    }
}
