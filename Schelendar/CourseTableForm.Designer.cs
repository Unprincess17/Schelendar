using System.ComponentModel;

namespace Schelendar
{
    partial class ClassTableForm
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
            this.weekLable = new Sunny.UI.UILedLabel();
            this.btnNext = new Sunny.UI.UIButton();
            this.btnPre = new Sunny.UI.UIButton();
            this.uiTimeTableLayoutPanel = new Sunny.UI.UITableLayoutPanel();
            this.uiTextBoxMonday = new Sunny.UI.UITextBox();
            this.uiTextBoxTuesday = new Sunny.UI.UITextBox();
            this.uiTextBoxWednesday = new Sunny.UI.UITextBox();
            this.uiTextBoxThursday = new Sunny.UI.UITextBox();
            this.uiTextBoxFriday = new Sunny.UI.UITextBox();
            this.uiTextBoxSaturday = new Sunny.UI.UITextBox();
            this.uiTextBoxSunday = new Sunny.UI.UITextBox();
            this.uiClassTableLayoutPanel = new Sunny.UI.UITableLayoutPanel();
            this.titlePanel.SuspendLayout();
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
            // weekLable
            // 
            this.weekLable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.weekLable.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.weekLable.Location = new System.Drawing.Point(110, 5);
            this.weekLable.MinimumSize = new System.Drawing.Size(1, 1);
            this.weekLable.Name = "weekLable";
            this.weekLable.Size = new System.Drawing.Size(580, 37);
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
            // uiTimeTableLayoutPanel
            // 
            this.uiTimeTableLayoutPanel.AutoScroll = true;
            this.uiTimeTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.uiTimeTableLayoutPanel.ColumnCount = 8;
            this.uiTimeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.027093F));
            this.uiTimeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.13899F));
            this.uiTimeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.13899F));
            this.uiTimeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.13899F));
            this.uiTimeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.13899F));
            this.uiTimeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.13899F));
            this.uiTimeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.13899F));
            this.uiTimeTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.13899F));
            this.uiTimeTableLayoutPanel.Controls.Add(this.uiTextBoxMonday, 1, 0);
            this.uiTimeTableLayoutPanel.Controls.Add(this.uiTextBoxTuesday, 2, 0);
            this.uiTimeTableLayoutPanel.Controls.Add(this.uiTextBoxWednesday, 3, 0);
            this.uiTimeTableLayoutPanel.Controls.Add(this.uiTextBoxThursday, 4, 0);
            this.uiTimeTableLayoutPanel.Controls.Add(this.uiTextBoxFriday, 5, 0);
            this.uiTimeTableLayoutPanel.Controls.Add(this.uiTextBoxSaturday, 6, 0);
            this.uiTimeTableLayoutPanel.Controls.Add(this.uiTextBoxSunday, 7, 0);
            this.uiTimeTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTimeTableLayoutPanel.Location = new System.Drawing.Point(0, 47);
            this.uiTimeTableLayoutPanel.Name = "uiTimeTableLayoutPanel";
            this.uiTimeTableLayoutPanel.RowCount = 1;
            this.uiTimeTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.uiTimeTableLayoutPanel.Size = new System.Drawing.Size(800, 48);
            this.uiTimeTableLayoutPanel.TabIndex = 3;
            this.uiTimeTableLayoutPanel.TagString = null;
            // 
            // uiTextBoxMonday
            // 
            this.uiTextBoxMonday.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (80)))), ((int) (((byte) (160)))), ((int) (((byte) (255)))));
            this.uiTextBoxMonday.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBoxMonday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTextBoxMonday.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiTextBoxMonday.Location = new System.Drawing.Point(69, 6);
            this.uiTextBoxMonday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBoxMonday.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBoxMonday.Name = "uiTextBoxMonday";
            this.uiTextBoxMonday.ReadOnly = true;
            this.uiTextBoxMonday.ShowText = false;
            this.uiTextBoxMonday.Size = new System.Drawing.Size(95, 36);
            this.uiTextBoxMonday.TabIndex = 0;
            this.uiTextBoxMonday.Text = "星期一";
            this.uiTextBoxMonday.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiTextBoxMonday.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTextBoxTuesday
            // 
            this.uiTextBoxTuesday.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBoxTuesday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTextBoxTuesday.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiTextBoxTuesday.Location = new System.Drawing.Point(173, 6);
            this.uiTextBoxTuesday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBoxTuesday.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBoxTuesday.Name = "uiTextBoxTuesday";
            this.uiTextBoxTuesday.ReadOnly = true;
            this.uiTextBoxTuesday.ShowText = false;
            this.uiTextBoxTuesday.Size = new System.Drawing.Size(95, 36);
            this.uiTextBoxTuesday.TabIndex = 1;
            this.uiTextBoxTuesday.Text = "星期二";
            this.uiTextBoxTuesday.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiTextBoxTuesday.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTextBoxWednesday
            // 
            this.uiTextBoxWednesday.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBoxWednesday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTextBoxWednesday.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiTextBoxWednesday.Location = new System.Drawing.Point(277, 6);
            this.uiTextBoxWednesday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBoxWednesday.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBoxWednesday.Name = "uiTextBoxWednesday";
            this.uiTextBoxWednesday.ReadOnly = true;
            this.uiTextBoxWednesday.ShowText = false;
            this.uiTextBoxWednesday.Size = new System.Drawing.Size(95, 36);
            this.uiTextBoxWednesday.TabIndex = 2;
            this.uiTextBoxWednesday.Text = "星期三";
            this.uiTextBoxWednesday.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiTextBoxWednesday.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTextBoxThursday
            // 
            this.uiTextBoxThursday.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBoxThursday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTextBoxThursday.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiTextBoxThursday.Location = new System.Drawing.Point(381, 6);
            this.uiTextBoxThursday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBoxThursday.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBoxThursday.Name = "uiTextBoxThursday";
            this.uiTextBoxThursday.ReadOnly = true;
            this.uiTextBoxThursday.ShowText = false;
            this.uiTextBoxThursday.Size = new System.Drawing.Size(95, 36);
            this.uiTextBoxThursday.TabIndex = 3;
            this.uiTextBoxThursday.Text = "星期四";
            this.uiTextBoxThursday.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiTextBoxThursday.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTextBoxFriday
            // 
            this.uiTextBoxFriday.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBoxFriday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTextBoxFriday.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiTextBoxFriday.Location = new System.Drawing.Point(485, 6);
            this.uiTextBoxFriday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBoxFriday.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBoxFriday.Name = "uiTextBoxFriday";
            this.uiTextBoxFriday.ReadOnly = true;
            this.uiTextBoxFriday.ShowText = false;
            this.uiTextBoxFriday.Size = new System.Drawing.Size(95, 36);
            this.uiTextBoxFriday.TabIndex = 4;
            this.uiTextBoxFriday.Text = "星期五";
            this.uiTextBoxFriday.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiTextBoxFriday.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTextBoxSaturday
            // 
            this.uiTextBoxSaturday.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBoxSaturday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTextBoxSaturday.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiTextBoxSaturday.Location = new System.Drawing.Point(589, 6);
            this.uiTextBoxSaturday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBoxSaturday.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBoxSaturday.Name = "uiTextBoxSaturday";
            this.uiTextBoxSaturday.ReadOnly = true;
            this.uiTextBoxSaturday.ShowText = false;
            this.uiTextBoxSaturday.Size = new System.Drawing.Size(95, 36);
            this.uiTextBoxSaturday.TabIndex = 5;
            this.uiTextBoxSaturday.Text = "星期六";
            this.uiTextBoxSaturday.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiTextBoxSaturday.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTextBoxSunday
            // 
            this.uiTextBoxSunday.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.uiTextBoxSunday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTextBoxSunday.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiTextBoxSunday.Location = new System.Drawing.Point(693, 6);
            this.uiTextBoxSunday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTextBoxSunday.MinimumSize = new System.Drawing.Size(1, 16);
            this.uiTextBoxSunday.Name = "uiTextBoxSunday";
            this.uiTextBoxSunday.ReadOnly = true;
            this.uiTextBoxSunday.ShowText = false;
            this.uiTextBoxSunday.Size = new System.Drawing.Size(102, 36);
            this.uiTextBoxSunday.TabIndex = 6;
            this.uiTextBoxSunday.Text = "星期天";
            this.uiTextBoxSunday.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiTextBoxSunday.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
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
            this.Name = "ClassTableForm";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowTitle = false;
            this.Text = "ClassTableForm";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.titlePanel.ResumeLayout(false);
            this.uiTimeTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private Sunny.UI.UITableLayoutPanel uiClassTableLayoutPanel;

        private Sunny.UI.UITextBox uiTextBoxTuesday;
        private Sunny.UI.UITextBox uiTextBoxWednesday;
        private Sunny.UI.UITextBox uiTextBoxThursday;
        private Sunny.UI.UITextBox uiTextBoxFriday;
        private Sunny.UI.UITextBox uiTextBoxSaturday;
        private Sunny.UI.UITextBox uiTextBoxSunday;

        private Sunny.UI.UITextBox uiTextBoxMonday;

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