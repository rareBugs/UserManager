using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserManager
{
    public partial class EditUser : Form
    {
        public EditUser()
        {
            InitializeComponent();
            OpenWindowsManager.AddForm(this);
        }

        private void buttonExitAll_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Good bye!");
            OpenWindowsManager.CloseAllForms();
        }

        private void buttonViewUserClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            // Clear existing items to avoid dupes
            listBoxNameEditor.Items.Clear();
            listBoxDepartmentEditor.Items.Clear();
            listBoxRoleEditor.Items.Clear();

            foreach (var user in Worker.UsersList)
            {
                listBoxNameEditor.Items.Add(user.Username);
                listBoxDepartmentEditor.Items.Add(user.Department);
                listBoxRoleEditor.Items.Add(user.Role);
            }
        }

        private void listBoxViewName_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBoxSelections(listBoxNameEditor.SelectedIndex);
        }

        private void listBoxViewDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBoxSelections(listBoxDepartmentEditor.SelectedIndex);
        }

        private void listBoxViewRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBoxSelections(listBoxRoleEditor.SelectedIndex);
        }

        private void UpdateListBoxSelections(int selectedIndex)
        {
            if (selectedIndex >= 0 && selectedIndex < Worker.UsersList.Count)
            {
                Worker selectedUser = Worker.UsersList[selectedIndex];

                listBoxNameEditor.SelectedIndex = selectedIndex;
                listBoxDepartmentEditor.SelectedIndex = selectedIndex;
                listBoxRoleEditor.SelectedIndex = selectedIndex;
            }
        }

        private void buttonDeleteSelected_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxNameEditor.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < Worker.UsersList.Count)
            {
                Worker.UsersList.RemoveAt(selectedIndex);

                listBoxNameEditor.Items.Clear();
                listBoxDepartmentEditor.Items.Clear();
                listBoxRoleEditor.Items.Clear();

                textBoxNameEdit.Clear();
                textBoxDepartmentEdit.Clear();
                textBoxRoleEdit.Clear();


                foreach (var user in Worker.UsersList)
                {
                    listBoxNameEditor.Items.Add(user.Username);
                    listBoxDepartmentEditor.Items.Add(user.Department);
                    listBoxRoleEditor.Items.Add(user.Role);
                }
            }
        }

        private void buttonEditSelected_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxNameEditor.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < Worker.UsersList.Count)
            {
                Worker selectedUser = Worker.UsersList[selectedIndex];

                // Load user details into textboxes for editing
                textBoxNameEdit.Text = selectedUser.Username;
                textBoxDepartmentEdit.Text = selectedUser.Department;
                textBoxRoleEdit.Text = selectedUser.Role;
            }
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBoxNameEditor.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < Worker.UsersList.Count)
            {
                // Update user details from textboxes
                Worker.UsersList[selectedIndex].Username = textBoxNameEdit.Text;
                Worker.UsersList[selectedIndex].Department = textBoxDepartmentEdit.Text;
                Worker.UsersList[selectedIndex].Role = textBoxRoleEdit.Text;

                // Clear and repopulate listboxes
                listBoxNameEditor.Items.Clear();
                listBoxDepartmentEditor.Items.Clear();
                listBoxRoleEditor.Items.Clear();

                foreach (var user in Worker.UsersList)
                {
                    listBoxNameEditor.Items.Add(user.Username);
                    listBoxDepartmentEditor.Items.Add(user.Department);
                    listBoxRoleEditor.Items.Add(user.Role);
                }

                // Clear the textboxes after saving changes
                textBoxNameEdit.Clear();
                textBoxDepartmentEdit.Clear();
                textBoxRoleEdit.Clear();
            }
        }
    }
}
