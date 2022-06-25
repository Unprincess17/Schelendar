using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Sunny.UI;
using Schelendar.Models;

namespace Schelendar
{
    public partial class CalendarForm : UIForm
    {
        class Task
        {
            public String Name { get; set; }
            public DateTime Time { get; set; }
            
        }
        
        public CalendarForm()
        {
            InitializeComponent();
            List<SchTask> courseTemplates = SchUserManager.GetTasksWithoutCourses();
            
            foreach (var courseTemplate in courseTemplates)
            {
                UILabel uiLabel = new UILabel();
                UIDatetimePicker datetimePicker = new UIDatetimePicker();
                uiLabel.Text = courseTemplate.SchTaskInfo;
                uiLabel.Dock = DockStyle.Fill;
                uiLabel.TextAlign = ContentAlignment.MiddleRight;
                datetimePicker.Value = courseTemplate.StartDate;
                datetimePicker.Dock = DockStyle.Fill;
                datetimePicker.ReadOnly = true;
                templateTable.Controls.Add(uiLabel, 0, templateTable.RowCount-1);
                templateTable.Controls.Add(datetimePicker, 1, templateTable.RowCount-1);
                templateTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
                templateTable.RowCount++;
            }
            
        }
    }
}