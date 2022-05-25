﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;
using Schelendar.FarmClass;
namespace Schelendar
{
    public partial class FarmForm : UIForm
    {
        public PictureBox[] groundList = new PictureBox[13];
        public PictureBox[] seedPicList = new PictureBox[17];//种子图片表

        private int selectedSeed = 0;   //0表示未选择，1-16表示16种种子
        private int selectedGround = 0; //0表示未选择，1-12表示16块土地
        private int openGround = 0;     //已解锁土地数目
        private int restGround = 0;     //当前空闲土地
        private int[] openCost = new int[13] { 0, 0, 100, 300, 1000, 3000, 10000, 30000, 100000, 200000, 300000, 500000, 0 };//解锁土地消费
        private bool kill = false;      //铲除模式
        private bool plant = false;     //种植模式
        public FarmForm()
        {
            DBHelper dBHelper = new DBHelper();
            dBHelper.create();
            //PlayerManager.initnewplayer("test");
            PlayerManager.readdata("test");
            InitializeComponent();      //初始化组件
            initGroundList();           //初始化图片列表，便于管理
            initSeedPicList();          //初始化种子图片表，便于管理
            Seedlist.initSeeds();       //初始化种子数据

            ///初始化显示界面
            lblUsername.Text = PlayerManager.username;
            lblLevel.Text = PlayerManager.lv.ToString();
            pcbExp.Maximum = PlayerManager.expmax;
            pcbExp.Value = PlayerManager.expnow;
            lblMoney.Text = PlayerManager.gold.ToString();
            for(int i = 1; i < 13; i++)     //是否解锁土地
            {
                setGroundPic(i, (PlayerManager.unlocked[i] == 1) ? 0 : -1);
                if (PlayerManager.unlocked[i] == 1)
                    openGround++;
            }
            restGround = openGround;
            for(int i = 1; i < 13; i++)     //是否种植植物
            {
                if(PlayerManager.planted[i] > 0)
                {
                    setGroundPic(i, 17);
                    restGround--;
                }
            }
            for(int i = 1; i < 13; i++)     //作物是否成熟
            {
                if(PlayerManager.unlocked[i] == 1 && PlayerManager.planted[i] > 0)
                {
                    if(isRipe(i))
                    {
                        lblLeftRipenTime.Text = "可收割";
                        setGroundPic(i, PlayerManager.planted[i]);
                    }
                }
            }
        }
        /// <summary>
        /// 判断作物是否成熟，i为土地号
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        private bool isRipe(int i)
        {
            return PlayerManager.timestart[i] + Seedlist.seeds[PlayerManager.planted[i]].time - calcTime() < 0;
        }
        /// <summary>
        /// 计算当前时间距离1970年1月1日的秒数, 种子种植时间以这个作为基准，方便计算
        /// </summary>
        /// <returns></returns>
        private int calcTime()
        {
            TimeSpan timeSpan = (DateTime.UtcNow - new DateTime(1970, 1, 1));
            return (int)timeSpan.TotalSeconds;
        }

        private void initSeedPicList()
        {
            seedPicList[1] = pictureBox1;
            seedPicList[2] = pictureBox2;
            seedPicList[3] = pictureBox3;
            seedPicList[4] = pictureBox4;
            seedPicList[5] = pictureBox5;
            seedPicList[6] = pictureBox6;
            seedPicList[7] = pictureBox7;
            seedPicList[8] = pictureBox8;
            seedPicList[9] = pictureBox9;
            seedPicList[10] = pictureBox10;
            seedPicList[11] = pictureBox11;
            seedPicList[12] = pictureBox12;
            seedPicList[13] = pictureBox13;
            seedPicList[14] = pictureBox14;
            seedPicList[15] = pictureBox15;
            seedPicList[16] = pictureBox16;
        }

