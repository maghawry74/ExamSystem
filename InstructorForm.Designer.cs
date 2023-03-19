namespace ExamSystem
{
    partial class InstructorForm
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
            panel1 = new Panel();
            Btn_Questions = new FontAwesome.Sharp.IconButton();
            Btn_Exams = new FontAwesome.Sharp.IconButton();
            Lbl_InsName = new Label();
            panel2 = new Panel();
            ShowPanel = new Panel();
            HeaderLabel = new Label();
            DesktopPanel = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 52, 78);
            panel1.Controls.Add(Btn_Questions);
            panel1.Controls.Add(Btn_Exams);
            panel1.Controls.Add(Lbl_InsName);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(202, 557);
            panel1.TabIndex = 0;
            // 
            // Btn_Questions
            // 
            Btn_Questions.BackColor = Color.FromArgb(51, 52, 78);
            Btn_Questions.FlatStyle = FlatStyle.Flat;
            Btn_Questions.Font = new Font("Cairo SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Questions.ForeColor = SystemColors.ButtonHighlight;
            Btn_Questions.IconChar = FontAwesome.Sharp.IconChar.Question;
            Btn_Questions.IconColor = Color.White;
            Btn_Questions.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Btn_Questions.IconSize = 40;
            Btn_Questions.Location = new Point(0, 221);
            Btn_Questions.Name = "Btn_Questions";
            Btn_Questions.Size = new Size(202, 52);
            Btn_Questions.TabIndex = 2;
            Btn_Questions.Text = "Questions";
            Btn_Questions.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Questions.UseVisualStyleBackColor = false;
            Btn_Questions.FlatAppearance.BorderSize = 0;
            Btn_Questions.Click += Btn_Questions_Click;
            // 
            // Btn_Exams
            // 
            Btn_Exams.BackColor = Color.FromArgb(51, 52, 78);
            Btn_Exams.FlatStyle = FlatStyle.Flat;
            Btn_Exams.Font = new Font("Cairo SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Exams.ForeColor = SystemColors.ButtonHighlight;
            Btn_Exams.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            Btn_Exams.IconColor = Color.White;
            Btn_Exams.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Btn_Exams.IconSize = 40;
            Btn_Exams.Location = new Point(3, 153);
            Btn_Exams.Name = "Btn_Exams";
            Btn_Exams.Size = new Size(202, 52);
            Btn_Exams.TabIndex = 1;
            Btn_Exams.Text = "Exams";
            Btn_Exams.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Exams.UseVisualStyleBackColor = false;
            Btn_Exams.FlatAppearance.BorderSize = 0;
            Btn_Exams.Click += Btn_Exams_Click;
            // 
            // Lbl_InsName
            // 
            Lbl_InsName.Anchor = AnchorStyles.Top;
            Lbl_InsName.AutoSize = true;
            Lbl_InsName.FlatStyle = FlatStyle.Flat;
            Lbl_InsName.Font = new Font("Cairo", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_InsName.ForeColor = SystemColors.ButtonHighlight;
            Lbl_InsName.Location = new Point(42, 31);
            Lbl_InsName.Name = "Lbl_InsName";
            Lbl_InsName.Size = new Size(78, 43);
            Lbl_InsName.TabIndex = 0;
            Lbl_InsName.Text = "Name";
            Lbl_InsName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(0, 134, 138);
            panel2.Controls.Add(ShowPanel);
            panel2.Controls.Add(HeaderLabel);
            panel2.Location = new Point(201, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(670, 110);
            panel2.TabIndex = 1;
            // 
            // ShowPanel
            // 
            ShowPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ShowPanel.Location = new Point(0, 107);
            ShowPanel.Name = "ShowPanel";
            ShowPanel.Size = new Size(670, 313);
            ShowPanel.TabIndex = 2;
            // 
            // HeaderLabel
            // 
            HeaderLabel.Anchor = AnchorStyles.None;
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Cairo SemiBold", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            HeaderLabel.ForeColor = SystemColors.ButtonHighlight;
            HeaderLabel.Location = new Point(283, 40);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(85, 43);
            HeaderLabel.TabIndex = 2;
            HeaderLabel.Text = "Exams";
            HeaderLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // DesktopPanel
            // 
            DesktopPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DesktopPanel.BackColor = SystemColors.ButtonHighlight;
            DesktopPanel.Location = new Point(204, 107);
            DesktopPanel.Name = "DesktopPanel";
            DesktopPanel.Size = new Size(664, 450);
            DesktopPanel.TabIndex = 4;
            // 
            // InstructorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 557);
            Controls.Add(DesktopPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "InstructorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InstructorForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label Lbl_InsName;
        private Panel panel2;
        private Label HeaderLabel;
        private Panel ShowPanel;
        private FontAwesome.Sharp.IconButton Btn_Questions;
        private FontAwesome.Sharp.IconButton Btn_Exams;
        private Panel DesktopPanel;
    }
}