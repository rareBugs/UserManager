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
using System.Windows.Forms;

namespace UserManager
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
            OpenWindowsManager.AddForm(this);
            PopulateAccountList();
        }
        private void ForgotPassword_Load(object sender, EventArgs e) { }

        public void PopulateAccountList(string filePath = "accountDetails.csv")
        {
            if (File.Exists(filePath))
            {
                try
                {
                    // Clear existing items in the listboxes to avoid dupes
                    listBoxUsername.Items.Clear();
                    listBoxPassword.Items.Clear();
                    listBoxType.Items.Clear();

                    // To read user details from the CSV file
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        while (!sr.EndOfStream)
                        {
                            // Read a line from the CSV file
                            string line = sr.ReadLine();

                            // Split the line into username, password, and type
                            string[] parts = line.Split(',');

                            // Add the details to the listboxes
                            listBoxUsername.Items.Add(parts[0]);
                            listBoxPassword.Items.Add(parts[1]);
                            listBoxType.Items.Add(parts[2]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading user details: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("No user details file found.");
            }
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            // Check if an item is selected in any of the list boxes
            if (listBoxUsername.SelectedIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected user?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Get the selected index
                    int selectedIndex = listBoxUsername.SelectedIndex;

                    // Remove the corresponding row from the CSV file
                    RemoveRowFromCSV(selectedIndex);

                    // Refresh
                    PopulateAccountList();
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.");
            }
        }

        private void RemoveRowFromCSV(int rowIndex, string filePath = "accountDetails.csv")
        {
            if (File.Exists(filePath))
            {
                try
                {
                    // Read all lines from the CSV file
                    var lines = File.ReadAllLines(filePath).ToList();

                    // Remove the selected row
                    lines.RemoveAt(rowIndex);

                    // Write the updated lines back to the CSV file
                    File.WriteAllLines(filePath, lines);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting user: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("No user details file found.");
            }
        }


        private void buttonLoadCSV_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
            openFileDialog.Title = "Select a CSV File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                PopulateAccountList(selectedFilePath);
                MessageBox.Show($"User list loaded from: {selectedFilePath}");
            }
        }


        // Corresponding selectors
        private void ListBoxUsername_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox_SelectedIndexChanged(sender, e, listBoxUsername, listBoxPassword, listBoxType);
        }

        private void ListBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox_SelectedIndexChanged(sender, e, listBoxType, listBoxUsername, listBoxPassword);
        }

        private void ListBoxPassword_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox_SelectedIndexChanged(sender, e, listBoxPassword, listBoxUsername, listBoxType);
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e, ListBox sourceListBox, ListBox targetListBox1, ListBox targetListBox2)
        {
            int selectedIndex = sourceListBox.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < targetListBox1.Items.Count)
            {
                targetListBox1.SelectedIndex = selectedIndex;
                targetListBox2.SelectedIndex = selectedIndex;
            }
        }


        // Exit buttons
        private void buttonCloseForgotPassword_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void buttonExitAll_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye!");
            OpenWindowsManager.CloseAllForms();
        }
    }
}
