namespace WindowsFormsApplication4
{
    partial class HomePage
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
            this.UserTaskReports = new System.Windows.Forms.Button();
            this.DiariesReports = new System.Windows.Forms.Button();
            this.ManageDiaries = new System.Windows.Forms.Button();
            this.ManageTasks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserTaskReports
            // 
            this.UserTaskReports.Location = new System.Drawing.Point(126, 314);
            this.UserTaskReports.Name = "UserTaskReports";
            this.UserTaskReports.Size = new System.Drawing.Size(75, 54);
            this.UserTaskReports.TabIndex = 0;
            this.UserTaskReports.Text = "User Task reports";
            this.UserTaskReports.UseVisualStyleBackColor = true;
            this.UserTaskReports.Click += new System.EventHandler(this.UserTaskReports_Click);
            // 
            // DiariesReports
            // 
            this.DiariesReports.Location = new System.Drawing.Point(434, 314);
            this.DiariesReports.Name = "DiariesReports";
            this.DiariesReports.Size = new System.Drawing.Size(75, 54);
            this.DiariesReports.TabIndex = 1;
            this.DiariesReports.Text = "Diaries reports";
            this.DiariesReports.UseVisualStyleBackColor = true;
            this.DiariesReports.Click += new System.EventHandler(this.DiariesReports_Click);
            // 
            // ManageDiaries
            // 
            this.ManageDiaries.Location = new System.Drawing.Point(126, 88);
            this.ManageDiaries.Name = "ManageDiaries";
            this.ManageDiaries.Size = new System.Drawing.Size(75, 54);
            this.ManageDiaries.TabIndex = 2;
            this.ManageDiaries.Text = "Manage Diaries";
            this.ManageDiaries.UseVisualStyleBackColor = true;
            this.ManageDiaries.Click += new System.EventHandler(this.ManageDiaries_Click);
            // 
            // ManageTasks
            // 
            this.ManageTasks.Location = new System.Drawing.Point(434, 88);
            this.ManageTasks.Name = "ManageTasks";
            this.ManageTasks.Size = new System.Drawing.Size(75, 54);
            this.ManageTasks.TabIndex = 3;
            this.ManageTasks.Text = "Manage Tasks";
            this.ManageTasks.UseVisualStyleBackColor = true;
            this.ManageTasks.Click += new System.EventHandler(this.ManageTasks_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 489);
            this.Controls.Add(this.ManageTasks);
            this.Controls.Add(this.ManageDiaries);
            this.Controls.Add(this.DiariesReports);
            this.Controls.Add(this.UserTaskReports);
            this.Name = "HomePage";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UserTaskReports;
        private System.Windows.Forms.Button DiariesReports;
        private System.Windows.Forms.Button ManageDiaries;
        private System.Windows.Forms.Button ManageTasks;
    }
}