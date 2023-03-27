namespace ExamSystem
{
    partial class StudentWelcome
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
            Lbl_Welcome = new Label();
            Txt_ExamId = new TextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            Btn_Exit = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // Lbl_Welcome
            // 
            Lbl_Welcome.Anchor = AnchorStyles.None;
            Lbl_Welcome.AutoSize = true;
            Lbl_Welcome.Font = new Font("Cairo", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Welcome.ForeColor = SystemColors.ControlLightLight;
            Lbl_Welcome.Location = new Point(232, 126);
            Lbl_Welcome.Name = "Lbl_Welcome";
            Lbl_Welcome.Size = new Size(110, 43);
            Lbl_Welcome.TabIndex = 0;
            Lbl_Welcome.Text = "Welcome";
            // 
            // Txt_ExamId
            // 
            Txt_ExamId.Anchor = AnchorStyles.None;
            Txt_ExamId.Font = new Font("Cairo", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Txt_ExamId.Location = new Point(147, 172);
            Txt_ExamId.Name = "Txt_ExamId";
            Txt_ExamId.PlaceholderText = "Enter Exam Number";
            Txt_ExamId.Size = new Size(390, 45);
            Txt_ExamId.TabIndex = 1;
            // 
            // iconButton1
            // 
            iconButton1.Anchor = AnchorStyles.None;
            iconButton1.BackColor = Color.Navy;
            iconButton1.Font = new Font("Cairo SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            iconButton1.ForeColor = SystemColors.ButtonHighlight;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Play;
            iconButton1.IconColor = Color.SpringGreen;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 32;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(264, 235);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(139, 51);
            iconButton1.TabIndex = 2;
            iconButton1.Text = "Proceed";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // Btn_Exit
            // 
            Btn_Exit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Exit.BackColor = Color.FromArgb(51, 52, 78);
            Btn_Exit.FlatAppearance.BorderSize = 0;
            Btn_Exit.FlatStyle = FlatStyle.Flat;
            Btn_Exit.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            Btn_Exit.IconColor = Color.FromArgb(33, 121, 184);
            Btn_Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Btn_Exit.IconSize = 32;
            Btn_Exit.Location = new Point(642, 12);
            Btn_Exit.Name = "Btn_Exit";
            Btn_Exit.Size = new Size(41, 32);
            Btn_Exit.TabIndex = 5;
            Btn_Exit.UseVisualStyleBackColor = false;
            Btn_Exit.Click += Btn_Exit_Click;
            // 
            // StudentWelcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(51, 52, 78);
            ClientSize = new Size(695, 396);
            Controls.Add(Btn_Exit);
            Controls.Add(iconButton1);
            Controls.Add(Txt_ExamId);
            Controls.Add(Lbl_Welcome);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StudentWelcome";
            StartPosition = FormStartPosition.CenterParent;
            Text = "StudentWelcome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_Welcome;
        private TextBox Txt_ExamId;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton Btn_Exit;
    }
}