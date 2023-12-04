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

namespace UserManager
{
    public partial class NewAccount : Form
    {
        public NewAccount()
        {
            InitializeComponent();
            OpenWindowsManager.AddForm(this);
        }



        private void checkBoxAdministratorAccount_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAdministratorAccount.Checked)
            {
                checkBoxEmployeeAccount.Checked = false;
                checkBoxEmployeeAccount.Enabled = false;
            }
            else
            {
                checkBoxEmployeeAccount.Enabled = true;
            }
        }

        private void checkBoxEmployeeAccount_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEmployeeAccount.Checked)
            {
                checkBoxAdministratorAccount.Checked = false;
                checkBoxAdministratorAccount.Enabled = false;
            }
            else
            {
                checkBoxAdministratorAccount.Enabled = true;
            }
        }


        private void buttonCreateTesterAccount_Click(object sender, EventArgs e)
        {
            {
                string username = textBoxDesiredUsername.Text;
                string password = textBoxDesiredPassword.Text;
                string type = checkBoxAdministratorAccount.Checked ? "Administrator" : "Employee";
                
                if (!checkBoxEmployeeAccount.Checked || !checkBoxAdministratorAccount.Checked)
                {
                    MessageBox.Show("Must select account type.");
                    return;
                }
                // Create a new Account object
                Account newAccount = new Account(username, password, type);

                // Add the new account to the accountsList
                Account.AddAccount(newAccount);

                // Save the details permanently to a CSV file
                SaveAccountDetailsToCSV(newAccount);

                MessageBox.Show("Account created successfully!");
                this.Close();
            }
        }
        private void SaveAccountDetailsToCSV(Account account)
        {
            // Choose a file path for your CSV file
            string filePath = "accountDetails.csv";

            // Use StreamWriter to append the account details to the CSV file
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine($"{account.Username},{account.Password},{account.Type}");
            }
            // MessageBox.Show("User details saved to CSV file.");
        }


        private void NewAccount_Load(object sender, EventArgs e)
        {

        }

        private void NewAccount_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void buttonCloseNewAccount_Click(object sender, EventArgs e)
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