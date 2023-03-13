namespace ExamSystem
{
    partial class UserDetails
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
            Btn_Cancel = new Button();
            Btn_Save = new Button();
            Txt_UserFname = new TextBox();
            Txt_UserSSN = new TextBox();
            label2 = new Label();
            label1 = new Label();
            Txt_UserAge = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            CB_UserDept = new ComboBox();
            Cb_UserRole = new ComboBox();
            Txt_UserLname = new TextBox();
            ss = new Label();
            label6 = new Label();
            Txt_UserPassword = new TextBox();
            SuspendLayout();
            // 
            // Btn_Cancel
            // 
            Btn_Cancel.Anchor = AnchorStyles.None;
            Btn_Cancel.BackColor = Color.IndianRed;
            Btn_Cancel.Font = new Font("Cairo SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Cancel.ForeColor = SystemColors.ButtonHighlight;
            Btn_Cancel.Location = new Point(426, 428);
            Btn_Cancel.Name = "Btn_Cancel";
            Btn_Cancel.Size = new Size(109, 45);
            Btn_Cancel.TabIndex = 11;
            Btn_Cancel.Text = "Cancel";
            Btn_Cancel.UseVisualStyleBackColor = false;
            Btn_Cancel.Click += Btn_Cancel_Click;
            // 
            // Btn_Save
            // 
            Btn_Save.Anchor = AnchorStyles.None;
            Btn_Save.BackColor = Color.Green;
            Btn_Save.Font = new Font("Cairo SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Save.ForeColor = SystemColors.ButtonHighlight;
            Btn_Save.Location = new Point(246, 428);
            Btn_Save.Name = "Btn_Save";
            Btn_Save.Size = new Size(109, 45);
            Btn_Save.TabIndex = 10;
            Btn_Save.Text = "Save";
            Btn_Save.UseVisualStyleBackColor = false;
            Btn_Save.Click += Btn_Save_Click;
            // 
            // Txt_UserFname
            // 
            Txt_UserFname.Anchor = AnchorStyles.None;
            Txt_UserFname.Font = new Font("Cairo", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Txt_UserFname.Location = new Point(426, 76);
            Txt_UserFname.Name = "Txt_UserFname";
            Txt_UserFname.Size = new Size(289, 45);
            Txt_UserFname.TabIndex = 9;
            // 
            // Txt_UserSSN
            // 
            Txt_UserSSN.Anchor = AnchorStyles.None;
            Txt_UserSSN.Font = new Font("Cairo", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Txt_UserSSN.Location = new Point(54, 76);
            Txt_UserSSN.Name = "Txt_UserSSN";
            Txt_UserSSN.Size = new Size(289, 45);
            Txt_UserSSN.TabIndex = 8;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Cairo", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(54, 30);
            label2.Name = "label2";
            label2.Size = new Size(61, 43);
            label2.TabIndex = 7;
            label2.Text = "SSN";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Cairo", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(426, 30);
            label1.Name = "label1";
            label1.Size = new Size(128, 43);
            label1.TabIndex = 6;
            label1.Text = "First Name";
            // 
            // Txt_UserAge
            // 
            Txt_UserAge.Anchor = AnchorStyles.None;
            Txt_UserAge.Font = new Font("Cairo", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Txt_UserAge.Location = new Point(54, 169);
            Txt_UserAge.Name = "Txt_UserAge";
            Txt_UserAge.Size = new Size(289, 45);
            Txt_UserAge.TabIndex = 13;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Cairo", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(54, 123);
            label3.Name = "label3";
            label3.Size = new Size(57, 43);
            label3.TabIndex = 12;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Cairo", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(429, 220);
            label4.Name = "label4";
            label4.Size = new Size(139, 43);
            label4.TabIndex = 14;
            label4.Text = "Department";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Cairo", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(54, 220);
            label5.Name = "label5";
            label5.Size = new Size(63, 43);
            label5.TabIndex = 16;
            label5.Text = "Role";
            // 
            // CB_UserDept
            // 
            CB_UserDept.Anchor = AnchorStyles.None;
            CB_UserDept.Font = new Font("Cairo SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CB_UserDept.FormattingEnabled = true;
            CB_UserDept.Location = new Point(429, 266);
            CB_UserDept.Name = "CB_UserDept";
            CB_UserDept.Size = new Size(289, 45);
            CB_UserDept.TabIndex = 17;
            // 
            // Cb_UserRole
            // 
            Cb_UserRole.Anchor = AnchorStyles.None;
            Cb_UserRole.Font = new Font("Cairo SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Cb_UserRole.FormattingEnabled = true;
            Cb_UserRole.Location = new Point(54, 266);
            Cb_UserRole.Name = "Cb_UserRole";
            Cb_UserRole.Size = new Size(289, 45);
            Cb_UserRole.TabIndex = 18;
            // 
            // Txt_UserLname
            // 
            Txt_UserLname.Anchor = AnchorStyles.None;
            Txt_UserLname.Font = new Font("Cairo", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Txt_UserLname.Location = new Point(429, 169);
            Txt_UserLname.Name = "Txt_UserLname";
            Txt_UserLname.Size = new Size(289, 45);
            Txt_UserLname.TabIndex = 20;
            // 
            // ss
            // 
            ss.Anchor = AnchorStyles.None;
            ss.AutoSize = true;
            ss.Font = new Font("Cairo", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            ss.Location = new Point(429, 123);
            ss.Name = "ss";
            ss.Size = new Size(125, 43);
            ss.TabIndex = 19;
            ss.Text = "Last Name";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Cairo", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(327, 314);
            label6.Name = "label6";
            label6.Size = new Size(118, 43);
            label6.TabIndex = 21;
            label6.Text = "Password";
            // 
            // Txt_UserPassword
            // 
            Txt_UserPassword.Anchor = AnchorStyles.None;
            Txt_UserPassword.Font = new Font("Cairo", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Txt_UserPassword.Location = new Point(246, 360);
            Txt_UserPassword.Name = "Txt_UserPassword";
            Txt_UserPassword.Size = new Size(289, 45);
            Txt_UserPassword.TabIndex = 22;
            // 
            // UserDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 485);
            Controls.Add(Txt_UserPassword);
            Controls.Add(label6);
            Controls.Add(Txt_UserLname);
            Controls.Add(ss);
            Controls.Add(Cb_UserRole);
            Controls.Add(CB_UserDept);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Txt_UserAge);
            Controls.Add(label3);
            Controls.Add(Btn_Cancel);
            Controls.Add(Btn_Save);
            Controls.Add(Txt_UserFname);
            Controls.Add(Txt_UserSSN);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserDetails";
            StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Cancel;
        private Button Btn_Save;
        private TextBox Txt_UserFname;
        private TextBox Txt_UserSSN;
        private Label label2;
        private Label label1;
        private TextBox Txt_UserAge;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox CB_UserDept;
        private ComboBox Cb_UserRole;
        private TextBox Txt_UserLname;
        private Label ss;
        private Label label6;
        private TextBox Txt_UserPassword;
    }
}