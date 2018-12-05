using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace BugTrackingSystem
{
    public partial class AddTask : Form
    {
        SQLiteConnection connection = MainForm.connection;
        public AddTask()
        {
            InitializeComponent();
            
            
            if (!Checks())
                return;
            DataTable dTable = new DataTable();
            String sqlQuery;

            try
            {
                comboBoxUserName.Items.Clear();
                
                sqlQuery = "SELECT * FROM Users";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, connection);
                adapter.Fill(dTable);

                foreach (DataRow row in dTable.Rows)
                {
                   User user = new User { Name = row["Name"].ToString(), Number = Convert.ToInt32(row["Id"].ToString()) };
                    comboBoxUserName.Items.Add(user);
                }
                comboBoxProjectName.Items.Clear();
                dTable.Clear();
                sqlQuery = "SELECT * FROM Projects";
                adapter = new SQLiteDataAdapter(sqlQuery, connection);
                adapter.Fill(dTable);

                foreach (DataRow row in dTable.Rows)
                {
                    Project project = new Project { Name = row["Name"].ToString(), Number = Convert.ToInt32(row["Id"].ToString()), Description = row["Description"].ToString() };
                    comboBoxProjectName.Items.Add(project);
                }

            }

            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Program.Log("Error: " + ex.Message);
            }
            
        }
        
        



        public Task task { set; get; }


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

        private void btnAddTaskOk_Click(object sender, EventArgs e)
        {
            if (comboBoxUserName.SelectedItem == null)
            {
                MessageBox.Show("You dont select user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (comboBoxProjectName.SelectedItem == null)
            {
                MessageBox.Show("You dont select project", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            task = new Task()
            {
                User = (User)comboBoxUserName.SelectedItem,
                Project = (Project)comboBoxProjectName.SelectedItem,
                Priority = textBoxTaskPriority.Text,
                Type = textBoxTaskType.Text,
                Description = textBoxTaskDescription.Text
            };

            this.DialogResult = DialogResult.OK;
        }
    }
}
