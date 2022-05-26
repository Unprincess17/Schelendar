using System;
using System.Windows.Forms;
using Sunny.UI;


namespace Schelendar
{
    public partial class ClassTableForm : UIForm
    {
        /// <summary>
        /// 当前实际的周数
        /// </summary>
        private int currentWeekNumber = 1;

        /// <summary>
        /// 当前课表的总周数
        /// </summary>
        private int totalWeekNumber = 20;

        /// <summary>
        /// 当前页面所展示的课表的周数
        /// </summary>
        private int displayedWeekNumber = 1;

        public ClassTableForm()
        {
            InitializeComponent();
            //InitTableRows(13);

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
    }
}