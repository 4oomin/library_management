namespace LibraryManagement
{
    partial class Form1
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
            Form1MenuPanel = new Panel();
            lbl1 = new Label();
            CirculationBtn = new Button();
            BookBtn = new Button();
            MemberBtn = new Button();
            Form1MenuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Form1MenuPanel
            // 
            Form1MenuPanel.Controls.Add(lbl1);
            Form1MenuPanel.Controls.Add(CirculationBtn);
            Form1MenuPanel.Controls.Add(BookBtn);
            Form1MenuPanel.Controls.Add(MemberBtn);
            Form1MenuPanel.Dock = DockStyle.Fill;
            Form1MenuPanel.Location = new Point(0, 0);
            Form1MenuPanel.Name = "Form1MenuPanel";
            Form1MenuPanel.Size = new Size(355, 477);
            Form1MenuPanel.TabIndex = 0;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BorderStyle = BorderStyle.Fixed3D;
            lbl1.Font = new Font("맑은 고딕", 10F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lbl1.Location = new Point(70, 39);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(213, 30);
            lbl1.TabIndex = 3;
            lbl1.Text = "Library Management";
            lbl1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CirculationBtn
            // 
            CirculationBtn.Location = new Point(82, 357);
            CirculationBtn.Name = "CirculationBtn";
            CirculationBtn.Size = new Size(187, 71);
            CirculationBtn.TabIndex = 2;
            CirculationBtn.Text = "Circulation";
            CirculationBtn.UseVisualStyleBackColor = true;
            CirculationBtn.Click += CirculationBtn_Click;
            // 
            // BookBtn
            // 
            BookBtn.Location = new Point(82, 231);
            BookBtn.Name = "BookBtn";
            BookBtn.Size = new Size(188, 74);
            BookBtn.TabIndex = 1;
            BookBtn.Text = "Book";
            BookBtn.UseVisualStyleBackColor = true;
            BookBtn.Click += BookBtn_Click;
            // 
            // MemberBtn
            // 
            MemberBtn.Location = new Point(82, 108);
            MemberBtn.Name = "MemberBtn";
            MemberBtn.Size = new Size(189, 71);
            MemberBtn.TabIndex = 0;
            MemberBtn.Text = "Member";
            MemberBtn.UseVisualStyleBackColor = true;
            MemberBtn.Click += MemberBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 477);
            Controls.Add(Form1MenuPanel);
            Name = "Form1";
            Text = "Home";
            Form1MenuPanel.ResumeLayout(false);
            Form1MenuPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Form1MenuPanel;
        private Button CirculationBtn;
        private Button BookBtn;
        private Button MemberBtn;
        private Label lbl1;
    }
}
