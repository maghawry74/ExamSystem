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
            SidePanel.Controls.Add(label1);
            SidePanel.Controls.Add(Btn_Users);
            SidePanel.Controls.Add(Btn_Dept);
            SidePanel.Location = new Point(-3, -3);
            SidePanel.Name = "SidePanel";
            SidePanel.Padding = new Padding(10);
            SidePanel.Size = new Size(290, 593);
            SidePanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Cairo SemiBold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(53, 36);
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
            Btn_Users.Location = new Point(13, 326);
            Btn_Users.Name = "Btn_Users";
            Btn_Users.Size = new Size(267, 69);
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
            Btn_Dept.Location = new Point(13, 231);
            Btn_Dept.Name = "Btn_Dept";
            Btn_Dept.Size = new Size(267, 69);
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
            HeaderPanel.Location = new Point(284, -3);
            HeaderPanel.Name = "HeaderPanel";
            HeaderPanel.Size = new Size(662, 100);
            HeaderPanel.TabIndex = 2;
            // 
            // HeaderLabel
            // 
            HeaderLabel.Anchor = AnchorStyles.None;
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Cairo", 18F, FontStyle.Bold, GraphicsUnit.Point);
            HeaderLabel.ForeColor = SystemColors.ButtonHighlight;
            HeaderLabel.Location = new Point(289, 22);
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
            DesktopPanel.Location = new Point(284, 94);
            DesktopPanel.Name = "DesktopPanel";
            DesktopPanel.Size = new Size(662, 496);
            DesktopPanel.TabIndex = 3;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 592);
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
    }
}