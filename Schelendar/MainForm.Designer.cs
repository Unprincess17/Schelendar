
namespace Schelendar
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("当前课表");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("其他");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("课程表", new System.Windows.Forms.TreeNode[] {treeNode1, treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("日程表");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("倒计时");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("番茄钟");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("设置");
            this.uiSplitContainer1 = new Sunny.UI.UISplitContainer();
            this.uiNavMenu = new Sunny.UI.UINavMenu();
            this.uiPanel = new Sunny.UI.UIPanel();
            ((System.ComponentModel.ISupportInitialize) (this.uiSplitContainer1)).BeginInit();
            this.uiSplitContainer1.Panel1.SuspendLayout();
            this.uiSplitContainer1.Panel2.SuspendLayout();
            this.uiSplitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiSplitContainer1
            // 
            this.uiSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.uiSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiSplitContainer1.Location = new System.Drawing.Point(0, 30);
            this.uiSplitContainer1.MinimumSize = new System.Drawing.Size(20, 20);
            this.uiSplitContainer1.Name = "uiSplitContainer1";
            // 
            // uiSplitContainer1.Panel1
            // 
            this.uiSplitContainer1.Panel1.Controls.Add(this.uiNavMenu);
            // 
            // uiSplitContainer1.Panel2
            // 
            this.uiSplitContainer1.Panel2.Controls.Add(this.uiPanel);
            this.uiSplitContainer1.Size = new System.Drawing.Size(982, 564);
            this.uiSplitContainer1.SplitterDistance = 178;
            this.uiSplitContainer1.SplitterWidth = 11;
            this.uiSplitContainer1.TabIndex = 0;
            this.uiSplitContainer1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiNavMenu
            // 
            this.uiNavMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uiNavMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiNavMenu.DrawMode = System.Windows.Forms.TreeViewDrawMode.OwnerDrawAll;
            this.uiNavMenu.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiNavMenu.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (240)))), ((int) (((byte) (240)))), ((int) (((byte) (240)))));
            this.uiNavMenu.FullRowSelect = true;
            this.uiNavMenu.ItemHeight = 50;
            this.uiNavMenu.Location = new System.Drawing.Point(0, 0);
            this.uiNavMenu.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            this.uiNavMenu.Name = "uiNavMenu";
            treeNode1.Name = "menu_class_cur";
            treeNode1.Text = "当前课表";
            treeNode2.Name = "menu_class_last";
            treeNode2.Text = "其他";
            treeNode3.Name = "menu_class";
            treeNode3.Text = "课程表";
            treeNode4.Name = "menu_calendar";
            treeNode4.Text = "日程表";
            treeNode5.Name = "menu_deadline";
            treeNode5.Text = "倒计时";
            treeNode6.Name = "menu_tomatoclock";
            treeNode6.Text = "番茄钟";
            treeNode7.Name = "menu_setting";
            treeNode7.Text = "设置";
            this.uiNavMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {treeNode3, treeNode4, treeNode5, treeNode6, treeNode7});
            this.uiNavMenu.ScrollBarColor = System.Drawing.Color.FromArgb(((int) (((byte) (240)))), ((int) (((byte) (240)))), ((int) (((byte) (240)))));
            this.uiNavMenu.ScrollBarHoverColor = System.Drawing.Color.FromArgb(((int) (((byte) (240)))), ((int) (((byte) (240)))), ((int) (((byte) (240)))));
            this.uiNavMenu.ScrollBarPressColor = System.Drawing.Color.FromArgb(((int) (((byte) (240)))), ((int) (((byte) (240)))), ((int) (((byte) (240)))));
            this.uiNavMenu.ShowLines = false;
            this.uiNavMenu.Size = new System.Drawing.Size(178, 564);
            this.uiNavMenu.TabIndex = 0;
            this.uiNavMenu.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiNavMenu.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiNavMenu.MenuItemClick += new Sunny.UI.UINavMenu.OnMenuItemClick(this.uiNavMenu_MenuItemClick);
            // 
            // uiPanel
            // 
            this.uiPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiPanel.Location = new System.Drawing.Point(0, 0);
            this.uiPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel.Name = "uiPanel";
            this.uiPanel.Size = new System.Drawing.Size(793, 564);
            this.uiPanel.TabIndex = 0;
            this.uiPanel.Text = "这里根据Menu的选择来动态变化";
            this.uiPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(982, 594);
            this.Controls.Add(this.uiSplitContainer1);
            this.MaximumSize = new System.Drawing.Size(1760, 877);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.Text = "Schelendar";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 733, 383);
            this.uiSplitContainer1.Panel1.ResumeLayout(false);
            this.uiSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.uiSplitContainer1)).EndInit();
            this.uiSplitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private Sunny.UI.UINavBar uiNavBarSetting;

        private Sunny.UI.UIPanel uiPanel;

        private Sunny.UI.UISplitContainer uiSplitContainer1;

        private Sunny.UI.UINavMenu uiNavMenu;

        #endregion
    }
}