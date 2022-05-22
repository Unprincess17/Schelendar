using Sunny.UI;
namespace Schelendar
{
    partial class LoginForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_mycancel = new Sunny.UI.UISymbolButton();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.Btn_mycancel);
            this.uiPanel1.Controls.SetChildIndex(this.Btn_mycancel, 0);
            // 
            // lblSubText
            // 
            this.lblSubText.Location = new System.Drawing.Point(376, 421);
            // 
            // Btn_mycancel
            // 
            this.Btn_mycancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_mycancel.FillColor = System.Drawing.Color.DeepSkyBlue;
            this.Btn_mycancel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_mycancel.Location = new System.Drawing.Point(100, 206);
            this.Btn_mycancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.Btn_mycancel.Name = "Btn_mycancel";
            this.Btn_mycancel.Size = new System.Drawing.Size(86, 29);
            this.Btn_mycancel.Style = Sunny.UI.UIStyle.Custom;
            this.Btn_mycancel.Symbol = 61447;
            this.Btn_mycancel.TabIndex = 9;
            this.Btn_mycancel.Text = "注册";
            this.Btn_mycancel.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_mycancel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.Name = "LoginForm";
            this.Text = "Form1";
            this.ZoomScaleRect = new System.Drawing.Rectangle(19, 19, 750, 450);
            this.ButtonLoginClick += new System.EventHandler(this.LoginForm_ButtonLoginClick);
            this.uiPanel1.ResumeLayout(false);
            this.uiPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private UISymbolButton Btn_mycancel;
    }
}

