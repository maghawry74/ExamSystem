namespace ExamSystem
{
    partial class DepartmentDetails
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
            label2 = new Label();
            Txt_DeptId = new TextBox();
            Txt_DeptName = new TextBox();
            Btn_Save = new Button();
            Btn_Cancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Cairo", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(255, 181);
            label1.Name = "label1";
            label1.Size = new Size(203, 43);
            label1.TabIndex = 0;
            label1.Text = "Department Name";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Cairo", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(255, 80);
            label2.Name = "label2";
            label2.Size = new Size(165, 43);
            label2.TabIndex = 1;
            label2.Text = "Department ID";
            // 
            // Txt_DeptId
            // 
            Txt_DeptId.Anchor = AnchorStyles.None;
            Txt_DeptId.Enabled = false;
            Txt_DeptId.Font = new Font("Cairo", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Txt_DeptId.Location = new Point(255, 126);
            Txt_DeptId.Name = "Txt_DeptId";
            Txt_DeptId.Size = new Size(289, 45);
            Txt_DeptId.TabIndex = 2;
            // 
            // Txt_DeptName
            // 
            Txt_DeptName.Anchor = AnchorStyles.None;
            Txt_DeptName.Font = new Font("Cairo", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Txt_DeptName.Location = new Point(255, 227);
            Txt_DeptName.Name = "Txt_DeptName";
            Txt_DeptName.Size = new Size(289, 45);
            Txt_DeptName.TabIndex = 3;
            // 
            // Btn_Save
            // 
            Btn_Save.Anchor = AnchorStyles.None;
            Btn_Save.BackColor = Color.Green;
            Btn_Save.Font = new Font("Cairo SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Save.ForeColor = SystemColors.ButtonHighlight;
            Btn_Save.Location = new Point(261, 316);
            Btn_Save.Name = "Btn_Save";
            Btn_Save.Size = new Size(109, 45);
            Btn_Save.TabIndex = 4;
            Btn_Save.Text = "Save";
            Btn_Save.UseVisualStyleBackColor = false;
            Btn_Save.Click += Btn_Save_Click;
            // 
            // Btn_Cancel
            // 
            Btn_Cancel.Anchor = AnchorStyles.None;
            Btn_Cancel.BackColor = Color.IndianRed;
            Btn_Cancel.Font = new Font("Cairo SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Cancel.ForeColor = SystemColors.ButtonHighlight;
            Btn_Cancel.Location = new Point(441, 316);
            Btn_Cancel.Name = "Btn_Cancel";
            Btn_Cancel.Size = new Size(109, 45);
            Btn_Cancel.TabIndex = 5;
            Btn_Cancel.Text = "Cancel";
            Btn_Cancel.UseVisualStyleBackColor = false;
            Btn_Cancel.Click += Btn_Cancel_Click;
            // 
            // DepartmentDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Btn_Cancel);
            Controls.Add(Btn_Save);
            Controls.Add(Txt_DeptName);
            Controls.Add(Txt_DeptId);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DepartmentDetails";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox Txt_DeptId;
        private TextBox Txt_DeptName;
        private Button Btn_Save;
        private Button Btn_Cancel;
    }
}