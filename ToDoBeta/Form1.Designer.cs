namespace ToDoBeta
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelListTask = new System.Windows.Forms.Label();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.labelAddTask = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelComment = new System.Windows.Forms.Label();
            this.labelPriority = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CommentTextBox = new System.Windows.Forms.RichTextBox();
            this.TaskTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.numUDPriority = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numUDPriority)).BeginInit();
            this.SuspendLayout();
            // 
            // labelListTask
            // 
            this.labelListTask.AutoSize = true;
            this.labelListTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelListTask.Location = new System.Drawing.Point(507, 13);
            this.labelListTask.Name = "labelListTask";
            this.labelListTask.Size = new System.Drawing.Size(171, 29);
            this.labelListTask.TabIndex = 7;
            this.labelListTask.Text = "Список задач";
            // 
            // btnAddTask
            // 
            this.btnAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddTask.Location = new System.Drawing.Point(58, 354);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(252, 59);
            this.btnAddTask.TabIndex = 8;
            this.btnAddTask.Text = "Добавить задачу";
            this.btnAddTask.UseVisualStyleBackColor = true;
            // 
            // labelAddTask
            // 
            this.labelAddTask.AutoSize = true;
            this.labelAddTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddTask.Location = new System.Drawing.Point(69, 13);
            this.labelAddTask.Name = "labelAddTask";
            this.labelAddTask.Size = new System.Drawing.Size(207, 29);
            this.labelAddTask.TabIndex = 9;
            this.labelAddTask.Text = "Добавить задачу";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(38, 63);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(92, 22);
            this.labelName.TabIndex = 10;
            this.labelName.Text = "Название";
            this.labelName.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelComment.Location = new System.Drawing.Point(38, 120);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(126, 22);
            this.labelComment.TabIndex = 11;
            this.labelComment.Text = "Комментарий";
            // 
            // labelPriority
            // 
            this.labelPriority.AutoSize = true;
            this.labelPriority.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPriority.Location = new System.Drawing.Point(38, 265);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(99, 22);
            this.labelPriority.TabIndex = 12;
            this.labelPriority.Text = "Приоритет";
            this.labelPriority.Click += new System.EventHandler(this.label4_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(166, 265);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(160, 22);
            this.labelDate.TabIndex = 13;
            this.labelDate.Text = "Дата выполнения";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(155, 307);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 14;
            // 
            // CommentTextBox
            // 
            this.CommentTextBox.Location = new System.Drawing.Point(30, 145);
            this.CommentTextBox.Name = "CommentTextBox";
            this.CommentTextBox.Size = new System.Drawing.Size(325, 96);
            this.CommentTextBox.TabIndex = 15;
            this.CommentTextBox.Text = "";
            // 
            // TaskTextBox
            // 
            this.TaskTextBox.Location = new System.Drawing.Point(30, 88);
            this.TaskTextBox.Name = "TaskTextBox";
            this.TaskTextBox.Size = new System.Drawing.Size(325, 20);
            this.TaskTextBox.TabIndex = 16;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Location = new System.Drawing.Point(374, 52);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(414, 386);
            this.flowLayoutPanel.TabIndex = 17;
            // 
            // numUDPriority
            // 
            this.numUDPriority.Location = new System.Drawing.Point(74, 307);
            this.numUDPriority.Name = "numUDPriority";
            this.numUDPriority.Size = new System.Drawing.Size(32, 20);
            this.numUDPriority.TabIndex = 18;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numUDPriority);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.TaskTextBox);
            this.Controls.Add(this.CommentTextBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelPriority);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelAddTask);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.labelListTask);
            this.Name = "MainForm";
            this.Text = "ToDoin";
            ((System.ComponentModel.ISupportInitialize)(this.numUDPriority)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelListTask;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Label labelAddTask;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.Label labelPriority;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.RichTextBox CommentTextBox;
        private System.Windows.Forms.TextBox TaskTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.NumericUpDown numUDPriority;
    }
}

