namespace ExamSystem
{
    partial class CourseForm
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
            Btn_Delete = new FontAwesome.Sharp.IconButton();
            Btn_Edit = new FontAwesome.Sharp.IconButton();
            Btn_AddNew = new FontAwesome.Sharp.IconButton();
            DGV_Course = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Course).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(Btn_Delete);
            panel1.Controls.Add(Btn_Edit);
            panel1.Controls.Add(Btn_AddNew);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(632, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(168, 450);
            panel1.TabIndex = 3;
            // 
            // Btn_Delete
            // 
            Btn_Delete.Anchor = AnchorStyles.None;
            Btn_Delete.BackColor = Color.Crimson;
            Btn_Delete.Font = new Font("Cairo SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Delete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            Btn_Delete.IconColor = Color.White;
            Btn_Delete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Btn_Delete.IconSize = 32;
            Btn_Delete.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Delete.Location = new Point(11, 128);
            Btn_Delete.Name = "Btn_Delete";
            Btn_Delete.Size = new Size(146, 58);
            Btn_Delete.TabIndex = 2;
            Btn_Delete.Text = "Delete";
            Btn_Delete.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Delete.UseVisualStyleBackColor = false;
            Btn_Delete.Click += Btn_Delete_Click;
            // 
            // Btn_Edit
            // 
            Btn_Edit.Anchor = AnchorStyles.None;
            Btn_Edit.BackColor = Color.LightSkyBlue;
            Btn_Edit.Font = new Font("Cairo SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Edit.IconChar = FontAwesome.Sharp.IconChar.SquarePen;
            Btn_Edit.IconColor = Color.White;
            Btn_Edit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Btn_Edit.IconSize = 32;
            Btn_Edit.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Edit.Location = new Point(11, 64);
            Btn_Edit.Name = "Btn_Edit";
            Btn_Edit.Size = new Size(143, 58);
            Btn_Edit.TabIndex = 1;
            Btn_Edit.Text = "Edit";
            Btn_Edit.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_Edit.UseVisualStyleBackColor = false;
            Btn_Edit.Click += Btn_Edit_Click;
            // 
            // Btn_AddNew
            // 
            Btn_AddNew.Anchor = AnchorStyles.None;
            Btn_AddNew.BackColor = Color.SpringGreen;
            Btn_AddNew.Font = new Font("Cairo SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_AddNew.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            Btn_AddNew.IconColor = Color.White;
            Btn_AddNew.IconFont = FontAwesome.Sharp.IconFont.Auto;
            Btn_AddNew.IconSize = 32;
            Btn_AddNew.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_AddNew.Location = new Point(11, 0);
            Btn_AddNew.Name = "Btn_AddNew";
            Btn_AddNew.Size = new Size(143, 58);
            Btn_AddNew.TabIndex = 0;
            Btn_AddNew.Text = "New";
            Btn_AddNew.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_AddNew.UseVisualStyleBackColor = false;
            Btn_AddNew.Click += Btn_AddNew_Click;
            // 
            // DGV_Course
            // 
            DGV_Course.AllowUserToAddRows = false;
            DGV_Course.AllowUserToDeleteRows = false;
            DGV_Course.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGV_Course.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Course.Location = new Point(0, 0);
            DGV_Course.MultiSelect = false;
            DGV_Course.Name = "DGV_Course";
            DGV_Course.ReadOnly = true;
            DGV_Course.RowHeadersWidth = 51;
            DGV_Course.RowTemplate.Height = 29;
            DGV_Course.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Course.Size = new Size(658, 450);
            DGV_Course.TabIndex = 2;
            // 
            // CourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(DGV_Course);
            Name = "CourseForm";
            Text = "CourseForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_Course).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton Btn_Delete;
        private FontAwesome.Sharp.IconButton Btn_Edit;
        private FontAwesome.Sharp.IconButton Btn_AddNew;
        private DataGridView DGV_Course;
    }
}