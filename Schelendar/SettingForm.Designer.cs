using System.ComponentModel;

namespace Schelendar
{
    partial class SettingForm
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
            this.SuspendLayout();
            // 
            // uiMainPanel
            // 
            this.uiMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiMainPanel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (134)));
            this.uiMainPanel.Location = new System.Drawing.Point(0, 0);
            this.uiMainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiMainPanel.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiMainPanel.Name = "uiMainPanel";
            this.uiMainPanel.Size = new System.Drawing.Size(800, 450);
            this.uiMainPanel.TabIndex = 0;
            this.uiMainPanel.Text = "设置页面";
            this.uiMainPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiMainPanel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // SettingForm
            // 
            this.AllowShowTitle = false;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiMainPanel);
            this.Name = "SettingForm";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.ShowTitle = false;
            this.Text = "SettingForm";
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 800, 450);
            this.ResumeLayout(false);
        }

        private Sunny.UI.UIPanel uiMainPanel;

        #endregion
    }
}