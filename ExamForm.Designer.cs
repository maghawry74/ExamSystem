namespace ExamSystem
{
    partial class ExamForm
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
            panel4 = new Panel();
            Btn_Delete = new FontAwesome.Sharp.IconButton();
            Btn_AddNew = new FontAwesome.Sharp.IconButton();
            DGV_Exams = new DataGridView();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Exams).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveCaption;
            panel4.Controls.Add(Btn_Delete);
            panel4.Controls.Add(Btn_AddNew);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(620, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(180, 450);
            panel4.TabIndex = 5;
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
            Btn_Delete.Location = new Point(22, 67);
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
            Btn_AddNew.Location = new Point(22, 3);
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
            DGV_Exams.Location = new Point(1, 0);
            DGV_Exams.MultiSelect = false;
            DGV_Exams.Name = "DGV_Exams";
            DGV_Exams.ReadOnly = true;
            DGV_Exams.RowHeadersWidth = 51;
            DGV_Exams.RowTemplate.Height = 29;
            DGV_Exams.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Exams.Size = new Size(618, 450);
            DGV_Exams.TabIndex = 4;
            // 
            // ExamForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel4);
            Controls.Add(DGV_Exams);
            Name = "ExamForm";
            Text = "ExamForm";
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_Exams).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel4;
        private FontAwesome.Sharp.IconButton Btn_Delete;
        private FontAwesome.Sharp.IconButton Btn_AddNew;
        private DataGridView DGV_Exams;
    }
}