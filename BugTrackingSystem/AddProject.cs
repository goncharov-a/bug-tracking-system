using System;
using System.Windows.Forms;

namespace BugTrackingSystem
{
    public partial class AddProject : Form
    {
        public AddProject()
        {
            InitializeComponent();
        }

        public Project project { get; set; }

        private void btnAddProjectOk_Click(object sender, EventArgs e)
        {
            project = new Project
            {
                Name = textBoxProject.Text,
                Description = textBoxProjectDescription.Text
            };
      

            this.DialogResult = DialogResult.OK;
        }
    }
    
}
