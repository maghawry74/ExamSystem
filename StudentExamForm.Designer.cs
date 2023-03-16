namespace ExamSystem
{
    partial class StudentExamForm
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
            Lbl_Exam = new Label();
            Lbl_Question = new Label();
            Btn_Next = new Button();
            ChoicesGroup = new GroupBox();
            Answer_4 = new RadioButton();
            Answer_3 = new RadioButton();
            Answer_2 = new RadioButton();
            Answer_1 = new RadioButton();
            Lbl_StudentName = new Label();
            Btn_Submit = new Button();
            ChoicesGroup.SuspendLayout();
            SuspendLayout();
            // 
            // Lbl_Exam
            // 
            Lbl_Exam.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Lbl_Exam.AutoSize = true;
            Lbl_Exam.Font = new Font("Cairo SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Exam.Location = new Point(961, 9);
            Lbl_Exam.Name = "Lbl_Exam";
            Lbl_Exam.Size = new Size(96, 53);
            Lbl_Exam.TabIndex = 0;
            Lbl_Exam.Text = "label1";
            // 
            // Lbl_Question
            // 
            Lbl_Question.AutoSize = true;
            Lbl_Question.Font = new Font("Cairo SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Question.Location = new Point(59, 97);
            Lbl_Question.Name = "Lbl_Question";
            Lbl_Question.Size = new Size(69, 37);
            Lbl_Question.TabIndex = 1;
            Lbl_Question.Text = "label1";
            // 
            // Btn_Next
            // 
            Btn_Next.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Next.BackColor = Color.Coral;
            Btn_Next.Font = new Font("Cairo SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Next.ForeColor = SystemColors.ButtonHighlight;
            Btn_Next.Location = new Point(910, 411);
            Btn_Next.Name = "Btn_Next";
            Btn_Next.Size = new Size(119, 49);
            Btn_Next.TabIndex = 6;
            Btn_Next.Text = "Next";
            Btn_Next.UseVisualStyleBackColor = false;
            Btn_Next.Click += Btn_Next_Click;
            // 
            // ChoicesGroup
            // 
            ChoicesGroup.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ChoicesGroup.Controls.Add(Answer_4);
            ChoicesGroup.Controls.Add(Answer_3);
            ChoicesGroup.Controls.Add(Answer_2);
            ChoicesGroup.Controls.Add(Answer_1);
            ChoicesGroup.Font = new Font("Cairo SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ChoicesGroup.Location = new Point(59, 145);
            ChoicesGroup.Name = "ChoicesGroup";
            ChoicesGroup.Size = new Size(970, 260);
            ChoicesGroup.TabIndex = 7;
            ChoicesGroup.TabStop = false;
            ChoicesGroup.Text = "Choices";
            // 
            // Answer_4
            // 
            Answer_4.AutoSize = true;
            Answer_4.Location = new Point(28, 191);
            Answer_4.Name = "Answer_4";
            Answer_4.Size = new Size(152, 41);
            Answer_4.TabIndex = 3;
            Answer_4.TabStop = true;
            Answer_4.Text = "radioButton4";
            Answer_4.UseVisualStyleBackColor = true;
            // 
            // Answer_3
            // 
            Answer_3.AutoSize = true;
            Answer_3.Location = new Point(28, 146);
            Answer_3.Name = "Answer_3";
            Answer_3.Size = new Size(152, 41);
            Answer_3.TabIndex = 2;
            Answer_3.TabStop = true;
            Answer_3.Text = "radioButton3";
            Answer_3.UseVisualStyleBackColor = true;
            // 
            // Answer_2
            // 
            Answer_2.AutoSize = true;
            Answer_2.Location = new Point(28, 101);
            Answer_2.Name = "Answer_2";
            Answer_2.Size = new Size(152, 41);
            Answer_2.TabIndex = 1;
            Answer_2.TabStop = true;
            Answer_2.Text = "radioButton2";
            Answer_2.UseVisualStyleBackColor = true;
            // 
            // Answer_1
            // 
            Answer_1.AutoSize = true;
            Answer_1.Location = new Point(28, 50);
            Answer_1.Name = "Answer_1";
            Answer_1.Size = new Size(152, 41);
            Answer_1.TabIndex = 0;
            Answer_1.TabStop = true;
            Answer_1.Text = "radioButton1";
            Answer_1.UseVisualStyleBackColor = true;
            // 
            // Lbl_StudentName
            // 
            Lbl_StudentName.AutoSize = true;
            Lbl_StudentName.Font = new Font("Cairo SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_StudentName.Location = new Point(12, 9);
            Lbl_StudentName.Name = "Lbl_StudentName";
            Lbl_StudentName.Size = new Size(96, 53);
            Lbl_StudentName.TabIndex = 8;
            Lbl_StudentName.Text = "label1";
            // 
            // Btn_Submit
            // 
            Btn_Submit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Submit.BackColor = Color.SeaGreen;
            Btn_Submit.Font = new Font("Cairo SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Submit.ForeColor = SystemColors.ButtonHighlight;
            Btn_Submit.Location = new Point(910, 411);
            Btn_Submit.Name = "Btn_Submit";
            Btn_Submit.Size = new Size(119, 49);
            Btn_Submit.TabIndex = 9;
            Btn_Submit.Text = "Submit";
            Btn_Submit.UseVisualStyleBackColor = false;
            Btn_Submit.Visible = false;
            Btn_Submit.Click += Btn_Submit_Click;
            // 
            // StudentExamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 472);
            Controls.Add(Btn_Submit);
            Controls.Add(Lbl_StudentName);
            Controls.Add(ChoicesGroup);
            Controls.Add(Btn_Next);
            Controls.Add(Lbl_Question);
            Controls.Add(Lbl_Exam);
            Name = "StudentExamForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "StudentExamForm";
            ChoicesGroup.ResumeLayout(false);
            ChoicesGroup.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_Exam;
        private Label Lbl_Question;
        private Button Btn_Next;
        private GroupBox ChoicesGroup;
        private RadioButton Answer_4;
        private RadioButton Answer_3;
        private RadioButton Answer_2;
        private RadioButton Answer_1;
        private Label Lbl_StudentName;
        private Button Btn_Submit;
    }
}