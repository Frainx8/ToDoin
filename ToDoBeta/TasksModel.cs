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
        public int Priority { get; set; }
        public string TimeToDo { get; set; }
    }
}
