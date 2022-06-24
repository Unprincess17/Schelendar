using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
using Schelendar.Models;

namespace Schelendar
{
    public partial class MainForm : UIForm
    {
        public MainForm()
        {
            InitializeComponent();
            // 每次进入最先显示当前课表
            InitPanel();

            createTomatoPath();

            InitFarmPlayer();

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
                        SettingForm2 settingForm = new SettingForm2();
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


        private void createTomatoPath()
        {
            string pathFile = "TomatoPath.txt";
            if (File.Exists(pathFile) == false)//不存在存储番茄路径文件
            {
                //File.Create(pathFile);
                FileStream fs = new FileStream(pathFile, FileMode.Append);
                StreamWriter wr = null;
                wr = new StreamWriter(fs);
                wr.WriteLine(@"C:\TomatoDate");
                wr.Close();
            }
            //FileInfo fi = new FileInfo(pathFile);   
            //if (fi.Length != 0)
            //{
            //return;
            //}
            //File.WriteAllText(pathFile, @"C:\TomatoDate");
            //using (var fs = new FileStream(pathFile, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, 0x1000, FileOptions.SequentialScan))
            //using (var sr = new StreamReader(fs))
            //{
            //string line = sr.ReadLine();
            //if (line == null)
            //File.WriteAllText(pathFile, @"C:\TomatoDate");
            //}
        }

        private void InitFarmPlayer()
        {
            FarmDBHelper farmDBHelper = new FarmDBHelper();
            farmDBHelper.create();
            //PlayerManager.initnewplayer("FarmUser1");
            PlayerManager.readdata("FarmUser1");
        }
        
    }
    
}