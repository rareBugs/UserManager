namespace UserManager
{
    partial class ForgotPassword
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
            buttonDeleteUser = new Button();
            buttonExitAll = new Button();
            buttonCloseForgotPassword = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listBoxUsername = new ListBox();
            listBoxPassword = new ListBox();
            listBoxType = new ListBox();
            buttonLoadCSV = new Button();
            SuspendLayout();
            // 
            // buttonDeleteUser
            // 
            buttonDeleteUser.ForeColor = Color.Red;
            buttonDeleteUser.Location = new Point(390, 59);
            buttonDeleteUser.Name = "buttonDeleteUser";
            buttonDeleteUser.Size = new Size(85, 23);
            buttonDeleteUser.TabIndex = 3;
            buttonDeleteUser.Text = "Delete";
            buttonDeleteUser.UseVisualStyleBackColor = true;
            buttonDeleteUser.Click += buttonDeleteUser_Click;
            // 
            // buttonExitAll
            // 
            buttonExitAll.BackColor = SystemColors.Control;
            buttonExitAll.ForeColor = Color.Red;
            buttonExitAll.Location = new Point(392, 230);
            buttonExitAll.Name = "buttonExitAll";
            buttonExitAll.Size = new Size(85, 28);
            buttonExitAll.TabIndex = 12;
            buttonExitAll.Text = "Exit program";
            buttonExitAll.UseVisualStyleBackColor = false;
            buttonExitAll.Click += buttonExitAll_Click;
            // 
            // buttonCloseForgotPassword
            // 
            buttonCloseForgotPassword.Location = new Point(392, 201);
            buttonCloseForgotPassword.Name = "buttonCloseForgotPassword";
            buttonCloseForgotPassword.Size = new Size(85, 23);
            buttonCloseForgotPassword.TabIndex = 13;
            buttonCloseForgotPassword.Text = "Close";
            buttonCloseForgotPassword.UseVisualStyleBackColor = true;
            buttonCloseForgotPassword.Click += buttonCloseForgotPassword_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 38);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 14;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 38);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 15;
            label2.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(264, 38);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 16;
            label3.Text = "Account type";
            // 
            // listBoxUsername
            // 
            listBoxUsername.FormattingEnabled = true;
            listBoxUsername.ItemHeight = 15;
            listBoxUsername.Location = new Point(12, 59);
            listBoxUsername.Name = "listBoxUsername";
            listBoxUsername.Size = new Size(120, 199);
            listBoxUsername.TabIndex = 17;
            listBoxUsername.SelectedIndexChanged += ListBoxUsername_SelectedIndexChanged;
            // 
            // listBoxPassword
            // 
            listBoxPassword.FormattingEnabled = true;
            listBoxPassword.ItemHeight = 15;
            listBoxPassword.Location = new Point(138, 59);
            listBoxPassword.Name = "listBoxPassword";
            listBoxPassword.Size = new Size(120, 199);
            listBoxPassword.TabIndex = 18;
            listBoxPassword.SelectedIndexChanged += ListBoxPassword_SelectedIndexChanged;
            // 
            // listBoxType
            // 
            listBoxType.FormattingEnabled = true;
            listBoxType.ItemHeight = 15;
            listBoxType.Location = new Point(264, 59);
            listBoxType.Name = "listBoxType";
            listBoxType.Size = new Size(120, 199);
            listBoxType.TabIndex = 19;
            listBoxType.SelectedIndexChanged += ListBoxType_SelectedIndexChanged;
            // 
            // buttonLoadCSV
            // 
            buttonLoadCSV.Location = new Point(12, 12);
            buttonLoadCSV.Name = "buttonLoadCSV";
            buttonLoadCSV.Size = new Size(120, 23);
            buttonLoadCSV.TabIndex = 20;
            buttonLoadCSV.Text = "Load another CSV";
            buttonLoadCSV.UseVisualStyleBackColor = true;
            buttonLoadCSV.Click += buttonLoadCSV_Click;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 278);
            Controls.Add(buttonLoadCSV);
            Controls.Add(listBoxType);
            Controls.Add(listBoxPassword);
            Controls.Add(listBoxUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonCloseForgotPassword);
            Controls.Add(buttonExitAll);
            Controls.Add(buttonDeleteUser);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ForgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Forgot password";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonDeleteUser;
        private Button buttonExitAll;
        private Button buttonCloseForgotPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox listBoxUsername;
        private ListBox listBoxPassword;
        private ListBox listBoxType;
        private Button buttonLoadCSV;
    }
}