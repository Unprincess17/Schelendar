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
            this.uiTimePicker1 = new Sunny.UI.UITimePicker();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.uiTimePicker1);
            this.uiPanel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiPanel1.Location = new System.Drawing.Point(5, 40);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(790, 399);
            this.uiPanel1.TabIndex = 0;
            this.uiPanel1.Text = "uiPanel1";
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiPanel1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // uiTimePicker1
            // 
            this.uiTimePicker1.FillColor = System.Drawing.Color.White;
            this.uiTimePicker1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiTimePicker1.Location = new System.Drawing.Point(255, 129);
            this.uiTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiTimePicker1.MaxLength = 8;
            this.uiTimePicker1.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiTimePicker1.Name = "uiTimePicker1";
            this.uiTimePicker1.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiTimePicker1.Size = new System.Drawing.Size(324, 152);
            this.uiTimePicker1.SymbolDropDown = 61555;
            this.uiTimePicker1.SymbolNormal = 61555;
            this.uiTimePicker1.TabIndex = 0;
            this.uiTimePicker1.Text = "22:32:49";
            this.uiTimePicker1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.uiTimePicker1.Value = new System.DateTime(2022, 6, 14, 22, 32, 49, 137);
            this.uiTimePicker1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.uiTimePicker1.ValueChanged += new Sunny.UI.UITimePicker.OnDateTimeChanged(this.uiTimePicker1_ValueChanged);
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
            this.Text = "CourseTemplateForm";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 800, 450);
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private Sunny.UI.UITimePicker uiTimePicker1;

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
    }
}