        private void initGroundList()
        {
            groundList[1] = pictureBox17;
            groundList[2] = pictureBox18;
            groundList[3] = pictureBox19;
            groundList[4] = pictureBox20;
            groundList[5] = pictureBox21;
            groundList[6] = pictureBox22;
            groundList[7] = pictureBox23;
            groundList[8] = pictureBox24;
            groundList[9] = pictureBox25;
            groundList[10] = pictureBox26;
            groundList[11] = pictureBox27;
            groundList[12] = pictureBox28;
        }
        #region 种子选择
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            selectSeed(1);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            selectSeed(2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            selectSeed(3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            selectSeed(4);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            selectSeed(5);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            selectSeed(6);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            selectSeed(7);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            selectSeed(8);
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            selectSeed(9);

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            selectSeed(10);

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            selectSeed(11);

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            selectSeed(12);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            selectSeed(13);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            selectSeed(14);

        }
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            selectSeed(15);

        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            selectSeed(16);

        }
        #endregion
        private void selectSeed(int i)
        {
            kill = false;//不铲除
            selectedSeed = i;
            lblSeedName.Text = Seedlist.seeds[i].name;
            lblSeedNum.Text = PlayerManager.seeds[i].ToString();
            plant = PlayerManager.seeds[i] > 0 ? true : false;//选择种子余量大于0，可以种植
            if (plant)
            {
                this.Cursor = Cursors.Hand;
            }
            else
            {
                this.Cursor = Cursors.Default;

            }
        }

        /// <summary>
        /// 购买按钮的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuy_Click(object sender, EventArgs e)
        {
            if(selectedSeed == 0)
            {
                MessageBox.Show("请先选择种子噢～");
                return;
            }
            int id = selectedSeed;
            if(PlayerManager.gold > Seedlist.seeds[id].price)
            {
                PlayerManager.gold -= Seedlist.seeds[id].price;
                lblMoney.Text = PlayerManager.gold.ToString();
                PlayerManager.seeds[id] += 1;
                lblSeedNum.Text = PlayerManager.seeds[id].ToString();
                PlayerManager.savedata();
            }
            else
            {
                MessageBox.Show("金币不足，试试其他种子噢～");
            }
        }

        /// <summary>
        /// 取消选中按钮的点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelSelected_Click(object sender, EventArgs e)
        {
            selectedSeed = 0;
            lblSeedName.Text = "无";
            lblSeedNum.Text = "0";
            if(plant)
            {
                plant = false;
                this.Cursor = Cursors.Default;
            }
        }

        /// <summary>
        /// 设置土地的图片：未种植？幼苗？成熟？
        /// </summary>
        /// <param name="grnid"></param>
        /// <param name="picid"></param>
        public void setGroundPic(int grnid, int picid)
        {
            if (picid == -1)//未解锁
            {
                groundList[grnid].BackgroundImage = Properties.Resources.font_small_lock;
            }
            else if (picid == 0)//已解锁，未种植
            {
                groundList[grnid].BackgroundImage = Properties.Resources.land;
            }
            else//反射机制得到图片
            {
                groundList[grnid].BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(picid.ToString(), Properties.Resources.Culture);
            }
        }


        private void btnOpen_Click(object sender, EventArgs e)
        {
            if(openGround >= 12)
            {
                MessageBox.Show("你已经解锁了所有土地！");
                return;
            }
            MessageBox.Show($"解锁第{openGround + 1}块土地要{openCost[openGround]}元噢");
            if(PlayerManager.gold < openCost[openGround])
            {
                MessageBox.Show("金币不足，无法开辟土地");
                return;
            }
            MessageBox.Show("恭喜解锁新土地");
            PlayerManager.gold -= openCost[openGround]; //金币更新
            lblMoney.Text = PlayerManager.gold.ToString();
            PlayerManager.unlocked[openGround + 1] = 1;//解锁土地增加
            setGroundPic(openGround + 1, 0);            //更新土地图片
            PlayerManager.planted[openGround + 1] = 0;  //未种植
            openGround++;
            restGround++;
            PlayerManager.savedata();
        }

        private void btnWeed_Click(object sender, EventArgs e)
        {
            kill = true;
            plant = false;
            this.Cursor = Cursors.No;
        }

