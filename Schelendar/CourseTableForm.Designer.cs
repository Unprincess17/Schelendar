using System.ComponentModel;

namespace Schelendar
{
    partial class CourseTableForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridBoolColumn1 = new System.Windows.Forms.DataGridBoolColumn();
            this.titlePanel = new Sunny.UI.UIPanel();
            this.stateLabel = new Sunny.UI.UILedLabel();
            this.weekLable = new Sunny.UI.UILedLabel();
            this.btnNext = new Sunny.UI.UIButton();
            this.btnPre = new Sunny.UI.UIButton();
            this.uiSettingContextMenuStrip = new Sunny.UI.UIContextMenuStrip();
            this.设为当前课表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.创建课表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除课表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改课表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uiTimeTableLayoutPanel = new Sunny.UI.UITableLayoutPanel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiClassTableLayoutPanel = new Sunny.UI.UITableLayoutPanel();
            this.titlePanel.SuspendLayout();
            this.uiSettingContextMenuStrip.SuspendLayout();
            this.uiTimeTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.Width = -1;
            // 
            // dataGridBoolColumn1
            // 
            this.dataGridBoolColumn1.Width = -1;
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.stateLabel);
            this.titlePanel.Controls.Add(this.weekLable);
            this.titlePanel.Controls.Add(this.btnNext);
            this.titlePanel.Controls.Add(this.btnPre);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.titlePanel.MinimumSize = new System.Drawing.Size(1, 1);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Padding = new System.Windows.Forms.Padding(5);
            this.titlePanel.Size = new System.Drawing.Size(800, 47);
            this.titlePanel.TabIndex = 0;
            this.titlePanel.Text = null;
            this.titlePanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.titlePanel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // stateLabel
            // 
            this.stateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stateLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.stateLabel.Location = new System.Drawing.Point(110, 5);
            this.stateLabel.MinimumSize = new System.Drawing.Size(1, 1);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(174, 37);
            this.stateLabel.TabIndex = 3;
            this.stateLabel.Text = "ON";
            this.stateLabel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // weekLable
            // 
            this.weekLable.Dock = System.Windows.Forms.DockStyle.Right;
            this.weekLable.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.weekLable.Location = new System.Drawing.Point(284, 5);
            this.weekLable.MinimumSize = new System.Drawing.Size(1, 1);
            this.weekLable.Name = "weekLable";
            this.weekLable.Size = new System.Drawing.Size(406, 37);
            this.weekLable.TabIndex = 2;
            this.weekLable.Text = "WEEK 1";
            this.weekLable.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnNext
            // 
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNext.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.btnNext.Location = new System.Drawing.Point(690, 5);
            this.btnNext.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(105, 37);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "下一周";
            this.btnNext.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.btnNext.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPre
            // 
            this.btnPre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPre.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPre.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.btnPre.Location = new System.Drawing.Point(5, 5);
            this.btnPre.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(105, 37);
            this.btnPre.TabIndex = 0;
            this.btnPre.Text = "前一周";
            this.btnPre.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.btnPre.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // uiSettingContextMenuStrip
            // 
            this.uiSettingContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (243)))), ((int) (((byte) (249)))), ((int) (((byte) (255)))));
            this.uiSettingContextMenuStrip.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiSettingContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.设为当前课表ToolStripMenuItem, this.创建课表ToolStripMenuItem, this.删除课表ToolStripMenuItem, this.修改课表ToolStripMenuItem});
            this.uiSettingContextMenuStrip.Name = "uiSettingContextMenuStrip";
            this.uiSettingContextMenuStrip.Size = new System.Drawing.Size(205, 132);
            this.uiSettingContextMenuStrip.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // 设为当前课表ToolStripMenuItem
            // 
            this.设为当前课表ToolStripMenuItem.Name = "设为当前课表ToolStripMenuItem";
            this.设为当前课表ToolStripMenuItem.Size = new System.Drawing.Size(204, 32);
            this.设为当前课表ToolStripMenuItem.Text = "设为当前课表";
            // 
            // 创建课表ToolStripMenuItem
            // 
            this.创建课表ToolStripMenuItem.Name = "创建课表ToolStripMenuItem";
            this.创建课表ToolStripMenuItem.Size = new System.Drawing.Size(204, 32);
            this.创建课表ToolStripMenuItem.Text = "创建新课表";
            // 
            // 删除课表ToolStripMenuItem
            // 
            this.删除课表ToolStripMenuItem.Name = "删除课表ToolStripMenuItem";
            this.删除课表ToolStripMenuItem.Size = new System.Drawing.Size(204, 32);
            this.删除课表ToolStripMenuItem.Text = "删除课表";
            // 
            // 修改课表ToolStripMenuItem
            // 
            this.修改课表ToolStripMenuItem.Name = "修改课表ToolStripMenuItem";
            this.修改课表ToolStripMenuItem.Size = new System.Drawing.Size(204, 32);
            this.修改课表ToolStripMenuItem.Text = "修改课表";
            // 
            // uiTimeTableLayoutPanel
            // 
            this.uiTimeTableLayoutPanel.AutoScroll = true;
            this.uiTimeTableLayoutPanel.ColumnCount = 8;
            this.uiTimeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.027093F));
            this.uiTimeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.13899F));
            this.uiTimeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.625F));
            this.uiTimeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.375F));
            this.uiTimeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.125F));
            this.uiTimeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.875F));
            this.uiTimeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.125F));
            this.uiTimeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.5F));
            this.uiTimeTableLayoutPanel.Controls.Add(this.uiLabel1, 1, 0);
            this.uiTimeTableLayoutPanel.Controls.Add(this.uiLabel2, 2, 0);
            this.uiTimeTableLayoutPanel.Controls.Add(this.uiLabel3, 3, 0);
            this.uiTimeTableLayoutPanel.Controls.Add(this.uiLabel4, 4, 0);
            this.uiTimeTableLayoutPanel.Controls.Add(this.uiLabel5, 5, 0);
            this.uiTimeTableLayoutPanel.Controls.Add(this.uiLabel6, 6, 0);
            this.uiTimeTableLayoutPanel.Controls.Add(this.uiLabel7, 7, 0);
            this.uiTimeTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTimeTableLayoutPanel.Location = new System.Drawing.Point(0, 47);
            this.uiTimeTableLayoutPanel.Name = "uiTimeTableLayoutPanel";
            this.uiTimeTableLayoutPanel.RowCount = 1;
            this.uiTimeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.uiTimeTableLayoutPanel.Size = new System.Drawing.Size(800, 48);
            this.uiTimeTableLayoutPanel.TabIndex = 3;
            this.uiTimeTableLayoutPanel.TagString = null;
            // 
            // uiLabel1
            // 
            this.uiLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiLabel1.Location = new System.Drawing.Point(66, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(98, 48);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "星期一";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiLabel2.Location = new System.Drawing.Point(170, 0);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(94, 48);
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "星期二";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiLabel3.Location = new System.Drawing.Point(270, 0);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(92, 48);
            this.uiLabel3.TabIndex = 2;
            this.uiLabel3.Text = "星期三";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiLabel4.Location = new System.Drawing.Point(368, 0);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(106, 48);
            this.uiLabel4.TabIndex = 3;
            this.uiLabel4.Text = "星期四";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel5
            // 
            this.uiLabel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiLabel5.Location = new System.Drawing.Point(480, 0);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(88, 48);
            this.uiLabel5.TabIndex = 4;
            this.uiLabel5.Text = "星期五";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel6
            // 
            this.uiLabel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiLabel6.Location = new System.Drawing.Point(574, 0);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(82, 48);
            this.uiLabel6.TabIndex = 5;
            this.uiLabel6.Text = "星期六";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel6.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel7
            // 
            this.uiLabel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiLabel7.Location = new System.Drawing.Point(662, 0);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(135, 48);
            this.uiLabel7.TabIndex = 6;
            this.uiLabel7.Text = "星期天";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel7.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiClassTableLayoutPanel
            // 
            this.uiClassTableLayoutPanel.AutoScroll = true;
            this.uiClassTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.uiClassTableLayoutPanel.ColumnCount = 8;
            this.uiClassTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.001947F));
            this.uiClassTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.14258F));
            this.uiClassTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.14258F));
            this.uiClassTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.14258F));
            this.uiClassTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.14258F));
            this.uiClassTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.14258F));
            this.uiClassTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.14258F));
            this.uiClassTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.14258F));
            this.uiClassTableLayoutPanel.ContextMenuStrip = this.uiSettingContextMenuStrip;
            this.uiClassTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiClassTableLayoutPanel.Location = new System.Drawing.Point(0, 95);
            this.uiClassTableLayoutPanel.Name = "uiClassTableLayoutPanel";
            this.uiClassTableLayoutPanel.RowCount = 1;
            this.uiClassTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.uiClassTableLayoutPanel.Size = new System.Drawing.Size(800, 355);
            this.uiClassTableLayoutPanel.TabIndex = 4;
            this.uiClassTableLayoutPanel.TagString = null;
            // 
            // ClassTableForm
            // 
            this.AllowShowTitle = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiClassTableLayoutPanel);
            this.Controls.Add(this.uiTimeTableLayoutPanel);
            this.Controls.Add(this.titlePanel);
            this.Name = "CourseTableForm";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowTitle = false;
            this.Text = "ClassTableForm";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.titlePanel.ResumeLayout(false);
            this.uiSettingContextMenuStrip.ResumeLayout(false);
            this.uiTimeTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ToolStripMenuItem 设为当前课表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 创建课表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除课表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改课表ToolStripMenuItem;

        private Sunny.UI.UIContextMenuStrip uiSettingContextMenuStrip;

        private Sunny.UI.UILedLabel stateLabel;

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel7;

        private Sunny.UI.UITableLayoutPanel uiClassTableLayoutPanel;

        private Sunny.UI.UITableLayoutPanel uiTimeTableLayoutPanel;

        private Sunny.UI.UILedLabel weekLable;

        private Sunny.UI.UIButton btnNext;

        private Sunny.UI.UIButton btnPre;

        private Sunny.UI.UIPanel titlePanel;

        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridBoolColumn dataGridBoolColumn1;

        #endregion
    }
}