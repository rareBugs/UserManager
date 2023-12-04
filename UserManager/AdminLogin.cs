using System.Diagnostics;
using System.Linq;
using System.IO;

namespace UserManager
{
    public partial class AdminLogin : Form
    {
        // This is kind of like "Main", just for login and then we move on to the actual program.

        List<Account> accountList = new List<Account>();

        public AdminLogin()
        {
            InitializeComponent();
            OpenWindowsManager.AddForm(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string enteredUsername = textBoxUsername.Text;
            string enteredPassword = textBoxPassword.Text;

            // Verify the entered credentials
            if (VerifyUserCredentials(enteredUsername, enteredPassword, out string userType))
            {
                // If the credentials valid, open the AdminControl
                textBoxUsername.Clear(); textBoxPassword.Clear(); // clearing credentials
                textBoxUsername.Focus(); // focus moves back to username, ready for new login.
                AdminControl adminControlForm = new AdminControl(userType);
                adminControlForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private bool VerifyUserCredentials(string enteredUsername, string enteredPassword, out string userType)
        {
            // Load user accounts from the CSV file
            List<Account> accounts = LoadAccountsFromCSV("accountDetails.csv");

            userType = "";
            foreach (Account account in accounts)
            {
                if (account.Username == enteredUsername && account.Password == enteredPassword)
                {
                    userType = account.Type;
                    return true;
                }
            }
            // Check if the entered credentials match any stored account
            return accounts.Any(account => account.Username == enteredUsername && account.Password == enteredPassword);
        }
        
        private List<Account> LoadAccountsFromCSV(string filePath)
        {
            List<Account> accounts = new List<Account>();

            if (File.Exists(filePath))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            string[] parts = line.Split(',');

                            // Creates an Account-object for each line in the CSV
                            Account account = new Account(parts[0], parts[1], parts[2]);
                            accounts.Add(account);
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
            return accounts;
        }


        private void buttonCreateAccount_Click(object sender, EventArgs e)
        {
            NewAccount newAccountForm = new NewAccount();
            newAccountForm.SetList(accountList);
            newAccountForm.Show();
        }

        private void buttonForgotPassword_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPasswordForm = new ForgotPassword();
            forgotPasswordForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Goodbye!");
            OpenWindowsManager.CloseAllForms();
        }
    }
}