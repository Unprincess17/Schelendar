using System.ComponentModel;

namespace Schelendar
{
    partial class CourseAddForm
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
            this.uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            this.uiLabel2 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.courseNameTB = new Sunny.UI.UITextBox();
            this.teacherNameTB = new Sunny.UI.UITextBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.locationDistrctTB = new Sunny.UI.UITextBox();
            this.locationBuildingTB = new Sunny.UI.UITextBox();
            this.locationRoomTB = new Sunny.UI.UITextBox();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.ensureBtn = new Sunny.UI.UIButton();
            this.uiTableLayoutPanel1.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiTableLayoutPanel1
            // 
            this.uiTableLayoutPanel1.ColumnCount = 2;
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.41139F));
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.58861F));
            this.uiTableLayoutPanel1.Controls.Add(this.uiLabel2, 0, 1);
            this.uiTableLayoutPanel1.Controls.Add(this.uiLabel1, 0, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.courseNameTB, 1, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.teacherNameTB, 1, 4);
            this.uiTableLayoutPanel1.Controls.Add(this.uiLabel3, 0, 4);
            this.uiTableLayoutPanel1.Controls.Add(this.locationDistrctTB, 1, 1);
            this.uiTableLayoutPanel1.Controls.Add(this.locationBuildingTB, 1, 2);
            this.uiTableLayoutPanel1.Controls.Add(this.locationRoomTB, 1, 3);
            this.uiTableLayoutPanel1.Controls.Add(this.uiLabel4, 0, 5);
            this.uiTableLayoutPanel1.Controls.Add(this.uiLabel5, 0, 6);
            this.uiTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTableLayoutPanel1.Location = new System.Drawing.Point(0, 35);
            this.uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            this.uiTableLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.uiTableLayoutPanel1.RowCount = 9;
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.uiTableLayoutPanel1.Size = new System.Drawing.Size(652, 522);
            this.uiTableLayoutPanel1.TabIndex = 0;
            this.uiTableLayoutPanel1.TagString = null;
            // 
            // uiLabel2
            // 
            this.uiLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiLabel2.Location = new System.Drawing.Point(13, 65);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(122, 55);
            this.uiLabel2.TabIndex = 1;
            this.uiLabel2.Text = "上课地点";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiLabel1.Location = new System.Drawing.Point(13, 10);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(122, 55);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "课程名";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // courseNameTB
            // 
            this.courseNameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.courseNameTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.courseNameTB.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.courseNameTB.Location = new System.Drawing.Point(142, 15);
            this.courseNameTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.courseNameTB.MinimumSize = new System.Drawing.Size(1, 16);
            this.courseNameTB.Name = "courseNameTB";
            this.courseNameTB.ShowText = false;
            this.courseNameTB.Size = new System.Drawing.Size(496, 45);
            this.courseNameTB.TabIndex = 3;
            this.courseNameTB.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.courseNameTB.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // teacherNameTB
            // 
            this.teacherNameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.teacherNameTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teacherNameTB.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.teacherNameTB.Location = new System.Drawing.Point(142, 235);
            this.teacherNameTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.teacherNameTB.MinimumSize = new System.Drawing.Size(1, 16);
            this.teacherNameTB.Name = "teacherNameTB";
            this.teacherNameTB.ShowText = false;
            this.teacherNameTB.Size = new System.Drawing.Size(496, 45);
            this.teacherNameTB.TabIndex = 5;
            this.teacherNameTB.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.teacherNameTB.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel3
            // 
            this.uiLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiLabel3.Location = new System.Drawing.Point(13, 230);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(122, 55);
            this.uiLabel3.TabIndex = 2;
            this.uiLabel3.Text = "老师";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // locationDistrctTB
            // 
            this.locationDistrctTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.locationDistrctTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locationDistrctTB.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.locationDistrctTB.Location = new System.Drawing.Point(142, 70);
            this.locationDistrctTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.locationDistrctTB.MinimumSize = new System.Drawing.Size(1, 16);
            this.locationDistrctTB.Name = "locationDistrctTB";
            this.locationDistrctTB.ShowText = false;
            this.locationDistrctTB.Size = new System.Drawing.Size(496, 45);
            this.locationDistrctTB.TabIndex = 4;
            this.locationDistrctTB.Text = "学区";
            this.locationDistrctTB.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.locationDistrctTB.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // locationBuildingTB
            // 
            this.locationBuildingTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.locationBuildingTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locationBuildingTB.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.locationBuildingTB.Location = new System.Drawing.Point(142, 125);
            this.locationBuildingTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.locationBuildingTB.MinimumSize = new System.Drawing.Size(1, 16);
            this.locationBuildingTB.Name = "locationBuildingTB";
            this.locationBuildingTB.ShowText = false;
            this.locationBuildingTB.Size = new System.Drawing.Size(496, 45);
            this.locationBuildingTB.TabIndex = 6;
            this.locationBuildingTB.Text = "教学楼";
            this.locationBuildingTB.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.locationBuildingTB.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // locationRoomTB
            // 
            this.locationRoomTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.locationRoomTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.locationRoomTB.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.locationRoomTB.Location = new System.Drawing.Point(142, 180);
            this.locationRoomTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.locationRoomTB.MinimumSize = new System.Drawing.Size(1, 16);
            this.locationRoomTB.Name = "locationRoomTB";
            this.locationRoomTB.ShowText = false;
            this.locationRoomTB.Size = new System.Drawing.Size(496, 45);
            this.locationRoomTB.TabIndex = 7;
            this.locationRoomTB.Text = "教室";
            this.locationRoomTB.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.locationRoomTB.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel4
            // 
            this.uiLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiLabel4.Location = new System.Drawing.Point(13, 285);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(122, 55);
            this.uiLabel4.TabIndex = 8;
            this.uiLabel4.Text = "上课时间";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiLabel5
            // 
            this.uiLabel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiLabel5.Location = new System.Drawing.Point(13, 340);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(122, 55);
            this.uiLabel5.TabIndex = 9;
            this.uiLabel5.Text = "上课周数";
            this.uiLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.uiLabel5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.ensureBtn);
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiPanel1.Location = new System.Drawing.Point(0, 504);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(652, 53);
            this.uiPanel1.TabIndex = 1;
            this.uiPanel1.Text = "uiPanel1";
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // ensureBtn
            // 
            this.ensureBtn.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ensureBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ensureBtn.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.ensureBtn.Location = new System.Drawing.Point(212, 3);
            this.ensureBtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.ensureBtn.Name = "ensureBtn";
            this.ensureBtn.Size = new System.Drawing.Size(232, 47);
            this.ensureBtn.TabIndex = 0;
            this.ensureBtn.Text = "确定";
            this.ensureBtn.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.ensureBtn.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // CourseAddForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(652, 557);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.uiTableLayoutPanel1);
            this.Name = "CourseAddForm";
            this.Text = "CourseAddForm";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.uiTableLayoutPanel1.ResumeLayout(false);
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private Sunny.UI.UIButton ensureBtn;

        private Sunny.UI.UIPanel uiPanel1;

        private Sunny.UI.UILabel uiLabel5;

        private Sunny.UI.UILabel uiLabel4;

        private Sunny.UI.UITextBox locationBuildingTB;
        private Sunny.UI.UITextBox locationRoomTB;

        private Sunny.UI.UITextBox courseNameTB;
        private Sunny.UI.UITextBox locationDistrctTB;
        private Sunny.UI.UITextBox teacherNameTB;

        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;

        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;

        #endregion
    }
}