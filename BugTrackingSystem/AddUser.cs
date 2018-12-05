using System;
using System.Windows.Forms;

namespace BugTrackingSystem
{
    public partial class AddUser : Form
    {

        public AddUser()
        {
            InitializeComponent();
        }
        public User user { get; set; }

        private void btnAddUserOk_Click(object sender, EventArgs e)
        {
            user = new User
            {
                Name = textBoxUser.Text
            };
            this.DialogResult = DialogResult.OK;
        }
    }
}
