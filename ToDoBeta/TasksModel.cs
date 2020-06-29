using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoBeta
{
    public class TasksModel
    {
        public int ID { get; set; }
        public string Task { get; set; }
        public string Comment { get; set; }

        private int priority;
        public int Priority 
        { 
            get
            {
                return priority;
            }
            set
            {
                if(value < 0)
                {
                    priority = 0;
                } else if (value > 5)
                {
                    priority = 5;
                }
                else
                {
                    priority = value;
                }
            }
        }
        public string TimeToDo { get; set; }

        public TasksModel(int ID, string task, string Comment = "", int Priority = 5, string TimeToDo = null)
        {
            this.ID = ID;
            Task = task;
            this.Comment = Comment;
            this.Priority = Priority;
            this.TimeToDo = TimeToDo;
        }

        public TasksModel() { }
    }
}
