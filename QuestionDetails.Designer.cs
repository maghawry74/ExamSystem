namespace ExamSystem
{
    partial class QuestionDetails
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
            label1 = new Label();
            Txt_QBody = new RichTextBox();
            Num_QGrade = new NumericUpDown();
            label2 = new Label();
            Cb_QCourse = new ComboBox();
            label3 = new Label();
            Cb_Qtype = new ComboBox();
            label4 = new Label();
            Txt_QModelAnswer = new TextBox();
            label5 = new Label();
            label6 = new Label();
            Txt_Answer1 = new TextBox();
            label7 = new Label();
            Txt_Answer2 = new TextBox();
            label8 = new Label();
            Txt_Answer3 = new TextBox();
            label9 = new Label();
            Txt_Answer4 = new TextBox();
            Btn_Cancel = new Button();
            Btn_Save = new Button();
            ((System.ComponentModel.ISupportInitialize)Num_QGrade).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cairo SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(73, 31);
            label1.Name = "label1";
            label1.Size = new Size(128, 34);
            label1.TabIndex = 0;
            label1.Text = "Question Body";
            // 
            // Txt_QBody
            // 
            Txt_QBody.Location = new Point(73, 68);
            Txt_QBody.Name = "Txt_QBody";
            Txt_QBody.Size = new Size(281, 136);
            Txt_QBody.TabIndex = 1;
            Txt_QBody.Text = "";
            // 
            // Num_QGrade
            // 
            Num_QGrade.Font = new Font("Cairo SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Num_QGrade.Location = new Point(73, 265);
            Num_QGrade.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            Num_QGrade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            Num_QGrade.Name = "Num_QGrade";
            Num_QGrade.Size = new Size(281, 41);
            Num_QGrade.TabIndex = 2;
            Num_QGrade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cairo SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(73, 228);
            label2.Name = "label2";
            label2.Size = new Size(60, 34);
            label2.TabIndex = 3;
            label2.Text = "Grade";
            // 
            // Cb_QCourse
            // 
            Cb_QCourse.Font = new Font("Cairo SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Cb_QCourse.FormattingEnabled = true;
            Cb_QCourse.Location = new Point(73, 346);
            Cb_QCourse.Name = "Cb_QCourse";
            Cb_QCourse.Size = new Size(281, 45);
            Cb_QCourse.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cairo SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(73, 310);
            label3.Name = "label3";
            label3.Size = new Size(68, 34);
            label3.TabIndex = 5;
            label3.Text = "Course";
            // 
            // Cb_Qtype
            // 
            Cb_Qtype.Font = new Font("Cairo SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Cb_Qtype.FormattingEnabled = true;
            Cb_Qtype.Location = new Point(73, 434);
            Cb_Qtype.Name = "Cb_Qtype";
            Cb_Qtype.Size = new Size(281, 45);
            Cb_Qtype.TabIndex = 6;
            Cb_Qtype.SelectedValueChanged += Cb_Qtype_SelectedValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cairo SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(73, 397);
            label4.Name = "label4";
            label4.Size = new Size(51, 34);
            label4.TabIndex = 7;
            label4.Text = "Type";
            // 
            // Txt_QModelAnswer
            // 
            Txt_QModelAnswer.Font = new Font("Cairo SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Txt_QModelAnswer.Location = new Point(469, 73);
            Txt_QModelAnswer.Name = "Txt_QModelAnswer";
            Txt_QModelAnswer.Size = new Size(289, 45);
            Txt_QModelAnswer.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cairo SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(469, 36);
            label5.Name = "label5";
            label5.Size = new Size(125, 34);
            label5.TabIndex = 9;
            label5.Text = "Model Answer";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cairo SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(469, 126);
            label6.Name = "label6";
            label6.Size = new Size(87, 34);
            label6.TabIndex = 11;
            label6.Text = "Answer 1";
            // 
            // Txt_Answer1
            // 
            Txt_Answer1.Font = new Font("Cairo SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Txt_Answer1.Location = new Point(469, 163);
            Txt_Answer1.Name = "Txt_Answer1";
            Txt_Answer1.Size = new Size(292, 45);
            Txt_Answer1.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cairo SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(469, 218);
            label7.Name = "label7";
            label7.Size = new Size(87, 34);
            label7.TabIndex = 13;
            label7.Text = "Answer 2";
            // 
            // Txt_Answer2
            // 
            Txt_Answer2.Font = new Font("Cairo SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Txt_Answer2.Location = new Point(469, 255);
            Txt_Answer2.Name = "Txt_Answer2";
            Txt_Answer2.Size = new Size(295, 45);
            Txt_Answer2.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cairo SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(469, 310);
            label8.Name = "label8";
            label8.Size = new Size(87, 34);
            label8.TabIndex = 15;
            label8.Text = "Answer 3";
            // 
            // Txt_Answer3
            // 
            Txt_Answer3.Font = new Font("Cairo SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Txt_Answer3.Location = new Point(469, 347);
            Txt_Answer3.Name = "Txt_Answer3";
            Txt_Answer3.Size = new Size(298, 45);
            Txt_Answer3.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cairo SemiBold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(469, 397);
            label9.Name = "label9";
            label9.Size = new Size(87, 34);
            label9.TabIndex = 17;
            label9.Text = "Answer 4";
            // 
            // Txt_Answer4
            // 
            Txt_Answer4.Font = new Font("Cairo SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Txt_Answer4.Location = new Point(469, 434);
            Txt_Answer4.Name = "Txt_Answer4";
            Txt_Answer4.Size = new Size(301, 45);
            Txt_Answer4.TabIndex = 16;
            // 
            // Btn_Cancel
            // 
            Btn_Cancel.Anchor = AnchorStyles.None;
            Btn_Cancel.BackColor = Color.IndianRed;
            Btn_Cancel.Font = new Font("Cairo SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Cancel.ForeColor = SystemColors.ButtonHighlight;
            Btn_Cancel.Location = new Point(432, 533);
            Btn_Cancel.Name = "Btn_Cancel";
            Btn_Cancel.Size = new Size(109, 45);
            Btn_Cancel.TabIndex = 21;
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
            Btn_Save.Location = new Point(252, 533);
            Btn_Save.Name = "Btn_Save";
            Btn_Save.Size = new Size(109, 45);
            Btn_Save.TabIndex = 20;
            Btn_Save.Text = "Save";
            Btn_Save.UseVisualStyleBackColor = false;
            Btn_Save.Click += Btn_Save_Click;
            // 
            // QuestionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 610);
            Controls.Add(Btn_Cancel);
            Controls.Add(Btn_Save);
            Controls.Add(label9);
            Controls.Add(Txt_Answer4);
            Controls.Add(label8);
            Controls.Add(Txt_Answer3);
            Controls.Add(label7);
            Controls.Add(Txt_Answer2);
            Controls.Add(label6);
            Controls.Add(Txt_Answer1);
            Controls.Add(label5);
            Controls.Add(Txt_QModelAnswer);
            Controls.Add(label4);
            Controls.Add(Cb_Qtype);
            Controls.Add(label3);
            Controls.Add(Cb_QCourse);
            Controls.Add(label2);
            Controls.Add(Num_QGrade);
            Controls.Add(Txt_QBody);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "QuestionForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "QuestionForm";
            ((System.ComponentModel.ISupportInitialize)Num_QGrade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox Txt_QBody;
        private NumericUpDown Num_QGrade;
        private Label label2;
        private ComboBox Cb_QCourse;
        private Label label3;
        private ComboBox Cb_Qtype;
        private Label label4;
        private TextBox Txt_QModelAnswer;
        private Label label5;
        private Label label6;
        private TextBox Txt_Answer1;
        private Label label7;
        private TextBox Txt_Answer2;
        private Label label8;
        private TextBox Txt_Answer3;
        private Label label9;
        private TextBox Txt_Answer4;
        private Button Btn_Cancel;
        private Button Btn_Save;
    }
}