        private void btnCancelWeed_Click(object sender, EventArgs e)
        {
            if (kill)
            {
                kill = false;
                this.Cursor = Cursors.Default;
            }
        }
        #region 选择土地
        private void pictureBox17_Click(object sender, EventArgs e)
        {
            selectGround(1);
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            selectGround(2);
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            selectGround(3);
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            selectGround(4);
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            selectGround(5);
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            selectGround(6);
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            selectGround(7);
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            selectGround(8);
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            selectGround(9);
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            selectGround(10);
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            selectGround(11);
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            selectGround(12);
        }
        #endregion
        private void selectGround(int i)
        {
            if (PlayerManager.unlocked[i] == 0)
                return;
            if(PlayerManager.planted[i] > 0 && isRipe(i))
            {
                kill = false;
                plant = false;
                this.Cursor = Cursors.Default;
                PlayerManager.gold += Seedlist.seeds[PlayerManager.planted[i]].gold;
                PlayerManager.getexp(Seedlist.seeds[PlayerManager.planted[i]].exp);
                lblMoney.Text = PlayerManager.gold.ToString();
                pcbExp.Maximum = PlayerManager.expmax;
                pcbExp.Value = PlayerManager.expnow;
                lblLevel.Text = PlayerManager.lv.ToString();
                PlayerManager.planted[i] = 0;
                PlayerManager.timestart[i] = 0;
                restGround++;
                setGroundPic(i, 0);
                selectedGround = 0;
                lblLeftRipenTime.Text = "0";
                pcbLeftRipenTime.Value = 0;
                PlayerManager.savedata();
                return;
            }
            if(plant)
            {
                if (PlayerManager.planted[i] > 0)
                    return;
                if (PlayerManager.seeds[selectedSeed] >= 1)
                {
                    PlayerManager.seeds[selectedSeed]--;
                    lblSeedNum.Text = PlayerManager.seeds[selectedSeed].ToString();
                    PlayerManager.planted[i] = selectedSeed;
                    PlayerManager.timestart[i] = calcTime();
                    selectedGround = i;
                    lblLeftRipenTime.Text = Seedlist.seeds[selectedSeed].time.ToString();
                    pcbLeftRipenTime.Maximum = Seedlist.seeds[selectedSeed].time;
                    pcbLeftRipenTime.Value = pcbLeftRipenTime.Maximum;
                    setGroundPic(i, 17);
                    PlayerManager.savedata();
                    restGround--;
                    if (restGround == 0)
                    {
                        selectedSeed = 0;
                        lblSeedName.Text = "无";
                        lblSeedNum.Text = "0";
                        plant = false;
                        this.Cursor = Cursors.Default;
                    }
                    return;
                }
                else
                {
                    MessageBox.Show("种子不够啦，换别的种子试试吧！");
                    selectedSeed = 0;
                    lblSeedName.Text = "无";
                    lblSeedNum.Text = "0";
                    plant = false;
                    this.Cursor = Cursors.Default;
                    return;
                }
            }
            if(kill)
            {
                if (PlayerManager.planted[i] > 0)
                {
                    PlayerManager.planted[i] = 0;
                    PlayerManager.timestart[i] = 0;
                    setGroundPic(i, 0);
                    selectedGround = 0;
                    lblLeftRipenTime.Text = "0";
                    pcbLeftRipenTime.Value = 0;
                    PlayerManager.savedata();
                    restGround++;
                    return;
                }
                else
                    return;
            }
            if (PlayerManager.planted[i] > 0)
            {
                selectedGround = i;
                lblLeftRipenTime.Text = (PlayerManager.timestart[i] + Seedlist.seeds[PlayerManager.planted[i]].time - calcTime()).ToString();
                pcbLeftRipenTime.Maximum = Seedlist.seeds[PlayerManager.planted[i]].time;
                pcbLeftRipenTime.Value = lblLeftRipenTime.Text.ToInt();
                return;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 1; i <= 12; i++)
            {
                if (PlayerManager.unlocked[i] == 1)//某块地已经解锁
                {
                    if (PlayerManager.planted[i] > 0)//某块地已经种植
                    {
                        if (isRipe(i))//成熟
                        {
                            setGroundPic(i, PlayerManager.planted[i]);
                        }
                    }
                }
            }
            if(selectedGround != 0)
            {
                if (!isRipe(selectedGround))//没有成熟
                {
                    if (lblLeftRipenTime.Text == "可收割")
                        return;
                    lblLeftRipenTime.Text = (Convert.ToInt32(lblLeftRipenTime.Text) - 1).ToString();
                    pcbLeftRipenTime.Value = lblLeftRipenTime.Text.ToInt();
                    if (Convert.ToInt32(lblLeftRipenTime.Text) <= 0)
                        lblLeftRipenTime.Text = "可收割";
                }
            }
        }
    }
}
