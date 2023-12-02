using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UserManager
{
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string name = textBoxNewName.Text;
            string department = textBoxNewDepartment.Text;
            string role = textBoxNewRole.Text;

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(department) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("User must have name, department and role.\nOtherwise they don't work here ;)");
                return;
            }

            User newUser = new User(name, department, role);
            User.AddUser(newUser);

            textBoxNewName.Clear();
            textBoxNewDepartment.Clear();
            textBoxNewRole.Clear();

            MessageBox.Show($"The following user has been added.\nUser: {name}\nDepartment: {department}\nRole: {role}");
        }


        // Exit buttons
        private void buttonCloseCreateUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonExitAll_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Good bye!");
            OpenWindowsManager.CloseAllForms();
        }
    }
}
