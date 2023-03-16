namespace ExamSystem
{
    partial class InstructorForm
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
            panel1 = new Panel();
            Lbl_InsName = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            Btn_Delete = new FontAwesome.Sharp.IconButton();
            Btn_AddNew = new FontAwesome.Sharp.IconButton();
            DGV_Exams = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Exams).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 52, 78);
            panel1.Controls.Add(Lbl_InsName);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(202, 420);
            panel1.TabIndex = 0;
            // 
            // Lbl_InsName
            // 
            Lbl_InsName.Anchor = AnchorStyles.Top;
            Lbl_InsName.AutoSize = true;
            Lbl_InsName.FlatStyle = FlatStyle.Flat;
            Lbl_InsName.Font = new Font("Cairo", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            Lbl_InsName.ForeColor = SystemColors.ButtonHighlight;
            Lbl_InsName.Location = new Point(42, 31);
            Lbl_InsName.Name = "Lbl_InsName";
            Lbl_InsName.Size = new Size(78, 43);
            Lbl_InsName.TabIndex = 0;
            Lbl_InsName.Text = "Name";
            Lbl_InsName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(0, 134, 138);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(201, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(624, 110);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Cairo SemiBold", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(260, 40);
            label1.Name = "label1";
            label1.Size = new Size(85, 43);
            label1.TabIndex = 2;
            label1.Text = "Exams";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(DGV_Exams);
            panel3.Location = new Point(201, 107);
            panel3.Name = "panel3";
            panel3.Size = new Size(624, 313);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(Btn_Delete);
            panel4.Controls.Add(Btn_AddNew);
            panel4.Location = new Point(478, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(146, 313);
            panel4.TabIndex = 3;
            // 
            // Btn_Delete
            // 
            Btn_Delete.Anchor = AnchorStyles.Top;
            Btn_Delete.BackColor = Color.Crimson;
            Btn_Delete.Font = new Font("Cairo SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Delete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            Btn_Delete.IconColor = Color.White;
            Btn_Delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Btn_Delete.IconSize = 32;
            Btn_Delete.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Delete.Location = new Point(3, 84);
            Btn_Delete.Name = "Btn_Delete";
            Btn_Delete.Size = new Size(146, 58);
            Btn_Delete.TabIndex = 3;
            Btn_Delete.Text = "Delete";
            Btn_Delete.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Delete.UseVisualStyleBackColor = false;
            Btn_Delete.Click += Btn_Delete_Click;
            // 
            // Btn_AddNew
            // 
            Btn_AddNew.Anchor = AnchorStyles.Top;
            Btn_AddNew.BackColor = Color.SpringGreen;
            Btn_AddNew.Font = new Font("Cairo SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_AddNew.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            Btn_AddNew.IconColor = Color.White;
            Btn_AddNew.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Btn_AddNew.IconSize = 32;
            Btn_AddNew.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_AddNew.Location = new Point(3, 9);
            Btn_AddNew.Name = "Btn_AddNew";
            Btn_AddNew.Size = new Size(143, 58);
            Btn_AddNew.TabIndex = 0;
            Btn_AddNew.Text = "New";
            Btn_AddNew.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_AddNew.UseVisualStyleBackColor = false;
            Btn_AddNew.Click += Btn_AddNew_Click;
            // 
            // DGV_Exams
            // 
            DGV_Exams.AllowUserToAddRows = false;
            DGV_Exams.AllowUserToDeleteRows = false;
            DGV_Exams.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGV_Exams.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Exams.Location = new Point(0, 0);
            DGV_Exams.MultiSelect = false;
            DGV_Exams.Name = "DGV_Exams";
            DGV_Exams.ReadOnly = true;
            DGV_Exams.RowHeadersWidth = 51;
            DGV_Exams.RowTemplate.Height = 29;
            DGV_Exams.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Exams.Size = new Size(479, 313);
            DGV_Exams.TabIndex = 2;
            // 
            // InstructorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 420);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "InstructorForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InstructorForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_Exams).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label Lbl_InsName;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private FontAwesome.Sharp.IconButton Btn_AddNew;
        private DataGridView DGV_Exams;
        private FontAwesome.Sharp.IconButton Btn_Delete;
    }
}