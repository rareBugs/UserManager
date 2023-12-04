namespace UserManager
{
    partial class ViewUser
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
            buttonViewUserClose = new Button();
            buttonExitAll = new Button();
            listBoxViewName = new ListBox();
            listBoxViewDepartment = new ListBox();
            listBoxViewRole = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonSaveList = new Button();
            SuspendLayout();
            // 
            // buttonViewUserClose
            // 
            buttonViewUserClose.Location = new Point(475, 305);
            buttonViewUserClose.Name = "buttonViewUserClose";
            buttonViewUserClose.Size = new Size(116, 28);
            buttonViewUserClose.TabIndex = 0;
            buttonViewUserClose.Text = "Close users list";
            buttonViewUserClose.UseVisualStyleBackColor = true;
            buttonViewUserClose.Click += buttonViewUserClose_Click;
            // 
            // buttonExitAll
            // 
            buttonExitAll.BackColor = SystemColors.Control;
            buttonExitAll.ForeColor = Color.Red;
            buttonExitAll.Location = new Point(475, 339);
            buttonExitAll.Name = "buttonExitAll";
            buttonExitAll.Size = new Size(116, 28);
            buttonExitAll.TabIndex = 3;
            buttonExitAll.Text = "Exit program";
            buttonExitAll.UseVisualStyleBackColor = false;
            buttonExitAll.Click += buttonExitAll_Click;
            // 
            // listBoxViewName
            // 
            listBoxViewName.ItemHeight = 15;
            listBoxViewName.Location = new Point(19, 33);
            listBoxViewName.Name = "listBoxViewName";
            listBoxViewName.Size = new Size(146, 334);
            listBoxViewName.TabIndex = 0;
            listBoxViewName.SelectedIndexChanged += listBoxViewName_SelectedIndexChanged;
            // 
            // listBoxViewDepartment
            // 
            listBoxViewDepartment.ItemHeight = 15;
            listBoxViewDepartment.Location = new Point(171, 33);
            listBoxViewDepartment.Name = "listBoxViewDepartment";
            listBoxViewDepartment.Size = new Size(146, 334);
            listBoxViewDepartment.TabIndex = 0;
            listBoxViewDepartment.SelectedIndexChanged += listBoxViewDepartment_SelectedIndexChanged;
            // 
            // listBoxViewRole
            // 
            listBoxViewRole.ItemHeight = 15;
            listBoxViewRole.Location = new Point(323, 33);
            listBoxViewRole.Name = "listBoxViewRole";
            listBoxViewRole.Size = new Size(146, 334);
            listBoxViewRole.TabIndex = 0;
            listBoxViewRole.SelectedIndexChanged += listBoxViewRole_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 15);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(171, 15);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 5;
            label2.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(323, 15);
            label3.Name = "label3";
            label3.Size = new Size(30, 15);
            label3.TabIndex = 6;
            label3.Text = "Role";
            // 
            // buttonSaveList
            // 
            buttonSaveList.Location = new Point(475, 33);
            buttonSaveList.Name = "buttonSaveList";
            buttonSaveList.Size = new Size(116, 23);
            buttonSaveList.TabIndex = 7;
            buttonSaveList.Text = "Download list";
            buttonSaveList.UseVisualStyleBackColor = true;
            buttonSaveList.Click += buttonSaveList_Click;
            // 
            // ViewUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 388);
            Controls.Add(buttonSaveList);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxViewRole);
            Controls.Add(listBoxViewDepartment);
            Controls.Add(listBoxViewName);
            Controls.Add(buttonExitAll);
            Controls.Add(buttonViewUserClose);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ViewUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User list";
            Load += ViewUsers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonViewUserClose;
        private Button buttonExitAll;
        private ListBox listBoxViewName;
        private ListBox listBoxViewDepartment;
        private ListBox listBoxViewRole;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonSaveList;
    }
}