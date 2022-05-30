using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.Data.Sqlite;
using Microsoft.Data.Sqlite;
using System.Data.SQLite;

namespace Schelendar.FarmClass
{
    public class FarmDBHelper
    {
        public void create()
        {
            var fileName = "FarmUsers.db";
            if (File.Exists(fileName) == false)//不存在用户文件
            {
                SQLiteConnection.CreateFile(fileName);//创建数据库
            }
            SQLiteConnection cn = new SQLiteConnection("data source=" + fileName);//建立连接对象
            SQLiteCommand cmd = new SQLiteCommand();

            //当没有用户表时建立用户表
            cn.Open();//连接
            cmd.Connection = cn;
            cmd.CommandText =
                "CREATE TABLE IF NOT EXISTS FarmUsers(" +
                "username varchar(10) UNIQUE," +
                "password varchar(100)," +
                "lv int," +
                "expnow int," +
                "expmax int," +
                "gold int," +
                "seed1 int,seed2 int,seed3 int,seed4 int,seed5 int,seed6 int,seed7 int,seed8 int,seed9 int,seed10 int,seed11 int,seed12 int,seed13 int,seed14 int,seed15 int,seed16 int," +
                "unlocked1 int,unlocked2 int,unlocked3 int,unlocked4 int,unlocked5 int,unlocked6 int,unlocked7 int,unlocked8 int,unlocked9 int,unlocked10 int,unlocked11 int,unlocked12 int," +
                "planted1 int,planted2 int,planted3 int,planted4 int,planted5 int,planted6 int,planted7 int,planted8 int,planted9 int,planted10 int,planted11 int,planted12 int," +
                "ts1 int,ts2 int,ts3 int,ts4 int,ts5 int,ts6 int,ts7 int,ts8 int,ts9 int,ts10 int,ts11 int,ts12 int" +
                ")";
            cmd.ExecuteNonQuery();
            cn.Close();//关闭连接

        }
    }
}
