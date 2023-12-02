namespace UserManager
{
    partial class AdminControl
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
            buttonViewUsers = new Button();
            buttonEditUsers = new Button();
            buttonCreateUser = new Button();
            buttonCloseAdminControl = new Button();
            buttonExitAll = new Button();
            createUserWindowOpen = new Label();
            viewUsersWindowOpen = new Label();
            editUsersWindowOpen = new Label();
            buttonLoadFile = new Button();
            buttonSaveToFile = new Button();
            SuspendLayout();
            // 
            // buttonViewUsers
            // 
            buttonViewUsers.Location = new Point(124, 176);
            buttonViewUsers.Name = "buttonViewUsers";
            buttonViewUsers.Size = new Size(75, 59);
            buttonViewUsers.TabIndex = 4;
            buttonViewUsers.Text = "View users";
            buttonViewUsers.UseVisualStyleBackColor = true;
            buttonViewUsers.Click += buttonViewUsers_Click;
            // 
            // buttonEditUsers
            // 
            buttonEditUsers.Location = new Point(205, 176);
            buttonEditUsers.Name = "buttonEditUsers";
            buttonEditUsers.Size = new Size(75, 59);
            buttonEditUsers.TabIndex = 5;
            buttonEditUsers.Text = "Edit users";
            buttonEditUsers.UseVisualStyleBackColor = true;
            buttonEditUsers.Click += buttonEditUsers_Click;
            // 
            // buttonCreateUser
            // 
            buttonCreateUser.Location = new Point(43, 176);
            buttonCreateUser.Name = "buttonCreateUser";
            buttonCreateUser.Size = new Size(75, 59);
            buttonCreateUser.TabIndex = 3;
            buttonCreateUser.Text = "Create user";
            buttonCreateUser.UseVisualStyleBackColor = true;
            buttonCreateUser.Click += buttonCreateUser_Click;
            // 
            // buttonCloseAdminControl
            // 
            buttonCloseAdminControl.Location = new Point(124, 286);
            buttonCloseAdminControl.Name = "buttonCloseAdminControl";
            buttonCloseAdminControl.Size = new Size(75, 28);
            buttonCloseAdminControl.TabIndex = 6;
            buttonCloseAdminControl.Text = "Logout";
            buttonCloseAdminControl.UseVisualStyleBackColor = true;
            buttonCloseAdminControl.Click += buttonCloseAdminControl_Click;
            // 
            // buttonExitAll
            // 
            buttonExitAll.BackColor = SystemColors.Control;
            buttonExitAll.ForeColor = Color.Red;
            buttonExitAll.Location = new Point(114, 320);
            buttonExitAll.Name = "buttonExitAll";
            buttonExitAll.Size = new Size(97, 27);
            buttonExitAll.TabIndex = 7;
            buttonExitAll.Text = "Exit program";
            buttonExitAll.UseVisualStyleBackColor = false;
            buttonExitAll.Click += buttonExitAll_Click;
            // 
            // createUserWindowOpen
            // 
            createUserWindowOpen.AutoSize = true;
            createUserWindowOpen.ForeColor = Color.IndianRed;
            createUserWindowOpen.Location = new Point(22, 238);
            createUserWindowOpen.Name = "createUserWindowOpen";
            createUserWindowOpen.Size = new Size(280, 15);
            createUserWindowOpen.TabIndex = 3;
            createUserWindowOpen.Text = "Close \"Create User\" window to see another window.";
            // 
            // viewUsersWindowOpen
            // 
            viewUsersWindowOpen.AutoSize = true;
            viewUsersWindowOpen.ForeColor = Color.IndianRed;
            viewUsersWindowOpen.Location = new Point(22, 253);
            viewUsersWindowOpen.Name = "viewUsersWindowOpen";
            viewUsersWindowOpen.Size = new Size(276, 15);
            viewUsersWindowOpen.TabIndex = 4;
            viewUsersWindowOpen.Text = "Close \"View Users\" window to see another window.";
            // 
            // editUsersWindowOpen
            // 
            editUsersWindowOpen.AutoSize = true;
            editUsersWindowOpen.ForeColor = Color.IndianRed;
            editUsersWindowOpen.Location = new Point(22, 268);
            editUsersWindowOpen.Name = "editUsersWindowOpen";
            editUsersWindowOpen.Size = new Size(270, 15);
            editUsersWindowOpen.TabIndex = 5;
            editUsersWindowOpen.Text = "Close \"Edit users\" window to see another window.";
            // 
            // buttonLoadFile
            // 
            buttonLoadFile.Location = new Point(43, 26);
            buttonLoadFile.Name = "buttonLoadFile";
            buttonLoadFile.Size = new Size(237, 59);
            buttonLoadFile.TabIndex = 1;
            buttonLoadFile.Text = "Load file";
            buttonLoadFile.UseVisualStyleBackColor = true;
            buttonLoadFile.Click += buttonLoadFile_Click;
            // 
            // buttonSaveToFile
            // 
            buttonSaveToFile.Location = new Point(43, 91);
            buttonSaveToFile.Name = "buttonSaveToFile";
            buttonSaveToFile.Size = new Size(237, 59);
            buttonSaveToFile.TabIndex = 2;
            buttonSaveToFile.Text = "Save to file";
            buttonSaveToFile.UseVisualStyleBackColor = true;
            buttonSaveToFile.Click += buttonSaveToFile_Click;
            // 
            // AdminControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 356);
            Controls.Add(buttonSaveToFile);
            Controls.Add(buttonLoadFile);
            Controls.Add(editUsersWindowOpen);
            Controls.Add(viewUsersWindowOpen);
            Controls.Add(createUserWindowOpen);
            Controls.Add(buttonExitAll);
            Controls.Add(buttonCloseAdminControl);
            Controls.Add(buttonCreateUser);
            Controls.Add(buttonEditUsers);
            Controls.Add(buttonViewUsers);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AdminControl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin control";
            Load += AdminControl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonViewUsers;
        private Button buttonEditUsers;
        private Button buttonCreateUser;
        private Button buttonCloseAdminControl;
        private Button buttonExitAll;
        private Label createUserWindowOpen;
        private Label viewUsersWindowOpen;
        private Label editUsersWindowOpen;
        private Button buttonLoadFile;
        private Button buttonSaveToFile;
    }
}