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
    public partial class MainForm : UIForm
    {
        /// <summary>
        /// 当前用户的ID
        /// </summary>
        private int _curUserId;
        
        
        public MainForm(int curUserId)
        {
            InitializeComponent();
            _curUserId = curUserId;
            //TODO: 查询当前用户的当前课表id，如果没有则返回-1
            InitPanel(-1);
        }


        /// TODO: 将查询的全部课表Id与节点建立映射
        /// <summary>
        /// 初始化左侧导航栏项目
        /// </summary>
        private void InitNavMenu()
        {
            
        }


        // 导航栏的选择事件
        private void uiNavMenu_MenuItemClick(TreeNode node, NavMenuItem item, int pageIndex)
        {
            if (!node.Name.Equals("menu_class"))
            {
                uiPanel.Controls.Clear();
                switch (node.Name)
                {
                    case "menu_class_cur":
                        CourseTableForm courseTableFormCur = new CourseTableForm(-1);
                        InitForm(courseTableFormCur);
                        break;
                    case "menu_class_last":
                        CourseTableForm courseTableFormLast = new CourseTableForm(-1);
                        InitForm(courseTableFormLast);
                        break;
                    case "menu_class_add":
                        ClassTableSettingForm classTableSettingForm = new ClassTableSettingForm();
                        InitForm(classTableSettingForm);
                        break;
                    case "menu_calendar":
                        CalendarForm calendarForm = new CalendarForm();
                        InitForm(calendarForm);
                        break;
                    case "menu_deadline":
                        DeadlineForm deadlineForm = new DeadlineForm();
                        InitForm(deadlineForm);
                        break;
                    case "menu_tomatoclock":
                        TomatoClockForm tomatoClockForm = new TomatoClockForm();
                        InitForm(tomatoClockForm);
                        break;
                    case "menu_farm":
                        EnterFarmForm enterFarmForm = new EnterFarmForm();
                        InitForm(enterFarmForm);
                        break;
                    case "menu_setting":
                        SettingForm settingForm = new SettingForm();
                        InitForm(settingForm);
                        break;
                }
            }
        }


        /// <summary>
        /// 界面嵌入panel要做的处理
        /// </summary>
        /// <param name="uiForm"></param>
        private void InitForm(UIForm uiForm)
        {
            uiForm.FormBorderStyle = FormBorderStyle.None; // 取消边框
            uiForm.TopLevel = false; // 取消最顶层
            uiPanel.Controls.Add(uiForm); // 添加
            uiForm.Dock = DockStyle.Fill;
            uiForm.Show();
        }

        
        /// <summary>
        /// 初始化时显示界面为当前课表
        /// </summary>
        private void InitPanel(int curTableId)
        {
            if (curTableId == -1)
            {
                uiPanel.Text = "当前为空课表，点击创建";
                uiPanel.Click += (sender, args) =>
                {
                    CourseTableAddForm courseTableAddForm = new CourseTableAddForm();
                    if (courseTableAddForm.ShowDialog() == DialogResult.Yes)
                    {
                        CourseTableForm courseTableFormCur = new CourseTableForm(courseTableAddForm.CourseTableAddId);
                        InitForm(courseTableFormCur);
                    }
                };
                return;
            }
            else
            {
                CourseTableForm courseTableFormCur = new CourseTableForm(curTableId);
                InitForm(courseTableFormCur);
            }
            
        }
    }
}