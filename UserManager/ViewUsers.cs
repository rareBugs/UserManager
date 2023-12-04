using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace UserManager
{
    public partial class ViewUser : Form
    {
        public ViewUser()
        {
            InitializeComponent();
            OpenWindowsManager.AddForm(this);
        }

        private void ViewUsers_Load(object sender, EventArgs e)
        {
            PopulateListBoxes();
        }


        private void PopulateListBoxes()
        {
            // Clear existing items
            listBoxViewName.Items.Clear();
            listBoxViewDepartment.Items.Clear();
            listBoxViewRole.Items.Clear();

            // Populate list boxes with user data
            foreach (var user in Worker.UsersList)
            {
                listBoxViewName.Items.Add(user.Username);
                listBoxViewDepartment.Items.Add(user.Department);
                listBoxViewRole.Items.Add(user.Role);
            }
        }

        private void listBoxViewName_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBoxSelections(listBoxViewName.SelectedIndex);
        }

        private void listBoxViewDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBoxSelections(listBoxViewDepartment.SelectedIndex);
        }

        private void listBoxViewRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBoxSelections(listBoxViewRole.SelectedIndex);
        }

        private void UpdateListBoxSelections(int selectedIndex)
        {
            // Check if an item is selected
            if (selectedIndex >= 0 && selectedIndex < Worker.UsersList.Count)
            {
                // Get the corresponding User
                Worker selectedUser = Worker.UsersList[selectedIndex];

                // Update the selected items in other list boxes
                listBoxViewName.SelectedIndex = selectedIndex;
                listBoxViewDepartment.SelectedIndex = selectedIndex;
                listBoxViewRole.SelectedIndex = selectedIndex;
            }
        }

        private void buttonSaveList_Click(object sender, EventArgs e)
        {

            // Show a SaveFileDialog to choose the file location
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON Files (*.json)|*.json";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                Worker.SaveUserData(filePath);
                MessageBox.Show("User data saved to file: " + filePath);
            }
        }


        // Exit buttons
        private void buttonViewUserClose_Click(object sender, EventArgs e)
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