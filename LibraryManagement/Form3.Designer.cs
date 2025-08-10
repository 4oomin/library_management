namespace LibraryManagement
{
    partial class Form3
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
            BookListPanel = new Panel();
            BookListData = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            BookOutputPanel = new Panel();
            BookRemoveBtn = new Button();
            BookRegisterBtn = new Button();
            BookResultLbl = new Label();
            BookInputPanel = new Panel();
            BookIsbnTxt = new TextBox();
            BookTitleTxt = new TextBox();
            lbl2 = new Label();
            lbl1 = new Label();
            BookListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BookListData).BeginInit();
            BookOutputPanel.SuspendLayout();
            BookInputPanel.SuspendLayout();
            SuspendLayout();
            // 
            // BookListPanel
            // 
            BookListPanel.Controls.Add(BookListData);
            BookListPanel.Location = new Point(14, 17);
            BookListPanel.Name = "BookListPanel";
            BookListPanel.Size = new Size(514, 205);
            BookListPanel.TabIndex = 0;
            // 
            // BookListData
            // 
            BookListData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookListData.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            BookListData.Dock = DockStyle.Fill;
            BookListData.Location = new Point(0, 0);
            BookListData.Name = "BookListData";
            BookListData.RowHeadersWidth = 62;
            BookListData.Size = new Size(514, 205);
            BookListData.TabIndex = 0;
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
            Column2.HeaderText = "Title";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            Column2.Width = 150;
            // 
            // Column3
            // 
            Column3.HeaderText = "Isbn";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            Column3.Width = 150;
            // 
            // BookOutputPanel
            // 
            BookOutputPanel.Controls.Add(BookRemoveBtn);
            BookOutputPanel.Controls.Add(BookRegisterBtn);
            BookOutputPanel.Controls.Add(BookResultLbl);
            BookOutputPanel.Location = new Point(399, 246);
            BookOutputPanel.Name = "BookOutputPanel";
            BookOutputPanel.Size = new Size(391, 192);
            BookOutputPanel.TabIndex = 4;
            // 
            // BookRemoveBtn
            // 
            BookRemoveBtn.Location = new Point(264, 135);
            BookRemoveBtn.Name = "BookRemoveBtn";
            BookRemoveBtn.Size = new Size(107, 39);
            BookRemoveBtn.TabIndex = 3;
            BookRemoveBtn.Text = "Remove";
            BookRemoveBtn.UseVisualStyleBackColor = true;
            BookRemoveBtn.Click += BookRemoveBtn_Click;
            // 
            // BookRegisterBtn
            // 
            BookRegisterBtn.Location = new Point(141, 135);
            BookRegisterBtn.Name = "BookRegisterBtn";
            BookRegisterBtn.Size = new Size(105, 39);
            BookRegisterBtn.TabIndex = 2;
            BookRegisterBtn.Text = "Register";
            BookRegisterBtn.UseVisualStyleBackColor = true;
            BookRegisterBtn.Click += BookRegisterBtn_Click;
            // 
            // BookResultLbl
            // 
            BookResultLbl.AutoSize = true;
            BookResultLbl.Location = new Point(12, 29);
            BookResultLbl.Name = "BookResultLbl";
            BookResultLbl.Size = new Size(60, 25);
            BookResultLbl.TabIndex = 0;
            BookResultLbl.Text = "label1";
            // 
            // BookInputPanel
            // 
            BookInputPanel.Controls.Add(BookIsbnTxt);
            BookInputPanel.Controls.Add(BookTitleTxt);
            BookInputPanel.Controls.Add(lbl2);
            BookInputPanel.Controls.Add(lbl1);
            BookInputPanel.Location = new Point(14, 246);
            BookInputPanel.Name = "BookInputPanel";
            BookInputPanel.Size = new Size(379, 192);
            BookInputPanel.TabIndex = 3;
            // 
            // BookIsbnTxt
            // 
            BookIsbnTxt.Location = new Point(124, 87);
            BookIsbnTxt.Name = "BookIsbnTxt";
            BookIsbnTxt.Size = new Size(232, 31);
            BookIsbnTxt.TabIndex = 4;
            // 
            // BookTitleTxt
            // 
            BookTitleTxt.Location = new Point(124, 29);
            BookTitleTxt.Name = "BookTitleTxt";
            BookTitleTxt.Size = new Size(232, 31);
            BookTitleTxt.TabIndex = 3;
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(14, 87);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(68, 25);
            lbl2.TabIndex = 1;
            lbl2.Text = "Isbn :  ";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(14, 29);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(62, 25);
            lbl1.TabIndex = 0;
            lbl1.Text = "Title : ";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BookOutputPanel);
            Controls.Add(BookInputPanel);
            Controls.Add(BookListPanel);
            Name = "Form3";
            Text = "Book";
            BookListPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)BookListData).EndInit();
            BookOutputPanel.ResumeLayout(false);
            BookOutputPanel.PerformLayout();
            BookInputPanel.ResumeLayout(false);
            BookInputPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel BookListPanel;
        private Panel BookOutputPanel;
        private Button BookRemoveBtn;
        private Button BookRegisterBtn;
        private Label BookResultLbl;
        private Panel BookInputPanel;
        private TextBox BookIsbnTxt;
        private TextBox BookTitleTxt;
        private Label lbl2;
        private Label lbl1;
        private DataGridView BookListData;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
    }
}