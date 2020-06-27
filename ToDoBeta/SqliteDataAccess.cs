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
                var output = cnn.Query<TasksModel>("select * from Tasks", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveTask(TasksModel task)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Tasks (Task, Comment, Priority, TimeToDo) values (@Task, @Comment, @Priority, @TimeToDo)", task);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
