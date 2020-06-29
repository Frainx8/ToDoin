using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoBeta
{
    public class SqliteDataAccess
    {

        public static List<TasksModel> LoadTasks()
        {
            using(IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                List<TasksModel> tasks = cnn.Query<TasksModel>("select * from Tasks").ToList();
                return tasks;
            }
        }

        public static TasksModel LoadATask(TasksModel task)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                return cnn.Query<TasksModel>("select * from Tasks WHERE ID = @ID", task).First();
            }
        }

        public static void SaveTask(TasksModel task)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Tasks (ID, Task, Comment, Priority, TimeToDo) values (@ID, @Task, @Comment, @Priority, @TimeToDo);", task);
            }
        }

        public static void DeleteTask(TasksModel task)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("Delete From Tasks WHERE ID = @ID", task);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
