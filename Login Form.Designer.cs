namespace ExamSystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Btn_Login = new Button();
            Txt_SSN = new TextBox();
            Txt_Password = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            PasswordPanel = new Panel();
            PasswordIcon = new FontAwesome.Sharp.IconPictureBox();
            UserPanel = new Panel();
            UserIcon = new FontAwesome.Sharp.IconPictureBox();
            Btn_Exit = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            PasswordPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PasswordIcon).BeginInit();
            UserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UserIcon).BeginInit();
            SuspendLayout();
            // 
            // Btn_Login
            // 
            Btn_Login.BackColor = Color.FromArgb(33, 121, 184);
            Btn_Login.Font = new Font("Cairo", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Login.ForeColor = SystemColors.ButtonHighlight;
            Btn_Login.Location = new Point(28, 341);
            Btn_Login.Name = "Btn_Login";
            Btn_Login.Size = new Size(152, 60);
            Btn_Login.TabIndex = 3;
            Btn_Login.Text = "Login";
            Btn_Login.UseVisualStyleBackColor = false;
            Btn_Login.Click += Btn_Login_Click;
            // 
            // Txt_SSN
            // 
            Txt_SSN.BackColor = SystemColors.Control;
            Txt_SSN.BorderStyle = BorderStyle.None;
            Txt_SSN.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_SSN.Location = new Point(49, 3);
            Txt_SSN.Name = "Txt_SSN";
            Txt_SSN.Size = new Size(391, 38);
            Txt_SSN.TabIndex = 1;
            Txt_SSN.Enter += Txt_SSN_Enter;
            // 
            // Txt_Password
            // 
            Txt_Password.BackColor = SystemColors.Control;
            Txt_Password.BorderStyle = BorderStyle.None;
            Txt_Password.Font = new Font("Cairo", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Txt_Password.Location = new Point(49, 2);
            Txt_Password.MinimumSize = new Size(0, 10);
            Txt_Password.Name = "Txt_Password";
            Txt_Password.PasswordChar = '•';
            Txt_Password.Size = new Size(391, 38);
            Txt_Password.TabIndex = 2;
            Txt_Password.Enter += Txt_Password_Enter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 121, 184);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(358, 517);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(348, 126);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Cairo SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(73, 244);
            label1.Name = "label1";
            label1.Size = new Size(201, 106);
            label1.TabIndex = 0;
            label1.Text = "Welcome To ITI\nExam System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(PasswordPanel);
            panel2.Controls.Add(UserPanel);
            panel2.Controls.Add(Btn_Exit);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(Btn_Login);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(359, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(550, 517);
            panel2.TabIndex = 5;
            panel2.PreviewKeyDown += panel2_PreviewKeyDown;
            // 
            // PasswordPanel
            // 
            PasswordPanel.Controls.Add(PasswordIcon);
            PasswordPanel.Controls.Add(Txt_Password);
            PasswordPanel.Location = new Point(28, 280);
            PasswordPanel.Name = "PasswordPanel";
            PasswordPanel.Padding = new Padding(10);
            PasswordPanel.Size = new Size(443, 43);
            PasswordPanel.TabIndex = 6;
            // 
            // PasswordIcon
            // 
            PasswordIcon.Anchor = AnchorStyles.None;
            PasswordIcon.BackColor = SystemColors.Control;
            PasswordIcon.ForeColor = Color.FromArgb(33, 121, 184);
            PasswordIcon.IconChar = FontAwesome.Sharp.IconChar.Lock;
            PasswordIcon.IconColor = Color.FromArgb(33, 121, 184);
            PasswordIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            PasswordIcon.IconSize = 40;
            PasswordIcon.Location = new Point(3, 3);
            PasswordIcon.Name = "PasswordIcon";
            PasswordIcon.Size = new Size(40, 40);
            PasswordIcon.SizeMode = PictureBoxSizeMode.CenterImage;
            PasswordIcon.TabIndex = 0;
            PasswordIcon.TabStop = false;
            // 
            // UserPanel
            // 
            UserPanel.Controls.Add(UserIcon);
            UserPanel.Controls.Add(Txt_SSN);
            UserPanel.Location = new Point(28, 222);
            UserPanel.Name = "UserPanel";
            UserPanel.Padding = new Padding(10);
            UserPanel.Size = new Size(443, 49);
            UserPanel.TabIndex = 5;
            // 
            // UserIcon
            // 
            UserIcon.BackColor = SystemColors.Control;
            UserIcon.ForeColor = Color.FromArgb(33, 121, 184);
            UserIcon.IconChar = FontAwesome.Sharp.IconChar.User;
            UserIcon.IconColor = Color.FromArgb(33, 121, 184);
            UserIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            UserIcon.IconSize = 40;
            UserIcon.Location = new Point(3, 0);
            UserIcon.Name = "UserIcon";
            UserIcon.Size = new Size(40, 49);
            UserIcon.SizeMode = PictureBoxSizeMode.CenterImage;
            UserIcon.TabIndex = 0;
            UserIcon.TabStop = false;
            // 
            // Btn_Exit
            // 
            Btn_Exit.BackColor = SystemColors.Control;
            Btn_Exit.FlatAppearance.BorderSize = 0;
            Btn_Exit.FlatStyle = FlatStyle.Flat;
            Btn_Exit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            Btn_Exit.IconColor = Color.FromArgb(33, 121, 184);
            Btn_Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Btn_Exit.IconSize = 32;
            Btn_Exit.Location = new Point(509, 0);
            Btn_Exit.Name = "Btn_Exit";
            Btn_Exit.Size = new Size(41, 32);
            Btn_Exit.TabIndex = 4;
            Btn_Exit.UseVisualStyleBackColor = false;
            Btn_Exit.Click += Btn_Exit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Font = new Font("Cairo SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(33, 121, 184);
            label2.Location = new Point(28, 149);
            label2.Margin = new Padding(0, 0, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(282, 53);
            label2.TabIndex = 3;
            label2.Text = "Login To Your Account";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(32, 19);
            iconMenuItem1.Text = "iconMenuItem1";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 517);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            PasswordPanel.ResumeLayout(false);
            PasswordPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PasswordIcon).EndInit();
            UserPanel.ResumeLayout(false);
            UserPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UserIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Btn_Login;
        private TextBox Txt_SSN;
        private TextBox Txt_Password;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private FontAwesome.Sharp.IconButton Btn_Exit;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private Panel UserPanel;
        private FontAwesome.Sharp.IconPictureBox UserIcon;
        private Panel PasswordPanel;
        private FontAwesome.Sharp.IconPictureBox PasswordIcon;
    }
}