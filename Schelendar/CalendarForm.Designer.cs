using System.ComponentModel;

namespace Schelendar
{
    partial class CalendarForm
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
            this.uiMainPanel = new Sunny.UI.UIPanel();
            this.templateTable = new Sunny.UI.UITableLayoutPanel();
            this.uiLedLabel1 = new Sunny.UI.UILedLabel();
            this.uiMainPanel.SuspendLayout();
            this.templateTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiMainPanel
            // 
            this.uiMainPanel.Controls.Add(this.templateTable);
            this.uiMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiMainPanel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiMainPanel.Location = new System.Drawing.Point(0, 0);
            this.uiMainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiMainPanel.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiMainPanel.Name = "uiMainPanel";
            this.uiMainPanel.Size = new System.Drawing.Size(800, 450);
            this.uiMainPanel.TabIndex = 0;
            this.uiMainPanel.Text = "日程界面";
            this.uiMainPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiMainPanel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // templateTable
            // 
            this.templateTable.AutoScroll = true;
            this.templateTable.ColumnCount = 3;
            this.templateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.templateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.templateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.templateTable.Controls.Add(this.uiLedLabel1, 0, 0);
            this.templateTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.templateTable.Location = new System.Drawing.Point(0, 0);
            this.templateTable.Name = "templateTable";
            this.templateTable.RowCount = 2;
            this.templateTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.templateTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.templateTable.Size = new System.Drawing.Size(800, 450);
            this.templateTable.TabIndex = 0;
            this.templateTable.TagString = null;
            // 
            // uiLedLabel1
            // 
            this.templateTable.SetColumnSpan(this.uiLedLabel1, 3);
            this.uiLedLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLedLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiLedLabel1.Location = new System.Drawing.Point(3, 3);
            this.uiLedLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLedLabel1.Name = "uiLedLabel1";
            this.uiLedLabel1.Size = new System.Drawing.Size(794, 44);
            this.uiLedLabel1.TabIndex = 0;
            this.uiLedLabel1.Text = "TASKS";
            this.uiLedLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // CalendarForm
            // 
            this.AllowShowTitle = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (243)))), ((int) (((byte) (249)))), ((int) (((byte) (255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiMainPanel);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "CalendarForm";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowTitle = false;
            this.Text = "CalendarForm";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.uiMainPanel.ResumeLayout(false);
            this.templateTable.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private Sunny.UI.UILedLabel uiLedLabel1;

        private Sunny.UI.UITableLayoutPanel templateTable;

        private Sunny.UI.UIPanel uiMainPanel;

        #endregion
    }
}