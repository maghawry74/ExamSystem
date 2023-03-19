namespace ExamSystem
{
    partial class Admin
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
            SidePanel = new Panel();
            Btn_Reports = new FontAwesome.Sharp.IconButton();
            Btn_Course = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            Btn_Users = new FontAwesome.Sharp.IconButton();
            Btn_Dept = new FontAwesome.Sharp.IconButton();
            HeaderPanel = new Panel();
            HeaderLabel = new Label();
            DesktopPanel = new Panel();
            SidePanel.SuspendLayout();
            HeaderPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SidePanel
            // 
            SidePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            SidePanel.BackColor = Color.FromArgb(51, 52, 78);
            SidePanel.Controls.Add(Btn_Reports);
            SidePanel.Controls.Add(Btn_Course);
            SidePanel.Controls.Add(label1);
            SidePanel.Controls.Add(Btn_Users);
            SidePanel.Controls.Add(Btn_Dept);
            SidePanel.Location = new Point(-3, -3);
            SidePanel.Name = "SidePanel";
            SidePanel.Padding = new Padding(10);
            SidePanel.Size = new Size(199, 522);
            SidePanel.TabIndex = 0;
            // 
            // Btn_Reports
            // 
            Btn_Reports.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Btn_Reports.BackColor = Color.FromArgb(51, 52, 78);
            Btn_Reports.FlatAppearance.BorderSize = 0;
            Btn_Reports.FlatStyle = FlatStyle.Flat;
            Btn_Reports.Font = new Font("Cairo", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Reports.ForeColor = SystemColors.ButtonHighlight;
            Btn_Reports.IconChar = FontAwesome.Sharp.IconChar.PiedPiperSquare;
            Btn_Reports.IconColor = Color.White;
            Btn_Reports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Btn_Reports.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Reports.Location = new Point(13, 394);
            Btn_Reports.Name = "Btn_Reports";
            Btn_Reports.Size = new Size(173, 69);
            Btn_Reports.TabIndex = 4;
            Btn_Reports.Text = "Reports";
            Btn_Reports.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Reports.UseVisualStyleBackColor = false;
            Btn_Reports.Click += Btn_Reports_Click;
            // 
            // Btn_Course
            // 
            Btn_Course.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Btn_Course.BackColor = Color.FromArgb(51, 52, 78);
            Btn_Course.FlatAppearance.BorderSize = 0;
            Btn_Course.FlatStyle = FlatStyle.Flat;
            Btn_Course.Font = new Font("Cairo", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Course.ForeColor = SystemColors.ButtonHighlight;
            Btn_Course.IconChar = FontAwesome.Sharp.IconChar.Book;
            Btn_Course.IconColor = Color.White;
            Btn_Course.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Btn_Course.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Course.Location = new Point(13, 319);
            Btn_Course.Name = "Btn_Course";
            Btn_Course.Size = new Size(173, 69);
            Btn_Course.TabIndex = 4;
            Btn_Course.Text = "Course";
            Btn_Course.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Course.UseVisualStyleBackColor = false;
            Btn_Course.Click += Btn_Course_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Cairo SemiBold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(7, 36);
            label1.Name = "label1";
            label1.Size = new Size(186, 64);
            label1.TabIndex = 3;
            label1.Text = "DashBoard";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Btn_Users
            // 
            Btn_Users.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Btn_Users.BackColor = Color.FromArgb(51, 52, 78);
            Btn_Users.FlatAppearance.BorderSize = 0;
            Btn_Users.FlatStyle = FlatStyle.Flat;
            Btn_Users.Font = new Font("Cairo", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Users.ForeColor = SystemColors.ButtonHighlight;
            Btn_Users.IconChar = FontAwesome.Sharp.IconChar.Users;
            Btn_Users.IconColor = Color.White;
            Btn_Users.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Btn_Users.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Users.Location = new Point(13, 244);
            Btn_Users.Name = "Btn_Users";
            Btn_Users.Size = new Size(173, 69);
            Btn_Users.TabIndex = 1;
            Btn_Users.Text = "Users";
            Btn_Users.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Users.UseVisualStyleBackColor = false;
            Btn_Users.Click += Btn_Users_Click;
            // 
            // Btn_Dept
            // 
            Btn_Dept.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            Btn_Dept.BackColor = Color.FromArgb(51, 52, 78);
            Btn_Dept.FlatAppearance.BorderSize = 0;
            Btn_Dept.FlatStyle = FlatStyle.Flat;
            Btn_Dept.Font = new Font("Cairo", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Dept.ForeColor = SystemColors.ButtonHighlight;
            Btn_Dept.IconChar = FontAwesome.Sharp.IconChar.Building;
            Btn_Dept.IconColor = Color.White;
            Btn_Dept.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Btn_Dept.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Dept.Location = new Point(13, 160);
            Btn_Dept.Name = "Btn_Dept";
            Btn_Dept.Size = new Size(173, 69);
            Btn_Dept.TabIndex = 0;
            Btn_Dept.Text = "Departments";
            Btn_Dept.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Dept.UseVisualStyleBackColor = false;
            Btn_Dept.Click += Btn_Dept_Click;
            // 
            // HeaderPanel
            // 
            HeaderPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            HeaderPanel.BackColor = Color.FromArgb(0, 134, 138);
            HeaderPanel.Controls.Add(HeaderLabel);
            HeaderPanel.Location = new Point(196, -3);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.Size = new Size(1255, 100);
            HeaderPanel.TabIndex = 2;
            // 
            // HeaderLabel
            // 
            HeaderLabel.Anchor = AnchorStyles.None;
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Cairo", 18F, FontStyle.Bold, GraphicsUnit.Point);
            HeaderLabel.ForeColor = SystemColors.ButtonHighlight;
            HeaderLabel.Location = new Point(585, 22);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(101, 56);
            HeaderLabel.TabIndex = 0;
            HeaderLabel.Text = "Home";
            HeaderLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // DesktopPanel
            // 
            DesktopPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DesktopPanel.BackColor = SystemColors.ButtonHighlight;
            DesktopPanel.Location = new Point(196, 95);
            DesktopPanel.Name = "DesktopPanel";
            DesktopPanel.Size = new Size(1255, 424);
            DesktopPanel.TabIndex = 3;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1452, 521);
            Controls.Add(DesktopPanel);
            Controls.Add(HeaderPanel);
            Controls.Add(SidePanel);
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            SidePanel.ResumeLayout(false);
            SidePanel.PerformLayout();
            HeaderPanel.ResumeLayout(false);
            HeaderPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel SidePanel;
        private FontAwesome.Sharp.IconButton Btn_Users;
        private FontAwesome.Sharp.IconButton Btn_Dept;
        private Label label1;
        private Panel HeaderPanel;
        private Label HeaderLabel;
        private Panel DesktopPanel;
        private FontAwesome.Sharp.IconButton Btn_Course;
        private FontAwesome.Sharp.IconButton Btn_Reports;
    }
}