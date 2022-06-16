namespace Schelendar.CourseForms
{
    partial class CourseTemplateForm
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
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.btnTablePanel = new Sunny.UI.UITableLayoutPanel();
            this.addBtn = new Sunny.UI.UIButton();
            this.preBtn = new Sunny.UI.UIButton();
            this.nextBtn = new Sunny.UI.UIButton();
            this.ensureBtn = new Sunny.UI.UIButton();
            this.templateTablePanel = new Sunny.UI.UITableLayoutPanel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiDatetimePicker1 = new Sunny.UI.UIDatetimePicker();
            this.uiCheckBox1 = new Sunny.UI.UICheckBox();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiDatetimePicker2 = new Sunny.UI.UIDatetimePicker();
            this.uiCheckBox2 = new Sunny.UI.UICheckBox();
            this.uiCheckBox3 = new Sunny.UI.UICheckBox();
            this.uiCheckBox4 = new Sunny.UI.UICheckBox();
            this.uiDatetimePicker3 = new Sunny.UI.UIDatetimePicker();
            this.uiDatetimePicker4 = new Sunny.UI.UIDatetimePicker();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiPanel1.SuspendLayout();
            this.btnTablePanel.SuspendLayout();
            this.templateTablePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.btnTablePanel);
            this.uiPanel1.Controls.Add(this.templateTablePanel);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiPanel1.Location = new System.Drawing.Point(0, 35);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(799, 409);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = "uiPanel1";
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnTablePanel
            // 
            this.btnTablePanel.ColumnCount = 3;
            this.btnTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.btnTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.btnTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.btnTablePanel.Controls.Add(this.addBtn, 0, 0);
            this.btnTablePanel.Controls.Add(this.preBtn, 0, 1);
            this.btnTablePanel.Controls.Add(this.nextBtn, 1, 1);
            this.btnTablePanel.Controls.Add(this.ensureBtn, 2, 1);
            this.btnTablePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTablePanel.Location = new System.Drawing.Point(0, 326);
            this.btnTablePanel.Name = "btnTablePanel";
            this.btnTablePanel.RowCount = 2;
            this.btnTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.btnTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.btnTablePanel.Size = new System.Drawing.Size(799, 83);
            this.btnTablePanel.TabIndex = 1;
            this.btnTablePanel.TagString = null;
            // 
            // addBtn
            // 
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.addBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.addBtn.Location = new System.Drawing.Point(3, 3);
            this.addBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.addBtn.Name = "addBtn";
            this.addBtn.Radius = 1;
            this.addBtn.Size = new System.Drawing.Size(140, 35);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "添加更多事件";
            this.addBtn.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.addBtn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // preBtn
            // 
            this.preBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.preBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.preBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.preBtn.Location = new System.Drawing.Point(3, 44);
            this.preBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.preBtn.Name = "preBtn";
            this.preBtn.Radius = 1;
            this.preBtn.Size = new System.Drawing.Size(140, 36);
            this.preBtn.TabIndex = 1;
            this.preBtn.Text = "上一步";
            this.preBtn.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.preBtn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.preBtn.Click += new System.EventHandler(this.preBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.nextBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.nextBtn.Location = new System.Drawing.Point(495, 44);
            this.nextBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Radius = 1;
            this.nextBtn.Size = new System.Drawing.Size(140, 36);
            this.nextBtn.TabIndex = 2;
            this.nextBtn.Text = "下一步";
            this.nextBtn.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.nextBtn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // ensureBtn
            // 
            this.ensureBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ensureBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ensureBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.ensureBtn.Location = new System.Drawing.Point(656, 44);
            this.ensureBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.ensureBtn.Name = "ensureBtn";
            this.ensureBtn.Radius = 1;
            this.ensureBtn.Size = new System.Drawing.Size(140, 36);
            this.ensureBtn.TabIndex = 3;
            this.ensureBtn.Text = "完成";
            this.ensureBtn.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.ensureBtn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ensureBtn.Click += new System.EventHandler(this.ensureBtn_Click);
            // 
            // templateTablePanel
            // 
            this.templateTablePanel.AutoScroll = true;
            this.templateTablePanel.ColumnCount = 3;
            this.templateTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.templateTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.templateTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.templateTablePanel.Controls.Add(this.uiLabel1, 0, 0);
            this.templateTablePanel.Controls.Add(this.uiLabel2, 1, 0);
            this.templateTablePanel.Controls.Add(this.uiLabel3, 2, 0);
            this.templateTablePanel.Controls.Add(this.uiLabel4, 0, 2);
            this.templateTablePanel.Controls.Add(this.uiDatetimePicker1, 1, 2);
            this.templateTablePanel.Controls.Add(this.uiCheckBox1, 2, 2);
            this.templateTablePanel.Controls.Add(this.uiLabel5, 0, 3);
            this.templateTablePanel.Controls.Add(this.uiDatetimePicker2, 1, 3);
            this.templateTablePanel.Controls.Add(this.uiCheckBox2, 2, 3);
            this.templateTablePanel.Controls.Add(this.uiCheckBox3, 2, 4);
            this.templateTablePanel.Controls.Add(this.uiCheckBox4, 2, 5);
            this.templateTablePanel.Controls.Add(this.uiDatetimePicker3, 1, 4);
            this.templateTablePanel.Controls.Add(this.uiDatetimePicker4, 1, 5);
            this.templateTablePanel.Controls.Add(this.uiLabel6, 0, 4);
            this.templateTablePanel.Controls.Add(this.uiLabel7, 0, 5);
            this.templateTablePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.templateTablePanel.Location = new System.Drawing.Point(0, 0);
            this.templateTablePanel.Name = "templateTablePanel";
            this.templateTablePanel.RowCount = 7;
            this.templateTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.templateTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.templateTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.templateTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.templateTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.templateTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.templateTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.templateTablePanel.Size = new System.Drawing.Size(799, 320);
            this.templateTablePanel.TabIndex = 0;
            this.templateTablePanel.TagString = null;
            // 
            // uiLabel1
            // 
            this.uiLabel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (192)))));
            this.uiLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiLabel1.Location = new System.Drawing.Point(3, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(193, 30);
            this.uiLabel1.StyleCustomMode = true;
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "事件名";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel2
            // 
            this.uiLabel2.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (192)))));
            this.uiLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiLabel2.Location = new System.Drawing.Point(202, 0);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(393, 30);
            this.uiLabel2.StyleCustomMode = true;
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "时间";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel3
            // 
            this.uiLabel3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (192)))));
            this.uiLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiLabel3.Location = new System.Drawing.Point(601, 0);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(195, 30);
            this.uiLabel3.StyleCustomMode = true;
            this.uiLabel3.TabIndex = 2;
            this.uiLabel3.Text = "是否启用";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiLabel4.Location = new System.Drawing.Point(3, 40);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(193, 40);
            this.uiLabel4.TabIndex = 3;
            this.uiLabel4.Text = "作业";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiDatetimePicker1
            // 
            this.uiDatetimePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiDatetimePicker1.FillColor = System.Drawing.Color.White;
            this.uiDatetimePicker1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiDatetimePicker1.Location = new System.Drawing.Point(203, 45);
            this.uiDatetimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDatetimePicker1.MaxLength = 19;
            this.uiDatetimePicker1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiDatetimePicker1.Name = "uiDatetimePicker1";
            this.uiDatetimePicker1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiDatetimePicker1.Size = new System.Drawing.Size(391, 30);
            this.uiDatetimePicker1.SymbolDropDown = 61555;
            this.uiDatetimePicker1.SymbolNormal = 61555;
            this.uiDatetimePicker1.TabIndex = 4;
            this.uiDatetimePicker1.Text = "2022-06-16 22:43:02";
            this.uiDatetimePicker1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiDatetimePicker1.Value = new System.DateTime(2022, 6, 16, 22, 43, 2, 89);
            this.uiDatetimePicker1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiCheckBox1
            // 
            this.uiCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiCheckBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiCheckBox1.Location = new System.Drawing.Point(601, 43);
            this.uiCheckBox1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox1.Name = "uiCheckBox1";
            this.uiCheckBox1.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox1.Size = new System.Drawing.Size(195, 34);
            this.uiCheckBox1.TabIndex = 5;
            this.uiCheckBox1.Text = "添加";
            this.uiCheckBox1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel5
            // 
            this.uiLabel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiLabel5.Location = new System.Drawing.Point(3, 80);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(193, 40);
            this.uiLabel5.TabIndex = 6;
            this.uiLabel5.Text = "大作业";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiDatetimePicker2
            // 
            this.uiDatetimePicker2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiDatetimePicker2.FillColor = System.Drawing.Color.White;
            this.uiDatetimePicker2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiDatetimePicker2.Location = new System.Drawing.Point(203, 85);
            this.uiDatetimePicker2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDatetimePicker2.MaxLength = 19;
            this.uiDatetimePicker2.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiDatetimePicker2.Name = "uiDatetimePicker2";
            this.uiDatetimePicker2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiDatetimePicker2.Size = new System.Drawing.Size(391, 30);
            this.uiDatetimePicker2.SymbolDropDown = 61555;
            this.uiDatetimePicker2.SymbolNormal = 61555;
            this.uiDatetimePicker2.TabIndex = 7;
            this.uiDatetimePicker2.Text = "2022-06-16 22:52:48";
            this.uiDatetimePicker2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiDatetimePicker2.Value = new System.DateTime(2022, 6, 16, 22, 52, 48, 731);
            this.uiDatetimePicker2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiCheckBox2
            // 
            this.uiCheckBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiCheckBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiCheckBox2.Location = new System.Drawing.Point(601, 83);
            this.uiCheckBox2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox2.Name = "uiCheckBox2";
            this.uiCheckBox2.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox2.Size = new System.Drawing.Size(195, 34);
            this.uiCheckBox2.TabIndex = 8;
            this.uiCheckBox2.Text = "添加";
            this.uiCheckBox2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiCheckBox3
            // 
            this.uiCheckBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiCheckBox3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiCheckBox3.Location = new System.Drawing.Point(601, 123);
            this.uiCheckBox3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox3.Name = "uiCheckBox3";
            this.uiCheckBox3.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox3.Size = new System.Drawing.Size(195, 34);
            this.uiCheckBox3.TabIndex = 9;
            this.uiCheckBox3.Text = "添加";
            this.uiCheckBox3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiCheckBox4
            // 
            this.uiCheckBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiCheckBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiCheckBox4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiCheckBox4.Location = new System.Drawing.Point(601, 163);
            this.uiCheckBox4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiCheckBox4.Name = "uiCheckBox4";
            this.uiCheckBox4.Padding = new System.Windows.Forms.Padding(22, 0, 0, 0);
            this.uiCheckBox4.Size = new System.Drawing.Size(195, 34);
            this.uiCheckBox4.TabIndex = 10;
            this.uiCheckBox4.Text = "添加";
            this.uiCheckBox4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiDatetimePicker3
            // 
            this.uiDatetimePicker3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiDatetimePicker3.FillColor = System.Drawing.Color.White;
            this.uiDatetimePicker3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiDatetimePicker3.Location = new System.Drawing.Point(203, 125);
            this.uiDatetimePicker3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDatetimePicker3.MaxLength = 19;
            this.uiDatetimePicker3.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiDatetimePicker3.Name = "uiDatetimePicker3";
            this.uiDatetimePicker3.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiDatetimePicker3.Size = new System.Drawing.Size(391, 30);
            this.uiDatetimePicker3.SymbolDropDown = 61555;
            this.uiDatetimePicker3.SymbolNormal = 61555;
            this.uiDatetimePicker3.TabIndex = 12;
            this.uiDatetimePicker3.Text = "2022-06-16 22:56:51";
            this.uiDatetimePicker3.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiDatetimePicker3.Value = new System.DateTime(2022, 6, 16, 22, 56, 51, 484);
            this.uiDatetimePicker3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiDatetimePicker4
            // 
            this.uiDatetimePicker4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiDatetimePicker4.FillColor = System.Drawing.Color.White;
            this.uiDatetimePicker4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiDatetimePicker4.Location = new System.Drawing.Point(203, 165);
            this.uiDatetimePicker4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiDatetimePicker4.MaxLength = 19;
            this.uiDatetimePicker4.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiDatetimePicker4.Name = "uiDatetimePicker4";
            this.uiDatetimePicker4.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiDatetimePicker4.Size = new System.Drawing.Size(391, 30);
            this.uiDatetimePicker4.SymbolDropDown = 61555;
            this.uiDatetimePicker4.SymbolNormal = 61555;
            this.uiDatetimePicker4.TabIndex = 13;
            this.uiDatetimePicker4.Text = "2022-06-16 22:56:56";
            this.uiDatetimePicker4.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiDatetimePicker4.Value = new System.DateTime(2022, 6, 16, 22, 56, 56, 233);
            this.uiDatetimePicker4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel6
            // 
            this.uiLabel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiLabel6.Location = new System.Drawing.Point(3, 120);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(193, 40);
            this.uiLabel6.TabIndex = 15;
            this.uiLabel6.Text = "期中考试";
            this.uiLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel6.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel7
            // 
            this.uiLabel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiLabel7.Location = new System.Drawing.Point(3, 160);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(193, 40);
            this.uiLabel7.TabIndex = 16;
            this.uiLabel7.Text = "期末考试";
            this.uiLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel7.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // CourseTemplateForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (243)))), ((int) (((byte) (249)))), ((int) (((byte) (255)))));
            this.ClientSize = new System.Drawing.Size(799, 444);
            this.Controls.Add(this.uiPanel1);
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CourseTemplateForm";
            this.Text = "添加事件";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 800, 450);
            this.uiPanel1.ResumeLayout(false);
            this.btnTablePanel.ResumeLayout(false);
            this.templateTablePanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private Sunny.UI.UIButton ensureBtn;

        private Sunny.UI.UIButton addBtn;
        private Sunny.UI.UIButton preBtn;
        private Sunny.UI.UIButton nextBtn;

        private Sunny.UI.UIDatetimePicker uiDatetimePicker3;
        private Sunny.UI.UIDatetimePicker uiDatetimePicker4;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel7;

        private Sunny.UI.UICheckBox uiCheckBox3;
        private Sunny.UI.UICheckBox uiCheckBox4;

        private Sunny.UI.UICheckBox uiCheckBox2;

        private Sunny.UI.UIDatetimePicker uiDatetimePicker2;

        private Sunny.UI.UILabel uiLabel5;

        private Sunny.UI.UICheckBox uiCheckBox1;

        private Sunny.UI.UIDatetimePicker uiDatetimePicker1;

        private Sunny.UI.UILabel uiLabel4;

        private Sunny.UI.UILabel uiLabel3;

        private Sunny.UI.UILabel uiLabel2;

        private Sunny.UI.UILabel uiLabel1;

        private Sunny.UI.UITableLayoutPanel templateTablePanel;

        private Sunny.UI.UITableLayoutPanel btnTablePanel;

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
    }
}