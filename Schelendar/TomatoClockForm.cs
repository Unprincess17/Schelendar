using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schelendar
{
    public partial class TomatoClockForm : UIForm
    {
        [DllImport("user32.dll", EntryPoint = "SetForegroundWindow")]
        //设置窗体句柄的窗体为活动窗体，因为如果此程序并不在焦点中，可以使此程序回归活动窗体
        public static extern bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        //释放按钮
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        //向某个窗体发送某种信息


        private int workTime;              //用户设置倒计时的时间
        private int restTime;
        private DateTime startTime;     //保存开始番茄钟的当地时间
        private bool isSave = false;    //是否保存数据
        private bool isRun = false;     //番茄钟是否正在运行

        public TomatoClockForm()
        {
            InitializeComponent();
            lblTomatoNums.Text = 0.ToString();          //获得番茄数初始为0
            btnPause.Hide();
            chkSave.Checked = false;                    //不保存文件
            pcbWorkTime.Maximum = 25;
            pcbRestTime.Maximum = 5;
            iudWorkTime.Value = pcbWorkTime.Value = 25; //工作时间
            iudRestTime.Value = pcbRestTime.Value = 5;  //休息时间         
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            isSave = chkSave.Checked;                            //检查数据是否保存
            startTime = DateTime.Now.ToLocalTime();              //获取当前时间
            
            workTime = Convert.ToInt32(iudWorkTime.Value) * 60;  //工作时间
            restTime = Convert.ToInt32(iudRestTime.Value) * 60;  //休息时间
            
            tmrWorkTime.Enabled = true;                          //开始计时   
            pcbWorkTime.Value = pcbWorkTime.Maximum = workTime;
            pcbRestTime.Value = pcbRestTime.Maximum = restTime;

            pcbWorkTime.Step = pcbRestTime.Step = 1;
            isRun = true;                   //正在运行
            btnStart.Hide();                //隐藏开始按钮
            btnPause.Text = "暂停计时";     //显示暂停按钮
            btnPause.Show();
        }
        private String timeToString(int time)//时间转换成字符串
        {
            int hours = time / 3600;
            int min = (time - 3600 * hours) / 60;
            int second = time % 60;
            return hours.ToString() + ":" + min.ToString() + ":" + second.ToString();
        }
        private void tmrWorkTime_Tick(object sender, EventArgs e)
        {
            if(workTime > 0)
            {
                workTime -= 1;
                lblWorkTime.Text = timeToString(workTime);
                pcbWorkTime.Value = workTime;
            }
            else
            {
                tmrWorkTime.Enabled = false;
                tmrRestTime.Enabled = true;
                saveData();
            }
        }
        private void tmrRestTime_Tick(object sender, EventArgs e)
        {
            if (restTime > 0)
            {
                restTime -= 1;
                lblRestTime.Text = timeToString(restTime);
                pcbRestTime.Value = restTime;
            }
            else
            {
                tmrRestTime.Enabled = false;
                SetForegroundWindow(this.Handle);
                MessageBox.Show("恭喜完成一个番茄钟周期");
                btnStart.Show();
            }
        }

        private void saveData()
        {
            int i = Convert.ToInt32(lblTomatoNums.Text);
            i += 1;
            lblTomatoNums.Text = i.ToString();
            if(isSave)
            {
                string directoryPath = @"C:\TomatoDate";    //定义一个路径变量
                string filePath = "TomatoDate.txt";         //定义一个文件路径变量
                if (!Directory.Exists(directoryPath))       //如果路径不存在
                {
                    Directory.CreateDirectory(directoryPath);//创建一个路径的文件夹
                }
                StreamWriter sw = new StreamWriter(Path.Combine(directoryPath, filePath), true);//打开文件，并设定为追加数据
                sw.WriteLine("开始时间" + startTime.ToString() + "——结束时间" + DateTime.Now.ToLocalTime().ToString() + "专注时间" + iudWorkTime.Value.ToString());
                sw.WriteLine("——————————————————————————————————————————————————————————————");
                sw.Flush();
                sw.Close();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {

            if(btnPause.Text == "暂停计时" && isRun)
            {
                tmrWorkTime.Stop();
                isRun = false;
                btnPause.Text = "恢复计时";
            }
            else if(btnPause.Text == "恢复计时" && !isRun)
            {
                tmrWorkTime.Start();
                isRun = true;
                btnPause.Text = "暂停计时";
            }
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            tmrWorkTime.Enabled = tmrRestTime.Enabled = false;
            btnPause.Text = "暂停计时";
            lblWorkTime.Text = lblRestTime.Text =  "0:0:0";
            workTime = restTime = 0;
            pcbWorkTime.Value = pcbRestTime.Value = 0;
            isRun = false;
            this.Opacity = 1;
            btnStart.Show();
        }


       
    }
}
