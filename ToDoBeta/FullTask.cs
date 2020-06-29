using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoBeta
{
    public partial class FullTask : Form
    {
        public FullTask()
        {
            InitializeComponent();
        }

        private void FullTask_Load(object sender, EventArgs e)
        {

        }

        public void ChangeValues(TasksModel task)
        {
            taskValue.Text = task.Task;
            commentValue.Text = task.Comment;
            PriorityValue.Text = task.Priority.ToString();
            dateValue.Text = task.TimeToDo;
        }
    }
}
