using System;
using Sunny.UI;


namespace Schelendar
{
    public partial class ClassTableForm : UIForm
    {
        /// <summary>
        /// 当前实际的周数
        /// </summary>
        private int currentWeekNumber;

        /// <summary>
        /// 当前课表的总周数
        /// </summary>
        private int totalWeekNumber;

        /// <summary>
        /// 当前页面所展示的课表的周数
        /// </summary>
        private int displayedWeekNumber;

        public ClassTableForm()
        {
            InitializeComponent();
            InitTableRows(2);
            // classTableView.Rows[0].Cells[0].Value = "s\nf";
            // classTableView.Rows[0].Height = 50;
            classTableView.ClearRows();
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
            for (int i = 0; i < number; i++)
            {
                classTableView.AddRow();
            }
        }


        /// TODO: 课表的数据绑定，如何传入课程数据
        private void BindingClass()
        {
        }


        /// <summary>
        /// 判断所展示的是否为第一周和最后一周,如果是则按钮功能无反应
        /// </summary>
        private bool IsFirstOrLastWeek()
        {
            return displayedWeekNumber >= totalWeekNumber || displayedWeekNumber <= 1;
        }


        /// TODO: 需要调用绑定课程的方法来刷新
        /// <summary>
        /// 展示前一周课程的按钮
        /// </summary>
        private void btnPre_Click(object sender, EventArgs e)
        {
            if (!IsFirstOrLastWeek())
            {
                displayedWeekNumber--;
            }
            else
            {
                classTableView.ClearRows();
            }
        }


        /// TODO: 需要调用绑定课程的方法来刷新
        /// <summary>
        /// 展示下一周课程的按钮
        /// </summary>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!IsFirstOrLastWeek())
            {
                displayedWeekNumber++;
            }
            else
            {
                classTableView.ClearRows();
            }
        }
    }
}