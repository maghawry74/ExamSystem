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
            Lbl_StudentName = new Label();
            Btn_Submit = new Button();
            Btn_Prev = new Button();
            Lbl_Counter = new Label();
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
            Lbl_Question.AutoEllipsis = true;
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
            ChoicesGroup.Font = new Font("Cairo SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ChoicesGroup.Location = new Point(59, 145);
            ChoicesGroup.Name = "ChoicesGroup";
            ChoicesGroup.Size = new Size(970, 260);
            ChoicesGroup.TabIndex = 7;
            ChoicesGroup.TabStop = false;
            ChoicesGroup.Text = "Choices";
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
            // Btn_Prev
            // 
            Btn_Prev.BackColor = Color.Coral;
            Btn_Prev.Font = new Font("Cairo SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Prev.ForeColor = SystemColors.ButtonHighlight;
            Btn_Prev.Location = new Point(59, 411);
            Btn_Prev.Name = "Btn_Prev";
            Btn_Prev.Size = new Size(119, 49);
            Btn_Prev.TabIndex = 10;
            Btn_Prev.Text = "Previous";
            Btn_Prev.UseVisualStyleBackColor = false;
            Btn_Prev.Click += Btn_Prev_Click;
            // 
            // Lbl_Counter
            // 
            Lbl_Counter.AutoSize = true;
            Lbl_Counter.Font = new Font("Cairo SemiBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_Counter.Location = new Point(463, 67);
            Lbl_Counter.Name = "Lbl_Counter";
            Lbl_Counter.Size = new Size(96, 53);
            Lbl_Counter.TabIndex = 8;
            Lbl_Counter.Text = "label1";
            // 
            // StudentExamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 472);
            Controls.Add(Btn_Prev);
            Controls.Add(Btn_Submit);
            Controls.Add(Lbl_Counter);
            Controls.Add(Lbl_StudentName);
            Controls.Add(ChoicesGroup);
            Controls.Add(Btn_Next);
            Controls.Add(Lbl_Question);
            Controls.Add(Lbl_Exam);
            Name = "StudentExamForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "StudentExamForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl_Exam;
        private Label Lbl_Question;
        private Button Btn_Next;
        private GroupBox ChoicesGroup;
        private Label Lbl_StudentName;
        private Button Btn_Submit;
        private Button Btn_Prev;
        private Label Lbl_Counter;
    }
}