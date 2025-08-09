namespace LibraryManagement
{
    partial class Form2
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
            MemberListPanel = new Panel();
            MemberListData = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            MemberInputPanel = new Panel();
            MemberPwTxt = new TextBox();
            MemberEmailTxt = new TextBox();
            MemberNameTxt = new TextBox();
            lbl3 = new Label();
            lbl2 = new Label();
            lbl1 = new Label();
            MemberOutputPanel = new Panel();
            MemberDeleteIdBtn = new Button();
            MemberSignUpBtn = new Button();
            MemberResultLbl = new Label();
            MemberListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MemberListData).BeginInit();
            MemberInputPanel.SuspendLayout();
            MemberOutputPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MemberListPanel
            // 
            MemberListPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            MemberListPanel.Controls.Add(MemberListData);
            MemberListPanel.Location = new Point(12, 12);
            MemberListPanel.Name = "MemberListPanel";
            MemberListPanel.Size = new Size(660, 212);
            MemberListPanel.TabIndex = 0;
            // 
            // MemberListData
            // 
            MemberListData.AllowUserToAddRows = false;
            MemberListData.AllowUserToDeleteRows = false;
            MemberListData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MemberListData.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            MemberListData.Dock = DockStyle.Fill;
            MemberListData.Location = new Point(0, 0);
            MemberListData.Name = "MemberListData";
            MemberListData.RowHeadersWidth = 62;
            MemberListData.Size = new Size(660, 212);
            MemberListData.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // Column2
            // 
            Column2.HeaderText = "Name";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "E-mail";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "Password";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // MemberInputPanel
            // 
            MemberInputPanel.Controls.Add(MemberPwTxt);
            MemberInputPanel.Controls.Add(MemberEmailTxt);
            MemberInputPanel.Controls.Add(MemberNameTxt);
            MemberInputPanel.Controls.Add(lbl3);
            MemberInputPanel.Controls.Add(lbl2);
            MemberInputPanel.Controls.Add(lbl1);
            MemberInputPanel.Location = new Point(12, 246);
            MemberInputPanel.Name = "MemberInputPanel";
            MemberInputPanel.Size = new Size(379, 192);
            MemberInputPanel.TabIndex = 1;
            // 
            // MemberPwTxt
            // 
            MemberPwTxt.Location = new Point(124, 139);
            MemberPwTxt.Name = "MemberPwTxt";
            MemberPwTxt.Size = new Size(232, 31);
            MemberPwTxt.TabIndex = 5;
            // 
            // MemberEmailTxt
            // 
            MemberEmailTxt.Location = new Point(124, 87);
            MemberEmailTxt.Name = "MemberEmailTxt";
            MemberEmailTxt.Size = new Size(232, 31);
            MemberEmailTxt.TabIndex = 4;
            // 
            // MemberNameTxt
            // 
            MemberNameTxt.Location = new Point(124, 29);
            MemberNameTxt.Name = "MemberNameTxt";
            MemberNameTxt.Size = new Size(232, 31);
            MemberNameTxt.TabIndex = 3;
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(14, 139);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(104, 25);
            lbl3.TabIndex = 2;
            lbl3.Text = "Password : ";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(14, 87);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(83, 25);
            lbl2.TabIndex = 1;
            lbl2.Text = "E-mail :  ";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(14, 29);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(77, 25);
            lbl1.TabIndex = 0;
            lbl1.Text = "Name : ";
            // 
            // MemberOutputPanel
            // 
            MemberOutputPanel.Controls.Add(MemberDeleteIdBtn);
            MemberOutputPanel.Controls.Add(MemberSignUpBtn);
            MemberOutputPanel.Controls.Add(MemberResultLbl);
            MemberOutputPanel.Location = new Point(397, 246);
            MemberOutputPanel.Name = "MemberOutputPanel";
            MemberOutputPanel.Size = new Size(391, 192);
            MemberOutputPanel.TabIndex = 2;
            // 
            // MemberDeleteIdBtn
            // 
            MemberDeleteIdBtn.Location = new Point(264, 135);
            MemberDeleteIdBtn.Name = "MemberDeleteIdBtn";
            MemberDeleteIdBtn.Size = new Size(107, 39);
            MemberDeleteIdBtn.TabIndex = 3;
            MemberDeleteIdBtn.Text = "Delete ID";
            MemberDeleteIdBtn.UseVisualStyleBackColor = true;
            MemberDeleteIdBtn.Click += MemberDeleteIdBtn_Click;
            // 
            // MemberSignUpBtn
            // 
            MemberSignUpBtn.Location = new Point(141, 135);
            MemberSignUpBtn.Name = "MemberSignUpBtn";
            MemberSignUpBtn.Size = new Size(105, 39);
            MemberSignUpBtn.TabIndex = 2;
            MemberSignUpBtn.Text = "Sign up";
            MemberSignUpBtn.UseVisualStyleBackColor = true;
            MemberSignUpBtn.Click += MemberSignUpBtn_Click;
            // 
            // MemberResultLbl
            // 
            MemberResultLbl.AutoSize = true;
            MemberResultLbl.Location = new Point(12, 29);
            MemberResultLbl.Name = "MemberResultLbl";
            MemberResultLbl.Size = new Size(20, 25);
            MemberResultLbl.TabIndex = 0;
            MemberResultLbl.Text = "*";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 450);
            Controls.Add(MemberOutputPanel);
            Controls.Add(MemberInputPanel);
            Controls.Add(MemberListPanel);
            Name = "Form2";
            Text = "Member";
            MemberListPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MemberListData).EndInit();
            MemberInputPanel.ResumeLayout(false);
            MemberInputPanel.PerformLayout();
            MemberOutputPanel.ResumeLayout(false);
            MemberOutputPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MemberListPanel;
        private Panel MemberInputPanel;
        private Label lbl3;
        private Label lbl2;
        private Label lbl1;
        private Panel MemberOutputPanel;
        private TextBox MemberPwTxt;
        private TextBox MemberEmailTxt;
        private TextBox MemberNameTxt;
        private Button MemberSignUpBtn;
        private Label MemberResultLbl;
        private Button MemberDeleteIdBtn;
        private DataGridView MemberListData;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}