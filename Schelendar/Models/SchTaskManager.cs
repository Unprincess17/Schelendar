using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace Schelendar.Models
{
    public static class SchTaskManager
    {
        public static string UserDBFile = config.UserDBFile;
        public static string TaskDBFile = config.TaskDBFile;
        public static string TaskGroupDBFile = config.TaskGroupDBFile;


        public static void AddTask(int userID, SchTask task, int GroupID = 0, int force = 0, int iscourse=0)
        {
            int DefaultGroupID = userID;

            if (task == null)
            {
                throw new ArgumentNullException($"添加失败：事件{task.SchTaskInfo}状态异常");
            }

            //是否存在GroupID的组
            object result;
            //若GroupID对应组不存在，选择不创建(force == 0)时，当组ID为非default值时抛异常，否则创建组default
            using (SQLiteConnection cn = new SQLiteConnection("data source=" + TaskGroupDBFile))
            {
                SQLiteCommand cmd = cn.CreateCommand();
                cmd.CommandText = $"SELECT COUNT(*) FROM SchTaskGroups WHERE SchTaskGroupID='{GroupID}'";
                cn.Open();
                result = cmd.ExecuteScalar();
                cn.Close();
                if (iscourse.Equals(0))
                {
                    if (GroupID < config.MAX_USER_NUM && GroupID != DefaultGroupID && GroupID != 0)//试图创建默认组
                    {
                        throw new ArgumentException($"添加失败：不应将事件添加至默认分组{GroupID}");
                    }
                    else if (GroupID == 0)//未定义GroupID
                    {
                        GroupID = DefaultGroupID;
                    }
                    if (Convert.ToInt32(result) == 0)
                    {
                        if (force == 0 && GroupID != DefaultGroupID)
                        {
                            throw new ArgumentException($"所要添加事件组'{GroupID}'不存在");
                        }
                        else if (GroupID == DefaultGroupID)//GroupID==DefaultGroupID且未创建
                        {
                            cmd.CommandText = $"INSERT INTO SchTaskGroups (SchTaskGroupID,SchGroupInfo,SchUserID,TomatoNum) VALUES ('{GroupID}','未分组','{userID}',0);";
                        }
                        else if (force == 1 && GroupID != DefaultGroupID)
                        {
                            cmd.CommandText = $"INSERT INTO SchTaskGroups (SchTaskGroupID,SchGroupInfo,SchUserID,TomatoNum) VALUES ('{GroupID}','{task.SchTaskInfo}','{userID}',0);";
                        }
                    }
                }
                else//iscourse, 在最后一组后添加课程组
                {
                    cmd.CommandText = $"INSERT INTO SchTaskGroups (SchTaskGroupID,SchGroupInfo,SchUserID,TomatoNum) VALUES (NULL,'{task.SchTaskInfo}','{userID}',0);";
                }
                cn.Open();
                //cmd.ExecuteNonQueryAsync();
                cmd.ExecuteNonQuery();
                cn.Close();

                //赋值TaskGroupID
                if (iscourse.Equals(1))
                {
                    cmd.CommandText = $"SELECT COUNT(*) FROM SchTaskGroups WHERE SchUserID='{userID}';";
                    cn.Open();
                    result = cmd.ExecuteScalar();
                    cn.Close();
                    task.SchTaskGroupID = Convert.ToInt32(result);
                }
            }
            
            using (SQLiteConnection cn = new SQLiteConnection("data source=" + TaskDBFile))
            {
                SQLiteCommand cmd = cn.CreateCommand();
                cmd.CommandText = $"SELECT COUNT(*) FROM SchTasks";
                cn.Open();
                result = cmd.ExecuteScalar();
                cn.Close();
                task.SchTaskID = Convert.ToInt32(result);//courseID start from 1
                cmd.CommandText = $"INSERT INTO SchTasks VALUES(NULL, '{task.SchTaskInfo}', '{task.SchTaskLocation}', '{task.StartDate}', '{task.EndDate}', '{task.isRepeat}', '{task.isDone}','{(task.SchTaskGroupID == 0 ? GroupID : task.SchTaskGroupID)}','{userID}');";
                task.SchTaskGroupID = task.SchTaskGroupID == 0 ? GroupID : task.SchTaskGroupID;
                cn.Open();
                //cmd.ExecuteNonQueryAsync(); 
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        public static void UpdateTask(int schUserID, string oldTaskName, SchTask newTask)
        {
            if (newTask == null)
            {
                throw new ArgumentNullException($"更新失败：任务{newTask.SchTaskInfo}状态异常");
            }

            object result;
            try
            {

                //判断是否存在任务
                using (SQLiteConnection cn = new SQLiteConnection("data source=" + TaskDBFile))
                {
                    SQLiteCommand cmd = cn.CreateCommand();
                    cn.Open();
                    cmd.CommandText = $"SELECT SchTaskID FROM SchTasks WHERE SchUserID='{schUserID}' AND SchTaskInfo='{oldTaskName}'";
                    result = cmd.ExecuteScalar();
                    cn.Close();
                }
                if(result == null || Convert.ToInt32(result) == 0)
                {
                    throw new ArgumentException($"更新失败：未查询到任务{newTask.SchTaskInfo}");
                }
            }
            catch (ArgumentException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                e.Source += "更新失败";
                throw e;
            }

            //更新任务至数据库
            using (SQLiteConnection cn = new SQLiteConnection("data source=" + TaskDBFile))
            {
                SQLiteCommand cmd = cn.CreateCommand();
                cmd.CommandText = $"UPDATE SchTasks SET SchTaskInfo='{newTask.SchTaskInfo}', SchTaskLocation='{newTask.SchTaskLocation}', StartDate='{newTask.StartDate}', EndDate='{newTask.EndDate}', isRepeat='{newTask.isRepeat}', isDone='{newTask.isDone}',SchTaskGroupID='{newTask.SchTaskGroupID}' WHERE SchUserID='{schUserID}' AND SchTaskID='{result}';";
                cn.Open();
                //cmd.ExecuteNonQueryAsync();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        public static void changeGroup(int schUserID, int taskID, int newGroupID)
        {
            object result;
            try
            {

                //判断是否存在任务
                using (SQLiteConnection cn = new SQLiteConnection("data source=" + TaskDBFile))
                {
                    SQLiteCommand cmd = cn.CreateCommand();
                    cn.Open();
                    cmd.CommandText = $"SELECT COUNT(*) FROM SchTasks WHERE SchUserID='{schUserID}' AND SchTaskID='{taskID}'";
                    result = cmd.ExecuteScalar();
                    cn.Close();
                }
                if (result == null || Convert.ToInt32(result) == 0)
                {
                    throw new ArgumentException($"更新失败：未查询到指定任务");
                }
            }
            catch (ArgumentException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                e.Source += "更新失败";
                throw e;
            }

            //更新任务至数据库
            using (SQLiteConnection cn = new SQLiteConnection("data source=" + TaskDBFile))
            {
                SQLiteCommand cmd = cn.CreateCommand();
                cmd.CommandText = $"UPDATE SchTasks SET SchTaskGroupID='{newGroupID}' WHERE SchUserID='{schUserID}' AND SchTaskID='{taskID}';";
                cn.Open();
                //cmd.ExecuteNonQueryAsync();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        public static void DeleteTask(int userID, string taskInfo)
        {
            using (SQLiteConnection cn = new SQLiteConnection("data source=" + TaskDBFile))
            {
                SQLiteCommand cmd = cn.CreateCommand();
                cmd.CommandText = $"DELETE FROM SchTasks WHERE SchUserID='{userID}' AND SchTaskInfo='{taskInfo}';";
                cn.Open();
                cmd.ExecuteScalarAsync();
                cmd.ExecuteScalar();
                cn.Close();
            }
        }

        public static void DeleteTask(int userID, int taskID) 
        {
            using (SQLiteConnection cn = new SQLiteConnection("data source=" + TaskDBFile))
            {
                SQLiteCommand cmd = cn.CreateCommand();
                cmd.CommandText = $"DELETE FROM SchTasks WHERE SchUserID='{userID}' AND SchTaskID='{taskID}';";
                cn.Open();
                cmd.ExecuteScalarAsync();
                cmd.ExecuteScalar();
                cn.Close();
            }
        }

        public static List<SchTask> GetTasks(int userID, int notDone = 1) {
            List<SchTask> TaskList = new List<SchTask>();
            using (SQLiteConnection cn = new SQLiteConnection("data source=" + TaskDBFile))
            {
                SQLiteCommand cmd = cn.CreateCommand();
                if (notDone == 1)
                {//未做
                    cmd.CommandText = $"SELECT * FROM SchTasks WHERE SchUserID='{userID}' AND isDone=0;";
                }
                else
                {//全部
                    cmd.CommandText = $"SELECT * FROM SchTasks WHERE SchUserID='{userID}';";
                }
                cn.Open();
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TaskList.Add(new SchTask(
                            schTaskId: Convert.ToInt32(reader["SchTaskID"]),
                            schTaskInfo: reader["SchTaskInfo"].ToString(),
                            schTaskLocation: reader["SchTaskLocation"].ToString(),
                            startDate: Convert.ToDateTime(reader.GetString(3)),
                            endDate: Convert.ToDateTime(reader.GetString(4)),
                            isRepeat: Convert.ToInt32(reader["isRepeat"]),
                            isDone: Convert.ToInt32(reader["isDone"]),
                            schTaskGroupID: Convert.ToInt32(reader["SchTaskGroupID"]),
                            userID: Convert.ToInt32(reader["SchUserID"])));
                    }
                }

                cn.Close();
            }
            return TaskList;
        }

        public static List<SchTask> GetGroup(int userID, int taskID, int notDone = 0) {
            List<SchTask> TaskList = new List<SchTask>();
            using (SQLiteConnection cn = new SQLiteConnection("data source=" + TaskDBFile))
            {
                int gid = -1;
                SQLiteCommand cmd = cn.CreateCommand();
                if (notDone == 1)
                {//未做
                    cmd.CommandText = $"SELECT * FROM SchTasks WHERE SchUserID='{userID}' AND isDone=0 AND SchTaskID='{taskID}';";
                }
                else
                {//全部
                    cmd.CommandText = $"SELECT SchTaskGroupID FROM SchTasks WHERE SchUserID='{userID}' AND SchTaskID='{taskID}'";
                }
                cn.Open();
                gid = Convert.ToInt32(cmd.ExecuteScalar());
                cn.Close();
                if (gid == -1)
                {
                    throw new ArgumentException($"查询失败：未找到ID为\"{taskID}\"的任务");
                }

                cmd.CommandText = $"SELECT * FROM SchTasks WHERE SchUserID='{userID}' AND SchTaskGroupID='{gid}';";
                cn.Open();
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TaskList.Add(new SchTask(
                            schTaskId: Convert.ToInt32(reader["SchTaskID"]),
                            schTaskInfo: reader["SchTaskInfo"].ToString(),
                            schTaskLocation: reader["SchTaskLocation"].ToString(),
                            startDate: Convert.ToDateTime(reader["StartDate"]),
                            endDate: Convert.ToDateTime(reader["EndDate"]),
                            isRepeat: Convert.ToInt32(reader["isRepeat"]),
                            isDone: Convert.ToInt32(reader["isDone"]),
                            schTaskGroupID: Convert.ToInt32(reader["SchTaskGroupID"]),
                            userID: Convert.ToInt32(reader["SchUserID"])));
                    }
                }

                cn.Close();
            }
            return TaskList;
        }

        public static List<SchTask> GetGroup(int userID, string taskInfo, int notDone = 0) {
            List<SchTask> TaskList = new List<SchTask>();
            using (SQLiteConnection cn = new SQLiteConnection("data source=" + TaskDBFile))
            {
                int gid = -1;
                SQLiteCommand cmd = cn.CreateCommand();
                if (notDone == 1)
                {//未做
                    cmd.CommandText = $"SELECT * FROM SchTasks WHERE SchUserID='{userID}' AND isDone=0 AND SchTaskInfo='{taskInfo}';";
                }
                else
                {//全部
                    cmd.CommandText = $"SELECT SchTaskGroupID FROM SchTasks WHERE SchUserID='{userID}' AND SchTaskInfo='{taskInfo}'";
                }
                cn.Open();
                gid = Convert.ToInt32(cmd.ExecuteScalar());
                cn.Close();
                if (gid == -1)
                {
                    throw new ArgumentException($"查询失败：未找到事件描述为\"{taskInfo}\"的任务");
                }

                cmd.CommandText = $"SELECT * FROM SchTasks WHERE SchUserID='{userID}' AND SchTaskGroupID='{gid}';";
                cn.Open();
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        TaskList.Add(new SchTask(
                            schTaskId: Convert.ToInt32(reader["SchTaskID"]),
                            schTaskInfo: reader["SchTaskInfo"].ToString(),
                            schTaskLocation: reader["SchTaskLocation"].ToString(),
                            startDate: Convert.ToDateTime(reader["StartDate"]),
                            endDate: Convert.ToDateTime(reader["EndDate"]),
                            isRepeat: Convert.ToInt32(reader["isRepeat"]),
                            isDone: Convert.ToInt32(reader["isDone"]),
                            schTaskGroupID: Convert.ToInt32(reader["SchTaskGroupID"]),
                            userID: Convert.ToInt32(reader["SchUserID"])));
                    }
                }

                cn.Close();
            }
            return TaskList;
        }

        public static List<SchTaskGroup> GetGroups(int userID)
        {
            List<SchTaskGroup> GroupList = new List<SchTaskGroup>();
            using (SQLiteConnection cn = new SQLiteConnection("data source=" + TaskGroupDBFile))
            {
                SQLiteCommand cmd = cn.CreateCommand();
                cmd.CommandText = $"SELECT * FROM SchTaskGroups WHERE SchUserID='{userID}';";
                cn.Open();
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        GroupList.Add(new SchTaskGroup(
                            groupID: Convert.ToInt32(reader["SchTaskGroupID"]),
                            groupInfo: reader["SchGroupInfo"].ToString(),
                            schUserID: Convert.ToInt32(reader["SchUserID"]),
                            tomatoNum: Convert.ToInt32(reader["TomatoNum"])));
                    }
                }

                cn.Close();
            }
            return GroupList;
        }

        public static void UpdateGroup(int userID, int groupID, SchTaskGroup newgroup)
        {
            using (SQLiteConnection cn = new SQLiteConnection("data source=" + TaskDBFile))
            {
                SQLiteCommand cmd = cn.CreateCommand();
                cmd.CommandText = $"UPDATE SchTaskGroups set SchGroupInfo='{newgroup.GroupInfo}', TomatoNum='{newgroup.TomatoNum}' WHERE SchUserID='{userID}' AND SchTaskGroupID='{groupID}'";
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

    }
}
