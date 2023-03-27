namespace ExamSystem
{
    partial class CourseDetails
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
            Txt_CourseName = new TextBox();
            Txt_CourseId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            Txt_CourseDuarion = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // Btn_Cancel
            // 
            Btn_Cancel.Anchor = AnchorStyles.None;
            Btn_Cancel.BackColor = Color.IndianRed;
            Btn_Cancel.Font = new Font("Cairo SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Cancel.ForeColor = SystemColors.ButtonHighlight;
            Btn_Cancel.Location = new Point(439, 372);
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
            Btn_Save.Location = new Point(259, 372);
            Btn_Save.Name = "Btn_Save";
            Btn_Save.Size = new Size(109, 45);
            Btn_Save.TabIndex = 10;
            Btn_Save.Text = "Save";
            Btn_Save.UseVisualStyleBackColor = false;
            Btn_Save.Click += Btn_Save_Click;
            // 
            // Txt_CourseName
            // 
            Txt_CourseName.Anchor = AnchorStyles.None;
            Txt_CourseName.Font = new Font("Cairo", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Txt_CourseName.Location = new Point(259, 181);
            Txt_CourseName.Name = "Txt_CourseName";
            Txt_CourseName.Size = new Size(289, 45);
            Txt_CourseName.TabIndex = 9;
            // 
            // Txt_CourseId
            // 
            Txt_CourseId.Anchor = AnchorStyles.None;
            Txt_CourseId.Enabled = false;
            Txt_CourseId.Font = new Font("Cairo", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Txt_CourseId.Location = new Point(259, 80);
            Txt_CourseId.Name = "Txt_CourseId";
            Txt_CourseId.Size = new Size(289, 45);
            Txt_CourseId.TabIndex = 8;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Cairo", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(259, 34);
            label2.Name = "label2";
            label2.Size = new Size(113, 43);
            label2.TabIndex = 7;
            label2.Text = "Course ID";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Cairo", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(259, 135);
            label1.Name = "label1";
            label1.Size = new Size(151, 43);
            label1.TabIndex = 6;
            label1.Text = "Course Name";
            // 
            // Txt_CourseDuarion
            // 
            Txt_CourseDuarion.Anchor = AnchorStyles.None;
            Txt_CourseDuarion.Font = new Font("Cairo", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Txt_CourseDuarion.Location = new Point(259, 275);
            Txt_CourseDuarion.Name = "Txt_CourseDuarion";
            Txt_CourseDuarion.Size = new Size(289, 45);
            Txt_CourseDuarion.TabIndex = 13;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Cairo", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(259, 229);
            label3.Name = "label3";
            label3.Size = new Size(179, 43);
            label3.TabIndex = 12;
            label3.Text = "Course Duration";
            // 
            // CourseDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Txt_CourseDuarion);
            Controls.Add(label3);
            Controls.Add(Btn_Cancel);
            Controls.Add(Btn_Save);
            Controls.Add(Txt_CourseName);
            Controls.Add(Txt_CourseId);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CourseDetails";
            StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Cancel;
        private Button Btn_Save;
        private TextBox Txt_CourseName;
        private TextBox Txt_CourseId;
        private Label label2;
        private Label label1;
        private TextBox Txt_CourseDuarion;
        private Label label3;
    }
}