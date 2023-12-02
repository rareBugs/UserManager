using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace UserManager
{
    public partial class AdminControl : Form
    {
        public AdminControl()
        {
            InitializeComponent();
            OpenWindowsManager.AddForm(this);
        }

        private void AdminControl_Load(object sender, EventArgs e)
        {   
            //Labels that were supposed to be implemented, never got around to finish
            // was supposed to show when a butten was pressed to disable the other windows 
            // to avoid multiple instances of a window
            createUserWindowOpen.Visible = false;
            viewUsersWindowOpen.Visible = false;
            editUsersWindowOpen.Visible = false;
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            //since I never got around to separating access modifiers
            //for different account types, I'm hiding this button
            //Download button still exist on ViewUsers form...
            Visible = true; 
            
            // Show a SaveFileDialog to choose the file location
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON Files (*.json)|*.json";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                User.SaveUserData(filePath);
                MessageBox.Show("User data saved to file: " + filePath);
            }
        }

        private void buttonLoadFile_Click(object sender, EventArgs e)
        {
            // Show an OpenFileDialog to choose the file to load
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON Files (*.json)|*.json";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                User.LoadUserData(filePath);
                MessageBox.Show("User data loaded from file: " + filePath);
            }
        }

        // ----- Buttons handlers below -----
        private void buttonViewUsers_Click(object sender, EventArgs e)
        {
            ViewUser viewUsersForm = new ViewUser();
            viewUsersForm.Show();
        }

        private void buttonEditUsers_Click(object sender, EventArgs e)
        {
            EditUser editUserForm = new EditUser();
            editUserForm.Show();
        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            CreateUser createUserForm = new CreateUser();
            createUserForm.Show();
        }


        // Logout and close buttons below
        private void buttonCloseAdminControl_Click(object sender, EventArgs e)
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
