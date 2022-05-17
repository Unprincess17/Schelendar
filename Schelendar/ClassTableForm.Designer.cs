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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridBoolColumn1 = new System.Windows.Forms.DataGridBoolColumn();
            this.titlePanel = new Sunny.UI.UIPanel();
            this.weekLable = new Sunny.UI.UILedLabel();
            this.btnNext = new Sunny.UI.UIButton();
            this.btnPre = new Sunny.UI.UIButton();
            this.classTableView = new Sunny.UI.UIDataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Friday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sunday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.classTableView)).BeginInit();
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
            this.titlePanel.Size = new System.Drawing.Size(800, 45);
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
            this.weekLable.Size = new System.Drawing.Size(580, 35);
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
            this.btnNext.Size = new System.Drawing.Size(105, 35);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "下一周";
            this.btnNext.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.btnNext.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnPre
            // 
            this.btnPre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPre.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPre.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.btnPre.Location = new System.Drawing.Point(5, 5);
            this.btnPre.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(105, 35);
            this.btnPre.TabIndex = 0;
            this.btnPre.Text = "前一周";
            this.btnPre.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.btnPre.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // classTableView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (243)))), ((int) (((byte) (249)))), ((int) (((byte) (255)))));
            this.classTableView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.classTableView.BackgroundColor = System.Drawing.Color.FromArgb(((int) (((byte) (243)))), ((int) (((byte) (249)))), ((int) (((byte) (255)))));
            this.classTableView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (80)))), ((int) (((byte) (160)))), ((int) (((byte) (255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (80)))), ((int) (((byte) (160)))), ((int) (((byte) (255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.classTableView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.classTableView.ColumnHeadersHeight = 32;
            this.classTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.classTableView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.Time, this.Monday, this.Tuesday, this.Wednesday, this.Thursday, this.Friday, this.Saturday, this.Sunday});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (48)))), ((int) (((byte) (48)))), ((int) (((byte) (48)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (236)))), ((int) (((byte) (255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (48)))), ((int) (((byte) (48)))), ((int) (((byte) (48)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.classTableView.DefaultCellStyle = dataGridViewCellStyle3;
            this.classTableView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.classTableView.EnableHeadersVisualStyles = false;
            this.classTableView.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.classTableView.GridColor = System.Drawing.Color.FromArgb(((int) (((byte) (104)))), ((int) (((byte) (173)))), ((int) (((byte) (255)))));
            this.classTableView.Location = new System.Drawing.Point(0, 45);
            this.classTableView.Name = "classTableView";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (243)))), ((int) (((byte) (249)))), ((int) (((byte) (255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (48)))), ((int) (((byte) (48)))), ((int) (((byte) (48)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (80)))), ((int) (((byte) (160)))), ((int) (((byte) (255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (48)))), ((int) (((byte) (48)))), ((int) (((byte) (48)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.classTableView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.classTableView.RowHeadersVisible = false;
            this.classTableView.RowHeight = 27;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (48)))), ((int) (((byte) (48)))), ((int) (((byte) (48)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (220)))), ((int) (((byte) (236)))), ((int) (((byte) (255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (48)))), ((int) (((byte) (48)))), ((int) (((byte) (48)))));
            this.classTableView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.classTableView.RowTemplate.Height = 27;
            this.classTableView.SelectedIndex = -1;
            this.classTableView.Size = new System.Drawing.Size(800, 405);
            this.classTableView.TabIndex = 1;
            this.classTableView.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Time.HeaderText = "";
            this.Time.Name = "Time";
            // 
            // Monday
            // 
            this.Monday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Monday.HeaderText = "周一";
            this.Monday.Name = "Monday";
            // 
            // Tuesday
            // 
            this.Tuesday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tuesday.HeaderText = "周二";
            this.Tuesday.Name = "Tuesday";
            // 
            // Wednesday
            // 
            this.Wednesday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Wednesday.HeaderText = "周三";
            this.Wednesday.Name = "Wednesday";
            // 
            // Thursday
            // 
            this.Thursday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Thursday.HeaderText = "周四";
            this.Thursday.Name = "Thursday";
            // 
            // Friday
            // 
            this.Friday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Friday.HeaderText = "周五";
            this.Friday.Name = "Friday";
            // 
            // Saturday
            // 
            this.Saturday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Saturday.HeaderText = "周六";
            this.Saturday.Name = "Saturday";
            // 
            // Sunday
            // 
            this.Sunday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sunday.HeaderText = "周日";
            this.Sunday.Name = "Sunday";
            // 
            // ClassTableForm
            // 
            this.AllowShowTitle = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.classTableView);
            this.Controls.Add(this.titlePanel);
            this.Name = "ClassTableForm";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowTitle = false;
            this.Text = "ClassTableForm";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.titlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.classTableView)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Friday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saturday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sunday;

        private Sunny.UI.UIDataGridView classTableView;

        private Sunny.UI.UILedLabel weekLable;

        private Sunny.UI.UIButton btnNext;

        private Sunny.UI.UIButton btnPre;

        private Sunny.UI.UIPanel titlePanel;

        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridBoolColumn dataGridBoolColumn1;

        #endregion
    }
}