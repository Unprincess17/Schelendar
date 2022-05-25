﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Schelendar;
namespace Schelendar.FarmClass
{
    public class Seed//种子类
    {
        /// <summary>
        /// 种子id
        /// </summary>
        public int id;

        /// <summary>
        /// 种子名称
        /// </summary>
        public string name;

        /// <summary>
        /// 种子价格
        /// </summary>
        public int price;

        /// <summary>
        /// 成熟时间
        /// </summary>
        public int time;

        /// <summary>
        /// 获取经验
        /// </summary>
        public int exp;//得到的经验

        /// <summary>
        /// 得到金币
        /// </summary>
        public int gold;//得到的金币
        public Seed(int id, string name, int price, int time, int exp, int gold)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.time = time;
            this.exp = exp;
            this.gold = gold;
        }
    }

    public static class Seedlist//种子列表类
    {
        public static Seed[] seeds = new Seed[17];
        public static void initSeeds()//初始化所有种子
        {
            //基础作物
            seeds[1] = new Seed(1, "苹果", 10, 10, 15, 15);
            seeds[2] = new Seed(2, "香梨", 30, 30, 45, 65);
            seeds[3] = new Seed(3, "香蕉", 60, 60, 90, 90);
            seeds[4] = new Seed(4, "芒果", 90, 90, 135, 135);
            //进阶作物（经验）
            seeds[5] = new Seed(5, "李子", 200, 360, 400, 300);
            seeds[6] = new Seed(6, "橘子", 400, 720, 900, 650);
            seeds[7] = new Seed(7, "橙子", 600, 1080, 1400, 1000);
            seeds[8] = new Seed(8, "桃子", 800, 1440, 1900, 1500);
            //进阶作物（经验
            seeds[9] = new Seed(9, "草莓", 200, 360, 300, 400);
            seeds[10] = new Seed(10, "香瓜", 400, 720, 650, 900);
            seeds[11] = new Seed(11, "葡萄", 600, 1080, 1000, 1400);
            seeds[12] = new Seed(12, "椰子", 800, 1440, 1500, 1900);
            //大型作物
            seeds[13] = new Seed(13, "柚子", 1000, 10800, 3000, 4500);
            seeds[14] = new Seed(14, "西瓜", 3000, 18000, 10500, 25000);
            seeds[15] = new Seed(15, "龙眼", 6000, 28800, 24000, 40000);
            seeds[16] = new Seed(16, "荔枝", 10000, 43200, 45000, 55000);
        }
    }
}
