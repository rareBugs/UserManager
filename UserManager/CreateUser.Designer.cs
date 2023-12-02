namespace UserManager
{
    partial class CreateUser
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
            textBoxNewName = new TextBox();
            textBoxNewDepartment = new TextBox();
            textBoxNewRole = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonCreate = new Button();
            buttonExitAll = new Button();
            buttonCloseCreateUser = new Button();
            SuspendLayout();
            // 
            // textBoxNewName
            // 
            textBoxNewName.Location = new Point(112, 50);
            textBoxNewName.Name = "textBoxNewName";
            textBoxNewName.Size = new Size(123, 23);
            textBoxNewName.TabIndex = 0;
            // 
            // textBoxNewDepartment
            // 
            textBoxNewDepartment.Location = new Point(112, 79);
            textBoxNewDepartment.Name = "textBoxNewDepartment";
            textBoxNewDepartment.Size = new Size(123, 23);
            textBoxNewDepartment.TabIndex = 1;
            // 
            // textBoxNewRole
            // 
            textBoxNewRole.Location = new Point(112, 108);
            textBoxNewRole.Name = "textBoxNewRole";
            textBoxNewRole.Size = new Size(123, 23);
            textBoxNewRole.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 53);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 82);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 4;
            label2.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 111);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 5;
            label3.Text = "Role";
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(138, 149);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(75, 23);
            buttonCreate.TabIndex = 6;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonExitAll
            // 
            buttonExitAll.BackColor = SystemColors.Control;
            buttonExitAll.ForeColor = Color.Red;
            buttonExitAll.Location = new Point(112, 217);
            buttonExitAll.Name = "buttonExitAll";
            buttonExitAll.Size = new Size(123, 28);
            buttonExitAll.TabIndex = 8;
            buttonExitAll.Text = "Exit program";
            buttonExitAll.UseVisualStyleBackColor = false;
            buttonExitAll.Click += buttonExitAll_Click;
            // 
            // buttonCloseCreateUser
            // 
            buttonCloseCreateUser.Location = new Point(138, 178);
            buttonCloseCreateUser.Name = "buttonCloseCreateUser";
            buttonCloseCreateUser.Size = new Size(75, 23);
            buttonCloseCreateUser.TabIndex = 9;
            buttonCloseCreateUser.Text = "Done";
            buttonCloseCreateUser.UseVisualStyleBackColor = true;
            buttonCloseCreateUser.Click += buttonCloseCreateUser_Click;
            // 
            // CreateUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 315);
            Controls.Add(buttonCloseCreateUser);
            Controls.Add(buttonExitAll);
            Controls.Add(buttonCreate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxNewRole);
            Controls.Add(textBoxNewDepartment);
            Controls.Add(textBoxNewName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CreateUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create user";
            Load += CreateUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNewName;
        private TextBox textBoxNewDepartment;
        private TextBox textBoxNewRole;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonCreate;
        private Button buttonExitAll;
        private Button buttonCloseCreateUser;
    }
}