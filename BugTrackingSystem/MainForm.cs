using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace BugTrackingSystem
{
    public partial class MainForm : Form
    {

        public static SQLiteConnection connection { get; set; }

        SQLiteCommand command;
        string filePath = string.Empty;
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnOpenDataFile_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "sqlite files (*.sqlite)|*.sqlite";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    filePath = openFileDialog.FileName;
                    Program.Log("Open Database" + filePath);
                    CreateTables();
                    

                }
            }
  }


        private void BtnCreateDataFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {

                saveFileDialog.InitialDirectory = "c:\\";
                saveFileDialog.Filter = "sqlite files (*.sqlite)|*.sqlite";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {

                    filePath = saveFileDialog.FileName;
                    SQLiteConnection.CreateFile("filePath");
                    Program.Log("Create Database" + filePath);
                    CreateTables();

                }
            }

        }

        private void CreateTables()
        {



            try
            {
                connection = new SQLiteConnection("Data Source=" + filePath + ";Version=3;");
                connection.Open();
                command = new SQLiteCommand();
                command.Connection = connection;
                command.CommandText = "CREATE TABLE IF NOT EXISTS Users (Id INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT)";
                command.ExecuteNonQuery();

                command.CommandText = "CREATE TABLE IF NOT EXISTS Projects (Id INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT, Description TEXT)";
                command.ExecuteNonQuery();


                command.CommandText = "CREATE TABLE IF NOT EXISTS Tasks (Id INTEGER PRIMARY KEY AUTOINCREMENT, IdUser INTEGER," +
                    "IdProject INTEGER, Type TEXT, Priority TEXT, Description TEXT)";
                command.ExecuteNonQuery();
                RefreshAll();

            }
            catch (SQLiteException ex)
            {

                MessageBox.Show("Error: " + ex.Message);
                Program.Log("Error: " + ex.Message);
            }

        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (!Checks())
                return;

            var addUser = new AddUser();

            if (addUser.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    command.CommandText = "INSERT INTO Users ('Name') values ('" +
                        addUser.user.Name + "')";

                    command.ExecuteNonQuery();
                    RefreshUsers();
                    Program.Log("Add User: " + addUser.user.Name);
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    Program.Log("Error: " + ex.Message);

                }
            }
        }


        private void RefreshAll()
        {
            RefreshUsers();
            RefreshProjects();
            RefreshTasks();
        }



        private void RefreshUsers()
        {
            if (!Checks())
                return;
            DataTable dTable = new DataTable();
            String sqlQuery;

            try
            {
                listViewUsers.Items.Clear();
                sqlQuery = "SELECT * FROM Users";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, connection);
                adapter.Fill(dTable);

                foreach (DataRow row in dTable.Rows)
                {
                    ListViewItem i = new ListViewItem();

                    i.Tag = new User { Name = row["Name"].ToString(), Number = Convert.ToInt32(row["Id"].ToString()) };
                    i.Text = row["Name"].ToString();

                    listViewUsers.Items.Add(i);
                }
            }

            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void RefreshProjects()
        {
            if (!Checks())
                return;
            DataTable dTable = new DataTable();
            String sqlQuery;

            try
            {
                listViewProjects.Items.Clear();
                sqlQuery = "SELECT * FROM Projects";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, connection);
                adapter.Fill(dTable);

                foreach (DataRow row in dTable.Rows)
                {
                    ListViewItem i = new ListViewItem();

                    i.Tag = new Project { Name = row["Name"].ToString(), Number = Convert.ToInt32(row["Id"].ToString()), Description = row["Description"].ToString() };
                    i.Text = row["Name"].ToString();
                    i.SubItems.Add(row["Description"].ToString());

                    listViewProjects.Items.Add(i);
                }
            }

            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void RefreshTasks()
        {

            if (!Checks())
                return;
            DataTable dTable = new DataTable();
            String sqlQuery;

            try
            {
                listViewTasks.Items.Clear();
                sqlQuery = "SELECT Tasks.Id, Tasks.IdUser, Tasks.IdProject, Tasks.Type, Tasks.Priority, Tasks.Description, Users.Name AS Username, Projects.Name AS Projectname FROM Tasks " +
                    "INNER JOIN Users ON Tasks.IdUser = Users.Id   INNER JOIN Projects ON Tasks.IdProject = Projects.Id ";

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, connection);
                adapter.Fill(dTable);
                foreach (DataRow row in dTable.Rows)
                {
                    ListViewItem i = new ListViewItem();
                    User user = new User
                    {
                        Name = row["Username"].ToString(),
                        Number = Convert.ToInt32(row["IdUser"].ToString())
                    };

                    Project project = new Project
                    {
                        Name = row["Projectname"].ToString(),
                        Number = Convert.ToInt32(row["IdProject"].ToString())
                    };

                    i.Tag = new Task
                    {
                        User = user,
                        Project = project,
                        Number = Convert.ToInt32(row["Id"].ToString()),
                        Type = row["Type"].ToString(),
                        Priority = row["Priority"].ToString(),
                        Description = row["Description"].ToString()
                    };
                    i.Text = row["Username"].ToString();
                    i.SubItems.Add(row["Projectname"].ToString());
                    i.SubItems.Add(row["Type"].ToString());
                    i.SubItems.Add(row["Priority"].ToString());
                    i.SubItems.Add(row["Description"].ToString());
                    listViewTasks.Items.Add(i);
                }


            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        public bool Checks()
        {
            if (connection == null)
            {
                MessageBox.Show("Create or open datafile", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Program.Log("Error: Database isn't open");
                return false;
            }

            if (connection.State != ConnectionState.Open)
            {
                MessageBox.Show("Sorry: Lost connection with database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Program.Log("Error: Connection isn't open");
                return false;
            }
            return true;
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            if (!Checks())
                return;

            var addProject = new AddProject();

            if (addProject.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    command.CommandText = "INSERT INTO Projects ('Name','Description') values ('" +
                        addProject.project.Name + "' , '" +
                        addProject.project.Description + "')";

                    command.ExecuteNonQuery();
                    RefreshProjects();
                    Program.Log("Add Project: " + addProject.project.Name);
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    Program.Log("Error: " + ex.Message);
                }
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (!Checks())
                return;
            var addTask = new AddTask();


            if (addTask.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    command.CommandText = "INSERT INTO Tasks ('IdUser','IdProject', 'Type', 'Priority', 'Description') values('" +
                        addTask.task.User.Number + "' , '" + addTask.task.Project.Number + "' , '" + addTask.task.Type + "' , '" +
                        addTask.task.Priority + "' , '" + addTask.task.Description + "')";
                    command.ExecuteNonQuery();
                    RefreshTasks();
                    Program.Log("Add Task for user:"+ addTask.task.User.Name+" in project "+ addTask.task.Project.Name);
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    Program.Log("Error: " + ex.Message);
                }
            }
        }

        private void btnDelTask_Click(object sender, EventArgs e)
        {
            if (!Checks())
                return;
            if (listViewTasks.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select Task in Tasks List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (MessageBox.Show("Are you sure?", "Delete task", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    Task deletingTask = (Task)(listViewTasks.FocusedItem.Tag);
                    command.CommandText = "DELETE FROM Tasks WHERE Id = '" + deletingTask.Number + "';";

                    command.ExecuteNonQuery();
                    Program.Log("Delete Task for user:" + deletingTask.User.Name + " in project " + deletingTask.Project.Name);
                    RefreshTasks();
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    Program.Log("Error: " + ex.Message);
                }
            }
            return;

        }

        private void btnDelProject_Click(object sender, EventArgs e)
        {
            if (!Checks())
                return;
            if (listViewProjects.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select Project in Projects List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Project deletingProject = (Project)(listViewProjects.FocusedItem.Tag);
            DataTable dTable = new DataTable();
            try
            {
                String sqlQuery;
                sqlQuery = "SELECT COUNT(IdProject) FROM Tasks WHERE IdProject = '" + deletingProject.Number + "';";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, connection);
                adapter.Fill(dTable);
                int NumTaskOfProject = 0;
                foreach (DataRow row in dTable.Rows)
                {
                    NumTaskOfProject += Convert.ToInt32(row["COUNT(IdProject)"].ToString());

                }

                if (NumTaskOfProject > 0)
                {
                    MessageBox.Show(deletingProject.Name+" having task(s)", "Can't delete this project", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Program.Log("Error: " + ex.Message);
            }


            if (MessageBox.Show("Are you sure?", "Delete project"+deletingProject.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    command.CommandText = "DELETE FROM Projects WHERE Id = '" + deletingProject.Number + "';";
                    command.ExecuteNonQuery();
                    RefreshProjects();
                    Program.Log("Delete Project:" + deletingProject.Name);
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    Program.Log("Error: " + ex.Message);
                }


            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (!Checks())
                return;
            if (listViewUsers.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select User in Users List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User deletingUser = (User)(listViewUsers.FocusedItem.Tag);
            DataTable dTable = new DataTable();
            try
            {
                String sqlQuery;
                sqlQuery = "SELECT COUNT(IdUser) FROM Tasks WHERE IdUser = '" + deletingUser.Number + "';";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, connection);
                adapter.Fill(dTable);
                int NumTaskOfUser = 0;
                foreach (DataRow row in dTable.Rows)
                {
                    NumTaskOfUser += Convert.ToInt32(row["COUNT(IdUser)"].ToString());

                }

                if (NumTaskOfUser > 0)
                {
                    MessageBox.Show(deletingUser.Name + " having task(s)", "Can't delete this project", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }



            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Program.Log("Error: " + ex.Message);
            }


            if (MessageBox.Show("Are you sure?", "Delete project" + deletingUser.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    command.CommandText = "DELETE FROM Users WHERE Id = '" + deletingUser.Number + "';";
                    command.ExecuteNonQuery();
                    RefreshUsers();
                    Program.Log("Delete User:" + deletingUser.Name);
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    Program.Log("Error: " + ex.Message);
                }


            }



        }

        private void btnViewUserTask_Click(object sender, EventArgs e)
        {
            if (!Checks())
                return;
            if (listViewUsers.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select User in Users List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataTable dTable = new DataTable();
            String sqlQuery;
            User selectedUser = (User)(listViewUsers.FocusedItem.Tag);

            try
            {
                listViewTasks.Items.Clear();
                sqlQuery = "SELECT Tasks.Id, Tasks.IdUser, Tasks.IdProject, Tasks.Type, Tasks.Priority, Tasks.Description, Users.Name AS Username, Projects.Name AS Projectname FROM Tasks " +
                    "INNER JOIN Users ON Tasks.IdUser = Users.Id   INNER JOIN Projects ON Tasks.IdProject = Projects.Id WHERE Tasks.IdUser ='"+ selectedUser.Number + "';";

                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, connection);
                adapter.Fill(dTable);
                foreach (DataRow row in dTable.Rows)
                {
                    ListViewItem i = new ListViewItem();
                    User user = new User
                    {
                        Name = row["Username"].ToString(),
                        Number = Convert.ToInt32(row["IdUser"].ToString())
                    };

                    Project project = new Project
                    {
                        Name = row["Projectname"].ToString(),
                        Number = Convert.ToInt32(row["IdProject"].ToString())
                    };

                    i.Tag = new Task
                    {
                        User = user,
                        Project = project,
                        Number = Convert.ToInt32(row["Id"].ToString()),
                        Type = row["Type"].ToString(),
                        Priority = row["Priority"].ToString(),
                        Description = row["Description"].ToString()
                    };
                    i.Text = row["Username"].ToString();
                    i.SubItems.Add(row["Projectname"].ToString());
                    i.SubItems.Add(row["Type"].ToString());
                    i.SubItems.Add(row["Priority"].ToString());
                    i.SubItems.Add(row["Description"].ToString());
                    listViewTasks.Items.Add(i);
                }


            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void btnViewProjectTask_Click(object sender, EventArgs e)
        {
            if (!Checks())
                return;
            if (listViewProjects.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select Project in Projects List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataTable dTable = new DataTable();
            String sqlQuery;
            Project selectedProject = (Project)(listViewProjects.FocusedItem.Tag);
            try
            {
                listViewTasks.Items.Clear();
                sqlQuery = "SELECT Tasks.Id, Tasks.IdUser, Tasks.IdProject, Tasks.Type, Tasks.Priority, Tasks.Description, Users.Name AS Username, Projects.Name AS Projectname FROM Tasks " +
                    "INNER JOIN Users ON Tasks.IdUser = Users.Id   INNER JOIN Projects ON Tasks.IdProject = Projects.Id WHERE Tasks.IdProject ='" + selectedProject.Number + "';";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, connection);
                adapter.Fill(dTable);
                foreach (DataRow row in dTable.Rows)
                {
                    ListViewItem i = new ListViewItem();
                    User user = new User
                    {
                        Name = row["Username"].ToString(),
                        Number = Convert.ToInt32(row["IdUser"].ToString())
                    };

                    Project project = new Project
                    {
                        Name = row["Projectname"].ToString(),
                        Number = Convert.ToInt32(row["IdProject"].ToString())
                    };

                    i.Tag = new Task
                    {
                        User = user,
                        Project = project,
                        Number = Convert.ToInt32(row["Id"].ToString()),
                        Type = row["Type"].ToString(),
                        Priority = row["Priority"].ToString(),
                        Description = row["Description"].ToString()
                    };
                    i.Text = row["Username"].ToString();
                    i.SubItems.Add(row["Projectname"].ToString());
                    i.SubItems.Add(row["Type"].ToString());
                    i.SubItems.Add(row["Priority"].ToString());
                    i.SubItems.Add(row["Description"].ToString());
                    listViewTasks.Items.Add(i);
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnAllTasks_Click(object sender, EventArgs e)
        {
            RefreshTasks();
        }
    }
}
