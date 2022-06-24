namespace Schelendar
{
    partial class TomatoClockForm
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
            this.components = new System.ComponentModel.Container();
            this.uiMainPanel = new Sunny.UI.UIPanel();
            this.btnSetting = new Sunny.UI.UIButton();
            this.lblRestTime = new Sunny.UI.UILabel();
            this.lblWorkTime = new Sunny.UI.UILabel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.iudRestTime = new Sunny.UI.UIIntegerUpDown();
            this.iudWorkTime = new Sunny.UI.UIIntegerUpDown();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.chkSave = new Sunny.UI.UICheckBox();
            this.btnAbort = new Sunny.UI.UIButton();
            this.btnPause = new Sunny.UI.UIButton();
            this.btnStart = new Sunny.UI.UIButton();
            this.pcbRestTime = new Sunny.UI.UIProcessBar();
            this.pcbWorkTime = new Sunny.UI.UIProcessBar();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.btnGetExp = new Sunny.UI.UIButton();
            this.lblTomatoNums = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.tmrWorkTime = new System.Windows.Forms.Timer(this.components);
            this.tmrRestTime = new System.Windows.Forms.Timer(this.components);
            this.uiMainPanel.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiMainPanel
            // 
            this.uiMainPanel.Controls.Add(this.btnSetting);
            this.uiMainPanel.Controls.Add(this.lblRestTime);
            this.uiMainPanel.Controls.Add(this.lblWorkTime);
            this.uiMainPanel.Controls.Add(this.uiPanel1);
            this.uiMainPanel.Controls.Add(this.btnAbort);
            this.uiMainPanel.Controls.Add(this.btnPause);
            this.uiMainPanel.Controls.Add(this.btnStart);
            this.uiMainPanel.Controls.Add(this.pcbRestTime);
            this.uiMainPanel.Controls.Add(this.pcbWorkTime);
            this.uiMainPanel.Controls.Add(this.uiLabel3);
            this.uiMainPanel.Controls.Add(this.uiLabel2);
            this.uiMainPanel.Controls.Add(this.btnGetExp);
            this.uiMainPanel.Controls.Add(this.lblTomatoNums);
            this.uiMainPanel.Controls.Add(this.uiLabel1);
            this.uiMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiMainPanel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiMainPanel.Location = new System.Drawing.Point(0, 0);
            this.uiMainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiMainPanel.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiMainPanel.Name = "uiMainPanel";
            this.uiMainPanel.Size = new System.Drawing.Size(800, 450);
            this.uiMainPanel.TabIndex = 0;
            this.uiMainPanel.Text = null;
            this.uiMainPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiMainPanel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnSetting
            // 
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.btnSetting.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.btnSetting.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.btnSetting.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.btnSetting.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.btnSetting.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSetting.Location = new System.Drawing.Point(490, 50);
            this.btnSetting.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.btnSetting.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(175)))), ((int)(((byte)(83)))));
            this.btnSetting.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.btnSetting.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(124)))), ((int)(((byte)(32)))));
            this.btnSetting.Size = new System.Drawing.Size(95, 34);
            this.btnSetting.Style = Sunny.UI.UIStyle.Orange;
            this.btnSetting.StyleCustomMode = true;
            this.btnSetting.TabIndex = 20;
            this.btnSetting.Text = "隐藏设置";
            this.btnSetting.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSetting.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // lblRestTime
            // 
            this.lblRestTime.AutoSize = true;
            this.lblRestTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblRestTime.Location = new System.Drawing.Point(212, 136);
            this.lblRestTime.Name = "lblRestTime";
            this.lblRestTime.Size = new System.Drawing.Size(45, 21);
            this.lblRestTime.TabIndex = 19;
            this.lblRestTime.Text = "0:0:0";
            this.lblRestTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRestTime.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // lblWorkTime
            // 
            this.lblWorkTime.AutoSize = true;
            this.lblWorkTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblWorkTime.Location = new System.Drawing.Point(212, 99);
            this.lblWorkTime.Name = "lblWorkTime";
            this.lblWorkTime.Size = new System.Drawing.Size(45, 21);
            this.lblWorkTime.TabIndex = 18;
            this.lblWorkTime.Text = "0:0:0";
            this.lblWorkTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblWorkTime.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.iudRestTime);
            this.uiPanel1.Controls.Add(this.iudWorkTime);
            this.uiPanel1.Controls.Add(this.uiLabel6);
            this.uiPanel1.Controls.Add(this.uiLabel5);
            this.uiPanel1.Controls.Add(this.uiLabel4);
            this.uiPanel1.Controls.Add(this.chkSave);
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.Location = new System.Drawing.Point(319, 184);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(271, 202);
            this.uiPanel1.TabIndex = 17;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // iudRestTime
            // 
            this.iudRestTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.iudRestTime.HasMinimum = true;
            this.iudRestTime.Location = new System.Drawing.Point(144, 114);
            this.iudRestTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iudRestTime.Minimum = 1;
            this.iudRestTime.MinimumEnabled = true;
            this.iudRestTime.MinimumSize = new System.Drawing.Size(100, 0);
            this.iudRestTime.Name = "iudRestTime";
            this.iudRestTime.ShowText = false;
            this.iudRestTime.Size = new System.Drawing.Size(116, 29);
            this.iudRestTime.TabIndex = 18;
            this.iudRestTime.Text = "uiIntegerUpDown2";
            this.iudRestTime.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.iudRestTime.Value = 5;
            this.iudRestTime.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // iudWorkTime
            // 
            this.iudWorkTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.iudWorkTime.HasMinimum = true;
            this.iudWorkTime.Location = new System.Drawing.Point(144, 73);
            this.iudWorkTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iudWorkTime.Minimum = 1;
            this.iudWorkTime.MinimumEnabled = true;
            this.iudWorkTime.MinimumSize = new System.Drawing.Size(100, 0);
            this.iudWorkTime.Name = "iudWorkTime";
            this.iudWorkTime.ShowText = false;
            this.iudWorkTime.Size = new System.Drawing.Size(116, 29);
            this.iudWorkTime.TabIndex = 17;
            this.iudWorkTime.Text = "uiIntegerUpDown1";
            this.iudWorkTime.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.iudWorkTime.Value = 25;
            this.iudWorkTime.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel6
            // 
            this.uiLabel6.AutoSize = true;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel6.Location = new System.Drawing.Point(27, 9);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(138, 21);
            this.uiLabel6.TabIndex = 16;
            this.uiLabel6.Text = "时间设置（分钟）";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel6.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel5
            // 
            this.uiLabel5.AutoSize = true;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.Location = new System.Drawing.Point(27, 112);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(74, 21);
            this.uiLabel5.TabIndex = 15;
            this.uiLabel5.Text = "休息时间";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel4
            // 
            this.uiLabel4.AutoSize = true;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.Location = new System.Drawing.Point(27, 73);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(74, 21);
            this.uiLabel4.TabIndex = 14;
            this.uiLabel4.Text = "工作时间";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // chkSave
            // 
            this.chkSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkSave.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkSave.Location = new System.Drawing.Point(21, 163);
            this.chkSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.chkSave.Name = "chkSave";
            this.chkSave.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.chkSave.Size = new System.Drawing.Size(199, 36);
            this.chkSave.TabIndex = 7;
            this.chkSave.Text = "数据保存到本地";
            this.chkSave.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnAbort
            // 
            this.btnAbort.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbort.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAbort.Location = new System.Drawing.Point(168, 343);
            this.btnAbort.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Radius = 10;
            this.btnAbort.Size = new System.Drawing.Size(112, 40);
            this.btnAbort.TabIndex = 13;
            this.btnAbort.Text = "放弃本次";
            this.btnAbort.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAbort.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // btnPause
            // 
            this.btnPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPause.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPause.Location = new System.Drawing.Point(168, 257);
            this.btnPause.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPause.Name = "btnPause";
            this.btnPause.Radius = 10;
            this.btnPause.Size = new System.Drawing.Size(112, 40);
            this.btnPause.TabIndex = 12;
            this.btnPause.Text = "暂停计时";
            this.btnPause.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPause.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Location = new System.Drawing.Point(168, 184);
            this.btnStart.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnStart.Name = "btnStart";
            this.btnStart.Radius = 10;
            this.btnStart.Size = new System.Drawing.Size(112, 40);
            this.btnStart.TabIndex = 11;
            this.btnStart.Text = "开始计时";
            this.btnStart.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pcbRestTime
            // 
            this.pcbRestTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pcbRestTime.Location = new System.Drawing.Point(290, 136);
            this.pcbRestTime.MinimumSize = new System.Drawing.Size(70, 3);
            this.pcbRestTime.Name = "pcbRestTime";
            this.pcbRestTime.ShowPercent = false;
            this.pcbRestTime.ShowValue = false;
            this.pcbRestTime.Size = new System.Drawing.Size(300, 31);
            this.pcbRestTime.TabIndex = 6;
            this.pcbRestTime.Text = "uiProcessBar2";
            this.pcbRestTime.Value = 100;
            this.pcbRestTime.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // pcbWorkTime
            // 
            this.pcbWorkTime.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pcbWorkTime.Location = new System.Drawing.Point(290, 99);
            this.pcbWorkTime.Maximum = 25;
            this.pcbWorkTime.MinimumSize = new System.Drawing.Size(70, 3);
            this.pcbWorkTime.Name = "pcbWorkTime";
            this.pcbWorkTime.ShowPercent = false;
            this.pcbWorkTime.ShowValue = false;
            this.pcbWorkTime.Size = new System.Drawing.Size(300, 31);
            this.pcbWorkTime.TabIndex = 5;
            this.pcbWorkTime.Text = "uiProcessBar1";
            this.pcbWorkTime.Value = 25;
            this.pcbWorkTime.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel3
            // 
            this.uiLabel3.AutoSize = true;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.Location = new System.Drawing.Point(100, 136);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(74, 21);
            this.uiLabel3.TabIndex = 4;
            this.uiLabel3.Text = "休息时间";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.AutoSize = true;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel2.Location = new System.Drawing.Point(100, 99);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(74, 21);
            this.uiLabel2.TabIndex = 3;
            this.uiLabel2.Text = "工作时间";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnGetExp
            // 
            this.btnGetExp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetExp.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGetExp.Location = new System.Drawing.Point(382, 50);
            this.btnGetExp.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnGetExp.Name = "btnGetExp";
            this.btnGetExp.Radius = 10;
            this.btnGetExp.Size = new System.Drawing.Size(99, 36);
            this.btnGetExp.TabIndex = 2;
            this.btnGetExp.Text = "获取经验";
            this.btnGetExp.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGetExp.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnGetExp.Click += new System.EventHandler(this.btnGetExp_Click);
            // 
            // lblTomatoNums
            // 
            this.lblTomatoNums.AutoSize = true;
            this.lblTomatoNums.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTomatoNums.Location = new System.Drawing.Point(336, 50);
            this.lblTomatoNums.Name = "lblTomatoNums";
            this.lblTomatoNums.Size = new System.Drawing.Size(19, 21);
            this.lblTomatoNums.TabIndex = 1;
            this.lblTomatoNums.Text = "1";
            this.lblTomatoNums.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTomatoNums.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.AutoSize = true;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.Location = new System.Drawing.Point(100, 50);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(170, 21);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "本次使用获得番茄数：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // tmrWorkTime
            // 
            this.tmrWorkTime.Interval = 1000;
            this.tmrWorkTime.Tick += new System.EventHandler(this.tmrWorkTime_Tick);
            // 
            // tmrRestTime
            // 
            this.tmrRestTime.Interval = 1000;
            this.tmrRestTime.Tick += new System.EventHandler(this.tmrRestTime_Tick);
            // 
            // TomatoClockForm
            // 
            this.AllowShowTitle = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiMainPanel);
            this.Name = "TomatoClockForm";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowTitle = false;
            this.Text = "TomatoClock";
            this.ZoomScaleRect = new System.Drawing.Rectangle(22, 22, 800, 450);
            this.uiMainPanel.ResumeLayout(false);
            this.uiMainPanel.PerformLayout();
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel uiMainPanel;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UIButton btnAbort;
        private Sunny.UI.UIButton btnPause;
        private Sunny.UI.UIButton btnStart;
        private Sunny.UI.UICheckBox chkSave;
        private Sunny.UI.UIProcessBar pcbRestTime;
        private Sunny.UI.UIProcessBar pcbWorkTime;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIButton btnGetExp;
        private Sunny.UI.UILabel lblTomatoNums;
        private Sunny.UI.UILabel uiLabel1;
        private System.Windows.Forms.Timer tmrWorkTime;
        private Sunny.UI.UILabel lblRestTime;
        private Sunny.UI.UILabel lblWorkTime;
        private System.Windows.Forms.Timer tmrRestTime;
        private Sunny.UI.UIIntegerUpDown iudRestTime;
        private Sunny.UI.UIIntegerUpDown iudWorkTime;
        private Sunny.UI.UIButton btnSetting;
    }
}