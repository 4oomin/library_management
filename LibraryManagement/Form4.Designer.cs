namespace LibraryManagement
{
    partial class Form4
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
            CirculateListPanel = new Panel();
            CirculateListData = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            CirculateOutputPanel = new Panel();
            CirculateReturnBtn = new Button();
            CirculateBorrowBtn = new Button();
            CirculateResultLbl = new Label();
            CirculateInputPanel = new Panel();
            CirculatePwTxt = new TextBox();
            CirculateEmailTxt = new TextBox();
            lbl2 = new Label();
            lbl1 = new Label();
            CirculateIsbnTxt = new TextBox();
            CirculateTitleTxt = new TextBox();
            lbl4 = new Label();
            lbl3 = new Label();
            CirculateListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CirculateListData).BeginInit();
            CirculateOutputPanel.SuspendLayout();
            CirculateInputPanel.SuspendLayout();
            SuspendLayout();
            // 
            // CirculateListPanel
            // 
            CirculateListPanel.Controls.Add(CirculateListData);
            CirculateListPanel.Location = new Point(12, 12);
            CirculateListPanel.Name = "CirculateListPanel";
            CirculateListPanel.Size = new Size(815, 190);
            CirculateListPanel.TabIndex = 0;
            // 
            // CirculateListData
            // 
            CirculateListData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CirculateListData.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            CirculateListData.Dock = DockStyle.Fill;
            CirculateListData.Location = new Point(0, 0);
            CirculateListData.Name = "CirculateListData";
            CirculateListData.RowHeadersWidth = 62;
            CirculateListData.Size = new Size(815, 190);
            CirculateListData.TabIndex = 0;
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
            Column2.HeaderText = "MemberID";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "BookID";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // Column4
            // 
            Column4.HeaderText = "StartDate";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            Column4.Width = 150;
            // 
            // Column5
            // 
            Column5.HeaderText = "EndDate";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            Column5.Width = 150;
            // 
            // CirculateOutputPanel
            // 
            CirculateOutputPanel.Controls.Add(CirculateReturnBtn);
            CirculateOutputPanel.Controls.Add(CirculateBorrowBtn);
            CirculateOutputPanel.Controls.Add(CirculateResultLbl);
            CirculateOutputPanel.Location = new Point(436, 226);
            CirculateOutputPanel.Name = "CirculateOutputPanel";
            CirculateOutputPanel.Size = new Size(391, 212);
            CirculateOutputPanel.TabIndex = 6;
            // 
            // CirculateReturnBtn
            // 
            CirculateReturnBtn.Location = new Point(269, 153);
            CirculateReturnBtn.Name = "CirculateReturnBtn";
            CirculateReturnBtn.Size = new Size(107, 39);
            CirculateReturnBtn.TabIndex = 3;
            CirculateReturnBtn.Text = "Return";
            CirculateReturnBtn.UseVisualStyleBackColor = true;
            // 
            // CirculateBorrowBtn
            // 
            CirculateBorrowBtn.Location = new Point(146, 153);
            CirculateBorrowBtn.Name = "CirculateBorrowBtn";
            CirculateBorrowBtn.Size = new Size(105, 39);
            CirculateBorrowBtn.TabIndex = 2;
            CirculateBorrowBtn.Text = "Borrow";
            CirculateBorrowBtn.UseVisualStyleBackColor = true;
            // 
            // CirculateResultLbl
            // 
            CirculateResultLbl.AutoSize = true;
            CirculateResultLbl.Location = new Point(12, 25);
            CirculateResultLbl.Name = "CirculateResultLbl";
            CirculateResultLbl.Size = new Size(60, 25);
            CirculateResultLbl.TabIndex = 0;
            CirculateResultLbl.Text = "label1";
            // 
            // CirculateInputPanel
            // 
            CirculateInputPanel.Controls.Add(CirculatePwTxt);
            CirculateInputPanel.Controls.Add(CirculateEmailTxt);
            CirculateInputPanel.Controls.Add(lbl2);
            CirculateInputPanel.Controls.Add(lbl1);
            CirculateInputPanel.Controls.Add(CirculateIsbnTxt);
            CirculateInputPanel.Controls.Add(CirculateTitleTxt);
            CirculateInputPanel.Controls.Add(lbl4);
            CirculateInputPanel.Controls.Add(lbl3);
            CirculateInputPanel.Location = new Point(12, 226);
            CirculateInputPanel.Name = "CirculateInputPanel";
            CirculateInputPanel.Size = new Size(379, 212);
            CirculateInputPanel.TabIndex = 5;
            // 
            // CirculatePwTxt
            // 
            CirculatePwTxt.Location = new Point(124, 72);
            CirculatePwTxt.Name = "CirculatePwTxt";
            CirculatePwTxt.Size = new Size(232, 31);
            CirculatePwTxt.TabIndex = 8;
            // 
            // CirculateEmailTxt
            // 
            CirculateEmailTxt.Location = new Point(124, 25);
            CirculateEmailTxt.Name = "CirculateEmailTxt";
            CirculateEmailTxt.Size = new Size(232, 31);
            CirculateEmailTxt.TabIndex = 7;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(14, 72);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(104, 25);
            lbl2.TabIndex = 6;
            lbl2.Text = "Password : ";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(14, 25);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(77, 25);
            lbl1.TabIndex = 5;
            lbl1.Text = "E-mail : ";
            // 
            // CirculateIsbnTxt
            // 
            CirculateIsbnTxt.Location = new Point(124, 161);
            CirculateIsbnTxt.Name = "CirculateIsbnTxt";
            CirculateIsbnTxt.Size = new Size(232, 31);
            CirculateIsbnTxt.TabIndex = 4;
            // 
            // CirculateTitleTxt
            // 
            CirculateTitleTxt.Location = new Point(124, 113);
            CirculateTitleTxt.Name = "CirculateTitleTxt";
            CirculateTitleTxt.Size = new Size(232, 31);
            CirculateTitleTxt.TabIndex = 3;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.Location = new Point(14, 161);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(68, 25);
            lbl4.TabIndex = 1;
            lbl4.Text = "Isbn :  ";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.Location = new Point(14, 113);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(62, 25);
            lbl3.TabIndex = 0;
            lbl3.Text = "Title : ";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 450);
            Controls.Add(CirculateOutputPanel);
            Controls.Add(CirculateInputPanel);
            Controls.Add(CirculateListPanel);
            Name = "Form4";
            Text = "Circulation";
            CirculateListPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CirculateListData).EndInit();
            CirculateOutputPanel.ResumeLayout(false);
            CirculateOutputPanel.PerformLayout();
            CirculateInputPanel.ResumeLayout(false);
            CirculateInputPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel CirculateListPanel;
        private Panel CirculateOutputPanel;
        private Button CirculateReturnBtn;
        private Button CirculateBorrowBtn;
        private Label CirculateResultLbl;
        private Panel CirculateInputPanel;
        private TextBox CirculateIsbnTxt;
        private TextBox CirculateTitleTxt;
        private Label lbl4;
        private Label lbl3;
        private Label lbl2;
        private Label lbl1;
        private TextBox CirculatePwTxt;
        private TextBox CirculateEmailTxt;
        private DataGridView CirculateListData;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}