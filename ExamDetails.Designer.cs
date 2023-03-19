namespace ExamSystem
{
    partial class ExamDetails
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
            label3 = new Label();
            Btn_Cancel = new Button();
            Btn_Save = new Button();
            label1 = new Label();
            MCQNum = new NumericUpDown();
            TFNum = new NumericUpDown();
            CB_Course = new ComboBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)MCQNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)TFNum).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Cairo", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(223, 165);
            label3.Name = "label3";
            label3.Size = new Size(151, 43);
            label3.TabIndex = 20;
            label3.Text = "#TF Question";
            // 
            // Btn_Cancel
            // 
            Btn_Cancel.Anchor = AnchorStyles.None;
            Btn_Cancel.BackColor = Color.IndianRed;
            Btn_Cancel.Font = new Font("Cairo SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Cancel.ForeColor = SystemColors.ButtonHighlight;
            Btn_Cancel.Location = new Point(404, 401);
            Btn_Cancel.Name = "Btn_Cancel";
            Btn_Cancel.Size = new Size(109, 45);
            Btn_Cancel.TabIndex = 19;
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
            Btn_Save.Location = new Point(224, 401);
            Btn_Save.Name = "Btn_Save";
            Btn_Save.Size = new Size(109, 45);
            Btn_Save.TabIndex = 18;
            Btn_Save.Text = "Save";
            Btn_Save.UseVisualStyleBackColor = false;
            Btn_Save.Click += Btn_Save_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Cairo", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(223, 71);
            label1.Name = "label1";
            label1.Size = new Size(184, 43);
            label1.TabIndex = 14;
            label1.Text = "#MCQ Questions";
            // 
            // MCQNum
            // 
            MCQNum.Anchor = AnchorStyles.None;
            MCQNum.Font = new Font("Cairo", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MCQNum.Location = new Point(224, 117);
            MCQNum.Name = "MCQNum";
            MCQNum.Size = new Size(288, 45);
            MCQNum.TabIndex = 21;
            // 
            // TFNum
            // 
            TFNum.Anchor = AnchorStyles.None;
            TFNum.Font = new Font("Cairo", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TFNum.Location = new Point(223, 211);
            TFNum.Name = "TFNum";
            TFNum.Size = new Size(288, 45);
            TFNum.TabIndex = 22;
            // 
            // CB_Course
            // 
            CB_Course.Anchor = AnchorStyles.None;
            CB_Course.Font = new Font("Cairo", 12F, FontStyle.Bold, GraphicsUnit.Point);
            CB_Course.FormattingEnabled = true;
            CB_Course.Location = new Point(224, 305);
            CB_Course.Name = "CB_Course";
            CB_Course.Size = new Size(289, 45);
            CB_Course.TabIndex = 23;
            CB_Course.SelectedIndexChanged += CB_Course_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Cairo", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(223, 259);
            label4.Name = "label4";
            label4.Size = new Size(87, 43);
            label4.TabIndex = 24;
            label4.Text = "Course";
            // 
            // ExamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 531);
            Controls.Add(label4);
            Controls.Add(CB_Course);
            Controls.Add(TFNum);
            Controls.Add(MCQNum);
            Controls.Add(label3);
            Controls.Add(Btn_Cancel);
            Controls.Add(Btn_Save);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ExamForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ExamForm";
            ((System.ComponentModel.ISupportInitialize)MCQNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)TFNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button Btn_Cancel;
        private Button Btn_Save;
        private Label label1;
        private NumericUpDown MCQNum;
        private NumericUpDown TFNum;
        private ComboBox CB_Course;
        private Label label4;
    }
}