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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //List<TasksModel> tasks = SqliteDataAccess.LoadTasks();
            //foreach(var task in tasks)
            //{
            //    AddTaskToThePanel(task);
            //}
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AddTaskToThePanel(TasksModel task)
        {
            FlowLayoutPanel box = new FlowLayoutPanel();
            box.FlowDirection = FlowDirection.LeftToRight;
            box.Size = new Size(385, 30);
            box.BorderStyle = BorderStyle.FixedSingle;
 




            Label labelTask = new Label();
            labelTask.Text = task.Task;
            labelTask.AutoSize = true;
            labelTask.Margin = new Padding(7);
            box.Controls.Add(labelTask);

            Button comment = new Button();
            comment.Size = new Size(20, 20);
            //Do Comment window
            box.Controls.Add(comment);

            Label priority = new Label();
            priority.AutoSize = true;
            priority.Text = task.Priority.ToString();
            priority.Margin = new Padding(7);
            box.Controls.Add(priority);

            if (String.IsNullOrEmpty(task.TimeToDo) != true)
            {
                Label date = new Label();
                date.Text = task.TimeToDo;
                date.AutoSize = true;
                date.Margin = new Padding(7);
                box.Controls.Add(date);

            }


            CheckBox IsDone = new CheckBox();
            box.Controls.Add(IsDone);

            MainFLP.Controls.Add(box);
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrWhiteSpace(TaskTextBox.Text) != true)
            {
                TasksModel task;
                if (checkBoxTime.CheckState == CheckState.Checked)
                {
                    task = new TasksModel(TaskTextBox.Text, CommentTextBox.Text, Convert.ToInt32(numUDPriority.Value), dateTimePicker.Value.ToShortDateString());
                }
                else
                {
                    task = new TasksModel(TaskTextBox.Text, CommentTextBox.Text, Convert.ToInt32(numUDPriority.Value));
                }
                SqliteDataAccess.SaveTask(task);
                AddTaskToThePanel(task);
            }
            else
            {
                MessageBox.Show("Write a task!", "Add task", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TaskTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxTime_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTime.CheckState == CheckState.Checked)
            {
                dateTimePicker.Enabled = true;
            }
            else
            {
                dateTimePicker.Enabled = false;
            }
        }

        private void numUDPriority_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
