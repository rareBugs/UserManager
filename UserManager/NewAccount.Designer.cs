namespace UserManager
{
    partial class NewAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            buttonCreateTesterAccount = new Button();
            checkBoxAdministratorAccount = new CheckBox();
            checkBoxEmployeeAccount = new CheckBox();
            buttonCloseNewAccount = new Button();
            buttonExitAll = new Button();
            textBoxDesiredUsername = new TextBox();
            textBoxDesiredPassword = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 2;
            label1.Text = "Desired username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 67);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 3;
            label2.Text = "Desired password";
            // 
            // buttonCreateTesterAccount
            // 
            buttonCreateTesterAccount.Location = new Point(119, 143);
            buttonCreateTesterAccount.Name = "buttonCreateTesterAccount";
            buttonCreateTesterAccount.Size = new Size(100, 23);
            buttonCreateTesterAccount.TabIndex = 4;
            buttonCreateTesterAccount.Text = "Create account";
            buttonCreateTesterAccount.UseVisualStyleBackColor = true;
            buttonCreateTesterAccount.Click += buttonCreateTesterAccount_Click;
            // 
            // checkBoxAdministratorAccount
            // 
            checkBoxAdministratorAccount.AutoSize = true;
            checkBoxAdministratorAccount.Location = new Point(120, 93);
            checkBoxAdministratorAccount.Name = "checkBoxAdministratorAccount";
            checkBoxAdministratorAccount.Size = new Size(99, 19);
            checkBoxAdministratorAccount.TabIndex = 5;
            checkBoxAdministratorAccount.Text = "Administrator";
            checkBoxAdministratorAccount.UseVisualStyleBackColor = true;
            checkBoxAdministratorAccount.CheckedChanged += checkBoxAdministratorAccount_CheckedChanged;
            // 
            // checkBoxEmployeeAccount
            // 
            checkBoxEmployeeAccount.AutoSize = true;
            checkBoxEmployeeAccount.Location = new Point(120, 118);
            checkBoxEmployeeAccount.Name = "checkBoxEmployeeAccount";
            checkBoxEmployeeAccount.Size = new Size(78, 19);
            checkBoxEmployeeAccount.TabIndex = 6;
            checkBoxEmployeeAccount.Text = "Employee";
            checkBoxEmployeeAccount.UseVisualStyleBackColor = true;
            checkBoxEmployeeAccount.CheckedChanged += checkBoxEmployeeAccount_CheckedChanged;
            // 
            // buttonCloseNewAccount
            // 
            buttonCloseNewAccount.Location = new Point(100, 193);
            buttonCloseNewAccount.Name = "buttonCloseNewAccount";
            buttonCloseNewAccount.Size = new Size(85, 23);
            buttonCloseNewAccount.TabIndex = 7;
            buttonCloseNewAccount.Text = "Cancel";
            buttonCloseNewAccount.UseVisualStyleBackColor = true;
            buttonCloseNewAccount.Click += buttonCloseNewAccount_Click;
            // 
            // buttonExitAll
            // 
            buttonExitAll.BackColor = SystemColors.Control;
            buttonExitAll.ForeColor = Color.Red;
            buttonExitAll.Location = new Point(100, 222);
            buttonExitAll.Name = "buttonExitAll";
            buttonExitAll.Size = new Size(85, 28);
            buttonExitAll.TabIndex = 13;
            buttonExitAll.Text = "Exit program";
            buttonExitAll.UseVisualStyleBackColor = false;
            buttonExitAll.Click += buttonExitAll_Click;
            // 
            // textBoxDesiredUsername
            // 
            textBoxDesiredUsername.Location = new Point(119, 35);
            textBoxDesiredUsername.Name = "textBoxDesiredUsername";
            textBoxDesiredUsername.Size = new Size(100, 23);
            textBoxDesiredUsername.TabIndex = 14;
            // 
            // textBoxDesiredPassword
            // 
            textBoxDesiredPassword.Location = new Point(119, 64);
            textBoxDesiredPassword.Name = "textBoxDesiredPassword";
            textBoxDesiredPassword.Size = new Size(100, 23);
            textBoxDesiredPassword.TabIndex = 15;
            // 
            // NewAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 276);
            Controls.Add(textBoxDesiredPassword);
            Controls.Add(textBoxDesiredUsername);
            Controls.Add(buttonExitAll);
            Controls.Add(buttonCloseNewAccount);
            Controls.Add(checkBoxEmployeeAccount);
            Controls.Add(checkBoxAdministratorAccount);
            Controls.Add(buttonCreateTesterAccount);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "NewAccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create new account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button buttonCreateTesterAccount;
        private CheckBox checkBoxAdministratorAccount;
        private CheckBox checkBoxEmployeeAccount;
        private Button buttonCloseNewAccount;
        private Button buttonExitAll;
        private TextBox textBoxDesiredUsername;
        private TextBox textBoxDesiredPassword;
    }
}