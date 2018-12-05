namespace BugTrackingSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnOpenDataFile = new System.Windows.Forms.Button();
            this.BtnCreateDataFile = new System.Windows.Forms.Button();
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.Username = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewProjects = new System.Windows.Forms.ListView();
            this.ProjectName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProjectDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewTasks = new System.Windows.Forms.ListView();
            this.User = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Project = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Priority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TaskDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnViewUserTask = new System.Windows.Forms.Button();
            this.btnViewProjectTask = new System.Windows.Forms.Button();
            this.btnDelProject = new System.Windows.Forms.Button();
            this.btnDelTask = new System.Windows.Forms.Button();
            this.btnAllTasks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnOpenDataFile
            // 
            this.BtnOpenDataFile.Location = new System.Drawing.Point(0, 12);
            this.BtnOpenDataFile.Name = "BtnOpenDataFile";
            this.BtnOpenDataFile.Size = new System.Drawing.Size(85, 23);
            this.BtnOpenDataFile.TabIndex = 0;
            this.BtnOpenDataFile.Text = "Open data file";
            this.BtnOpenDataFile.UseVisualStyleBackColor = true;
            this.BtnOpenDataFile.Click += new System.EventHandler(this.BtnOpenDataFile_Click);
            // 
            // BtnCreateDataFile
            // 
            this.BtnCreateDataFile.Location = new System.Drawing.Point(91, 12);
            this.BtnCreateDataFile.Name = "BtnCreateDataFile";
            this.BtnCreateDataFile.Size = new System.Drawing.Size(97, 23);
            this.BtnCreateDataFile.TabIndex = 1;
            this.BtnCreateDataFile.Text = "Create data file";
            this.BtnCreateDataFile.UseVisualStyleBackColor = true;
            this.BtnCreateDataFile.Click += new System.EventHandler(this.BtnCreateDataFile_Click);
            // 
            // listViewUsers
            // 
            this.listViewUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Username});
            this.listViewUsers.GridLines = true;
            this.listViewUsers.Location = new System.Drawing.Point(12, 110);
            this.listViewUsers.MultiSelect = false;
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.Size = new System.Drawing.Size(73, 316);
            this.listViewUsers.TabIndex = 3;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            this.listViewUsers.View = System.Windows.Forms.View.Details;
            // 
            // Username
            // 
            this.Username.Text = "Username";
            this.Username.Width = 68;
            // 
            // listViewProjects
            // 
            this.listViewProjects.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listViewProjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProjectName,
            this.ProjectDescription});
            this.listViewProjects.FullRowSelect = true;
            this.listViewProjects.GridLines = true;
            this.listViewProjects.Location = new System.Drawing.Point(115, 110);
            this.listViewProjects.MultiSelect = false;
            this.listViewProjects.Name = "listViewProjects";
            this.listViewProjects.Size = new System.Drawing.Size(373, 316);
            this.listViewProjects.TabIndex = 4;
            this.listViewProjects.UseCompatibleStateImageBehavior = false;
            this.listViewProjects.View = System.Windows.Forms.View.Details;
            // 
            // ProjectName
            // 
            this.ProjectName.Text = "Project";
            this.ProjectName.Width = 68;
            // 
            // ProjectDescription
            // 
            this.ProjectDescription.Text = "Description";
            this.ProjectDescription.Width = 300;
            // 
            // listViewTasks
            // 
            this.listViewTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.User,
            this.Project,
            this.Type,
            this.Priority,
            this.TaskDescription});
            this.listViewTasks.FullRowSelect = true;
            this.listViewTasks.GridLines = true;
            this.listViewTasks.Location = new System.Drawing.Point(544, 110);
            this.listViewTasks.MultiSelect = false;
            this.listViewTasks.Name = "listViewTasks";
            this.listViewTasks.Size = new System.Drawing.Size(676, 316);
            this.listViewTasks.TabIndex = 5;
            this.listViewTasks.UseCompatibleStateImageBehavior = false;
            this.listViewTasks.View = System.Windows.Forms.View.Details;
            // 
            // User
            // 
            this.User.Text = "User";
            this.User.Width = 68;
            // 
            // Project
            // 
            this.Project.Text = "Project";
            this.Project.Width = 68;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 68;
            // 
            // Priority
            // 
            this.Priority.Text = "Priority";
            this.Priority.Width = 68;
            // 
            // TaskDescription
            // 
            this.TaskDescription.Text = "Description";
            this.TaskDescription.Width = 400;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(12, 454);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(73, 23);
            this.btnAddUser.TabIndex = 6;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnAddProject
            // 
            this.btnAddProject.Location = new System.Drawing.Point(115, 454);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(82, 23);
            this.btnAddProject.TabIndex = 7;
            this.btnAddProject.Text = "Add Project";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(544, 454);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(73, 23);
            this.btnAddTask.TabIndex = 8;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Location = new System.Drawing.Point(12, 483);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(73, 23);
            this.btnDeleteUser.TabIndex = 9;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnViewUserTask
            // 
            this.btnViewUserTask.Location = new System.Drawing.Point(12, 512);
            this.btnViewUserTask.Name = "btnViewUserTask";
            this.btnViewUserTask.Size = new System.Drawing.Size(73, 23);
            this.btnViewUserTask.TabIndex = 10;
            this.btnViewUserTask.Text = " User Tasks";
            this.btnViewUserTask.UseVisualStyleBackColor = true;
            this.btnViewUserTask.Click += new System.EventHandler(this.btnViewUserTask_Click);
            // 
            // btnViewProjectTask
            // 
            this.btnViewProjectTask.Location = new System.Drawing.Point(115, 512);
            this.btnViewProjectTask.Name = "btnViewProjectTask";
            this.btnViewProjectTask.Size = new System.Drawing.Size(82, 23);
            this.btnViewProjectTask.TabIndex = 12;
            this.btnViewProjectTask.Text = "Project Tasks";
            this.btnViewProjectTask.UseVisualStyleBackColor = true;
            this.btnViewProjectTask.Click += new System.EventHandler(this.btnViewProjectTask_Click);
            // 
            // btnDelProject
            // 
            this.btnDelProject.Location = new System.Drawing.Point(115, 483);
            this.btnDelProject.Name = "btnDelProject";
            this.btnDelProject.Size = new System.Drawing.Size(82, 23);
            this.btnDelProject.TabIndex = 11;
            this.btnDelProject.Text = "Delete Project";
            this.btnDelProject.UseVisualStyleBackColor = true;
            this.btnDelProject.Click += new System.EventHandler(this.btnDelProject_Click);
            // 
            // btnDelTask
            // 
            this.btnDelTask.Location = new System.Drawing.Point(544, 483);
            this.btnDelTask.Name = "btnDelTask";
            this.btnDelTask.Size = new System.Drawing.Size(73, 23);
            this.btnDelTask.TabIndex = 13;
            this.btnDelTask.Text = "Delete Task";
            this.btnDelTask.UseVisualStyleBackColor = true;
            this.btnDelTask.Click += new System.EventHandler(this.btnDelTask_Click);
            // 
            // btnAllTasks
            // 
            this.btnAllTasks.Location = new System.Drawing.Point(544, 512);
            this.btnAllTasks.Name = "btnAllTasks";
            this.btnAllTasks.Size = new System.Drawing.Size(73, 23);
            this.btnAllTasks.TabIndex = 14;
            this.btnAllTasks.Text = "All Tasks";
            this.btnAllTasks.UseVisualStyleBackColor = true;
            this.btnAllTasks.Click += new System.EventHandler(this.btnAllTasks_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 566);
            this.Controls.Add(this.btnAllTasks);
            this.Controls.Add(this.btnDelTask);
            this.Controls.Add(this.btnViewProjectTask);
            this.Controls.Add(this.btnDelProject);
            this.Controls.Add(this.btnViewUserTask);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.btnAddProject);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.listViewTasks);
            this.Controls.Add(this.listViewProjects);
            this.Controls.Add(this.listViewUsers);
            this.Controls.Add(this.BtnCreateDataFile);
            this.Controls.Add(this.BtnOpenDataFile);
            this.Name = "MainForm";
            this.Text = "BugTrackingSystem";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnOpenDataFile;
        private System.Windows.Forms.Button BtnCreateDataFile;
        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.ColumnHeader Username;
        private System.Windows.Forms.ListView listViewProjects;
        private System.Windows.Forms.ColumnHeader ProjectName;
        private System.Windows.Forms.ColumnHeader ProjectDescription;
        private System.Windows.Forms.ListView listViewTasks;
        private System.Windows.Forms.ColumnHeader User;
        private System.Windows.Forms.ColumnHeader Project;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Priority;
        private System.Windows.Forms.ColumnHeader TaskDescription;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnViewUserTask;
        private System.Windows.Forms.Button btnViewProjectTask;
        private System.Windows.Forms.Button btnDelProject;
        private System.Windows.Forms.Button btnDelTask;
        private System.Windows.Forms.Button btnAllTasks;
    }
}

