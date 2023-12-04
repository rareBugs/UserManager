namespace UserManager
{
    partial class AdminLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBoxUsername = new TextBox();
            textBoxPassword = new TextBox();
            label2 = new Label();
            buttonLogin = new Button();
            buttonCreateAccount = new Button();
            buttonForgotPassword = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 30);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(106, 27);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(100, 23);
            textBoxUsername.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(106, 56);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(100, 23);
            textBoxPassword.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 59);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(40, 85);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(166, 49);
            buttonLogin.TabIndex = 4;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonCreateAccount
            // 
            buttonCreateAccount.Location = new Point(40, 185);
            buttonCreateAccount.Name = "buttonCreateAccount";
            buttonCreateAccount.Size = new Size(166, 23);
            buttonCreateAccount.TabIndex = 5;
            buttonCreateAccount.Text = "Create account";
            buttonCreateAccount.UseVisualStyleBackColor = true;
            buttonCreateAccount.Click += buttonCreateAccount_Click;
            // 
            // buttonForgotPassword
            // 
            buttonForgotPassword.Location = new Point(40, 214);
            buttonForgotPassword.Name = "buttonForgotPassword";
            buttonForgotPassword.Size = new Size(166, 23);
            buttonForgotPassword.TabIndex = 6;
            buttonForgotPassword.Text = "Forgot password";
            buttonForgotPassword.UseVisualStyleBackColor = true;
            buttonForgotPassword.Click += buttonForgotPassword_Click;
            // 
            // button1
            // 
            button1.ForeColor = Color.Red;
            button1.Location = new Point(85, 140);
            button1.Name = "button1";
            button1.Size = new Size(75, 26);
            button1.TabIndex = 7;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AdminLogin
            // 
            AcceptButton = buttonLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 249);
            Controls.Add(button1);
            Controls.Add(buttonForgotPassword);
            Controls.Add(buttonCreateAccount);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(label2);
            Controls.Add(textBoxUsername);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AdminLogin";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxUsername;
        private TextBox textBoxPassword;
        private Label label2;
        private Button buttonLogin;
        private Button buttonCreateAccount;
        private Button buttonForgotPassword;
        private Button button1;
    }
}