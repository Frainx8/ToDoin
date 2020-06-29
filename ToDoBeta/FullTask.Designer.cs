namespace ToDoBeta
{
    partial class FullTask
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateValue = new System.Windows.Forms.Label();
            this.PriorityValue = new System.Windows.Forms.Label();
            this.commentValue = new System.Windows.Forms.Label();
            this.taskValue = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblComment = new System.Windows.Forms.Label();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateValue);
            this.groupBox1.Controls.Add(this.PriorityValue);
            this.groupBox1.Controls.Add(this.commentValue);
            this.groupBox1.Controls.Add(this.taskValue);
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.lblPriority);
            this.groupBox1.Controls.Add(this.lblComment);
            this.groupBox1.Controls.Add(this.lblTaskName);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 164);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // dateValue
            // 
            this.dateValue.AutoSize = true;
            this.dateValue.Location = new System.Drawing.Point(113, 135);
            this.dateValue.Name = "dateValue";
            this.dateValue.Size = new System.Drawing.Size(34, 13);
            this.dateValue.TabIndex = 31;
            this.dateValue.Text = "Value";
            // 
            // PriorityValue
            // 
            this.PriorityValue.AutoSize = true;
            this.PriorityValue.Location = new System.Drawing.Point(76, 95);
            this.PriorityValue.Name = "PriorityValue";
            this.PriorityValue.Size = new System.Drawing.Size(34, 13);
            this.PriorityValue.TabIndex = 30;
            this.PriorityValue.Text = "Value";
            // 
            // commentValue
            // 
            this.commentValue.AutoSize = true;
            this.commentValue.Location = new System.Drawing.Point(93, 45);
            this.commentValue.Name = "commentValue";
            this.commentValue.Size = new System.Drawing.Size(34, 13);
            this.commentValue.TabIndex = 29;
            this.commentValue.Text = "Value";
            // 
            // taskValue
            // 
            this.taskValue.AutoSize = true;
            this.taskValue.Location = new System.Drawing.Point(72, 16);
            this.taskValue.Name = "taskValue";
            this.taskValue.Size = new System.Drawing.Size(34, 13);
            this.taskValue.TabIndex = 28;
            this.taskValue.Text = "Value";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(6, 135);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(101, 13);
            this.lblDate.TabIndex = 27;
            this.lblDate.Text = "Дата выполнения:";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(6, 95);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(64, 13);
            this.lblPriority.TabIndex = 26;
            this.lblPriority.Text = "Приоритет:";
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(6, 46);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(80, 13);
            this.lblComment.TabIndex = 25;
            this.lblComment.Text = "Комментарий:";
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Location = new System.Drawing.Point(6, 16);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(60, 13);
            this.lblTaskName.TabIndex = 24;
            this.lblTaskName.Text = "Название:";
            // 
            // FullTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 188);
            this.Controls.Add(this.groupBox1);
            this.Name = "FullTask";
            this.Text = "FullTask";
            this.Load += new System.EventHandler(this.FullTask_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label dateValue;
        private System.Windows.Forms.Label PriorityValue;
        private System.Windows.Forms.Label commentValue;
        private System.Windows.Forms.Label taskValue;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label lblTaskName;
    }
}