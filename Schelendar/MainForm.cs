﻿using System;
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
        public readonly int CurUserId;


        public MainForm(int curUserId)
        {
            InitializeComponent();
            CurUserId = curUserId;
            //TODO: 查询当前用户的当前课表id，如果没有则返回-1
            InitPanel(-1);
        }

        /// <summary>
        /// 初始化导航栏节点的类
        /// </summary>
        private class NodeInfo
        {
            public int CourseTableId;

            public String CourseTableName;

            public NodeInfo(int courseTableId, String courseTableName)
            {
                CourseTableId = courseTableId;
                CourseTableName = courseTableName;
            }
        }


        /// <summary>
        /// 初始化左侧导航栏其他课表项目
        /// </summary>
        public void InitNavMenu()
        {
            //TODO: 使用CurUserId查询不是当前课表的所有课表，返回Id与Name组成的列表,为空时返回null
            List<NodeInfo> courseTableNodes = null;

            TreeNode otherTableNode = uiNavMenu.Nodes.Find("menu_class_last", true).First();
            otherTableNode.Nodes.Clear();
            if (!courseTableNodes.IsNullOrEmpty())
            {
                foreach (NodeInfo nodeInfo in courseTableNodes)
                {
                    TreeNode node = new TreeNode(nodeInfo.CourseTableName);
                    node.Name = nodeInfo.CourseTableId.ToString();
                    otherTableNode.Nodes.Add(node);
                }
            }
        }


        ///<summary>
        /// 导航栏的选择事件
        /// </summary> 
        private void uiNavMenu_MenuItemClick(TreeNode node, NavMenuItem item, int pageIndex)
        {
            if (!node.Name.Equals("menu_class"))
            {
                uiPanel.Controls.Clear();
                switch (node.Name)
                {
                    case "menu_class_cur":
                        //TODO: 查询当前课表的Id并返回,如果为空返回-1
                        int curTableId = -1;
                        InitPanel(curTableId);
                        break;
                    case "menu_class_last":
                        Visible = false;
                        InitNavMenu();
                        Visible = true;
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
                    default:
                        CourseTableForm courseTableForm = new CourseTableForm(Convert.ToInt32(node.Name));
                        InitForm(courseTableForm);
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
                uiPanel.Click += uiPanel_Click;
            }
            else
            {
                CourseTableForm courseTableFormCur = new CourseTableForm(curTableId);
                InitForm(courseTableFormCur);
            }
        }


        /// <summary>
        /// 课表为空时的点击添加事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void uiPanel_Click(object sender, EventArgs args)
        {
            CourseTableAddForm courseTableAddForm = new CourseTableAddForm();
            if (courseTableAddForm.ShowDialog() == DialogResult.Yes)
            {
                CourseTableForm courseTableFormCur = new CourseTableForm(courseTableAddForm.CourseTableAddId);
                InitForm(courseTableFormCur);
                uiPanel.Click -= uiPanel_Click;
            }
        }
    }
}