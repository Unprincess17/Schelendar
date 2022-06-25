using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Schelendar;
namespace Schelendar.Models
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

            seeds[1] = new Seed(1, "晚香玉", 10, 10, 10, 12);
            seeds[2] = new Seed(2, "六月雪", 30, 2700, 18, 52);
            seeds[3] = new Seed(3, "含笑花", 60, 3600, 36, 72);
            seeds[4] = new Seed(4, "宝华玉兰", 90, 7200, 60, 108);


            seeds[5] = new Seed(5, "冰凌花", 200, 8000, 72, 240);
            seeds[6] = new Seed(6, "天堂鸟", 400, 12000, 80, 500);
            seeds[7] = new Seed(7, "依米花", 600, 16000, 95, 750);
            seeds[8] = new Seed(8, "万圣南瓜", 800, 20000, 100, 1000);


            seeds[9] = new Seed(9, "西游仙桃", 200, 10000, 120, 320);
            seeds[10] = new Seed(10, "音速星语", 400, 20000, 150, 720);
            seeds[11] = new Seed(11, "吊钟花", 600, 30000, 175, 1120);
            seeds[12] = new Seed(12, "平安果", 800, 40000, 200, 1520);


            seeds[13] = new Seed(13, "多彩葫芦", 1000, 36000, 200, 4500);
            seeds[14] = new Seed(14, "人参娃", 3000, 60000, 250, 25000);
            seeds[15] = new Seed(15, "夏腊梅", 6000, 120000, 300, 40000);
            seeds[16] = new Seed(16, "彩虹玫瑰", 10000, 172800, 300, 55000);
        }
    }
}
