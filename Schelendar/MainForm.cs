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
        public MainForm()
        {
            InitializeComponent();
            // 每次进入最先显示当前课表
            InitPanel();
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
                        ClassTableForm classTableFormCur = new ClassTableForm();
                        InitForm(classTableFormCur);
                        break;
                    case "menu_class_last":
                        ClassTableForm classTableFormLast = new ClassTableForm();
                        InitForm(classTableFormLast);
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
                        FarmForm farmForm = new FarmForm();
                        InitForm(farmForm);
                        break;
                    case "menu_setting":
                        SettingForm settingForm = new SettingForm();
                        InitForm(settingForm);
                        break;
                }
            }
        }


        // 各个界面嵌入panel
        private void InitForm(UIForm uiForm)
        {
            uiForm.FormBorderStyle = FormBorderStyle.None; // 取消边框
            uiForm.TopLevel = false; // 取消最顶层
            uiPanel.Controls.Add(uiForm); // 添加
            uiForm.Dock = DockStyle.Fill;
            uiForm.Show();
        }


        // 初始化时显示界面为当前课表
        private void InitPanel()
        {
            ClassTableForm classTableFormCur = new ClassTableForm();
            InitForm(classTableFormCur);
        }
    }
}