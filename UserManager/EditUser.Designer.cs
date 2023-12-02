namespace UserManager
{
    partial class EditUser
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
            listBoxNameEditor = new ListBox();
            listBoxDepartmentEditor = new ListBox();
            listBoxRoleEditor = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonExitAll = new Button();
            buttonViewUserClose = new Button();
            buttonEditSelected = new Button();
            buttonSaveChanges = new Button();
            textBoxNameEdit = new TextBox();
            textBoxDepartmentEdit = new TextBox();
            textBoxRoleEdit = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            buttonDeleteSelected = new Button();
            SuspendLayout();
            // 
            // listBoxNameEditor
            // 
            listBoxNameEditor.ItemHeight = 15;
            listBoxNameEditor.Location = new Point(12, 28);
            listBoxNameEditor.Name = "listBoxNameEditor";
            listBoxNameEditor.Size = new Size(146, 334);
            listBoxNameEditor.TabIndex = 1;
            listBoxNameEditor.SelectedIndexChanged += listBoxViewName_SelectedIndexChanged;
            // 
            // listBoxDepartmentEditor
            // 
            listBoxDepartmentEditor.ItemHeight = 15;
            listBoxDepartmentEditor.Location = new Point(164, 28);
            listBoxDepartmentEditor.Name = "listBoxDepartmentEditor";
            listBoxDepartmentEditor.Size = new Size(146, 334);
            listBoxDepartmentEditor.TabIndex = 2;
            listBoxDepartmentEditor.SelectedIndexChanged += listBoxViewDepartment_SelectedIndexChanged;
            // 
            // listBoxRoleEditor
            // 
            listBoxRoleEditor.ItemHeight = 15;
            listBoxRoleEditor.Location = new Point(316, 28);
            listBoxRoleEditor.Name = "listBoxRoleEditor";
            listBoxRoleEditor.Size = new Size(146, 334);
            listBoxRoleEditor.TabIndex = 3;
            listBoxRoleEditor.SelectedIndexChanged += listBoxViewRole_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 10);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 10);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 6;
            label2.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(316, 10);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 7;
            label3.Text = "Role";
            // 
            // buttonExitAll
            // 
            buttonExitAll.BackColor = SystemColors.Control;
            buttonExitAll.ForeColor = Color.Red;
            buttonExitAll.Location = new Point(513, 334);
            buttonExitAll.Name = "buttonExitAll";
            buttonExitAll.Size = new Size(107, 28);
            buttonExitAll.TabIndex = 8;
            buttonExitAll.Text = "Exit program";
            buttonExitAll.UseVisualStyleBackColor = false;
            buttonExitAll.Click += buttonExitAll_Click;
            // 
            // buttonViewUserClose
            // 
            buttonViewUserClose.Location = new Point(513, 305);
            buttonViewUserClose.Name = "buttonViewUserClose";
            buttonViewUserClose.Size = new Size(107, 23);
            buttonViewUserClose.TabIndex = 9;
            buttonViewUserClose.Text = "Close user editor";
            buttonViewUserClose.UseVisualStyleBackColor = true;
            buttonViewUserClose.Click += buttonViewUserClose_Click;
            // 
            // buttonEditSelected
            // 
            buttonEditSelected.Location = new Point(513, 28);
            buttonEditSelected.Name = "buttonEditSelected";
            buttonEditSelected.Size = new Size(114, 23);
            buttonEditSelected.TabIndex = 10;
            buttonEditSelected.Text = "Edit selected";
            buttonEditSelected.UseVisualStyleBackColor = true;
            buttonEditSelected.Click += buttonEditSelected_Click;
            // 
            // buttonSaveChanges
            // 
            buttonSaveChanges.ForeColor = Color.Red;
            buttonSaveChanges.Location = new Point(513, 206);
            buttonSaveChanges.Name = "buttonSaveChanges";
            buttonSaveChanges.Size = new Size(114, 23);
            buttonSaveChanges.TabIndex = 11;
            buttonSaveChanges.Text = "Save changes";
            buttonSaveChanges.UseVisualStyleBackColor = true;
            buttonSaveChanges.Click += buttonSaveChanges_Click;
            // 
            // textBoxNameEdit
            // 
            textBoxNameEdit.Location = new Point(513, 119);
            textBoxNameEdit.Name = "textBoxNameEdit";
            textBoxNameEdit.Size = new Size(114, 23);
            textBoxNameEdit.TabIndex = 12;
            // 
            // textBoxDepartmentEdit
            // 
            textBoxDepartmentEdit.Location = new Point(513, 148);
            textBoxDepartmentEdit.Name = "textBoxDepartmentEdit";
            textBoxDepartmentEdit.Size = new Size(114, 23);
            textBoxDepartmentEdit.TabIndex = 13;
            // 
            // textBoxRoleEdit
            // 
            textBoxRoleEdit.Location = new Point(513, 177);
            textBoxRoleEdit.Name = "textBoxRoleEdit";
            textBoxRoleEdit.Size = new Size(114, 23);
            textBoxRoleEdit.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(468, 122);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 15;
            label4.Text = "Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(468, 151);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 16;
            label5.Text = "Dep.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(468, 180);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 17;
            label6.Text = "Role";
            // 
            // buttonDeleteSelected
            // 
            buttonDeleteSelected.ForeColor = Color.Red;
            buttonDeleteSelected.Location = new Point(513, 57);
            buttonDeleteSelected.Name = "buttonDeleteSelected";
            buttonDeleteSelected.Size = new Size(114, 23);
            buttonDeleteSelected.TabIndex = 18;
            buttonDeleteSelected.Text = "Delete user";
            buttonDeleteSelected.UseVisualStyleBackColor = true;
            buttonDeleteSelected.Click += buttonDeleteSelected_Click;
            // 
            // EditUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 371);
            Controls.Add(buttonDeleteSelected);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBoxRoleEdit);
            Controls.Add(textBoxDepartmentEdit);
            Controls.Add(textBoxNameEdit);
            Controls.Add(buttonSaveChanges);
            Controls.Add(buttonEditSelected);
            Controls.Add(buttonViewUserClose);
            Controls.Add(buttonExitAll);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxRoleEditor);
            Controls.Add(listBoxDepartmentEditor);
            Controls.Add(listBoxNameEditor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "EditUser";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User editor";
            Load += EditUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxNameEditor;
        private ListBox listBoxDepartmentEditor;
        private ListBox listBoxRoleEditor;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonExitAll;
        private Button buttonViewUserClose;
        private Button buttonEditSelected;
        private Button buttonSaveChanges;
        private TextBox textBoxNameEdit;
        private TextBox textBoxDepartmentEdit;
        private TextBox textBoxRoleEdit;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button buttonDeleteSelected;
    }
}