namespace ExamSystem
{
    partial class UsersForm
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
            UserCRUDPanel = new Panel();
            Btn_Delete = new FontAwesome.Sharp.IconButton();
            Btn_Edit = new FontAwesome.Sharp.IconButton();
            Btn_AddNew = new FontAwesome.Sharp.IconButton();
            DGV_Users = new DataGridView();
            UserCRUDPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGV_Users).BeginInit();
            SuspendLayout();
            // 
            // UserCRUDPanel
            // 
            UserCRUDPanel.BackColor = SystemColors.ActiveCaption;
            UserCRUDPanel.Controls.Add(Btn_Delete);
            UserCRUDPanel.Controls.Add(Btn_Edit);
            UserCRUDPanel.Controls.Add(Btn_AddNew);
            UserCRUDPanel.Dock = DockStyle.Right;
            UserCRUDPanel.Location = new Point(654, 0);
            UserCRUDPanel.Name = "UserCRUDPanel";
            UserCRUDPanel.Size = new Size(146, 450);
            UserCRUDPanel.TabIndex = 3;
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
            Btn_Delete.Location = new Point(0, 274);
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
            Btn_Edit.Location = new Point(0, 210);
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
            Btn_AddNew.Location = new Point(0, 146);
            Btn_AddNew.Name = "Btn_AddNew";
            Btn_AddNew.Size = new Size(143, 58);
            Btn_AddNew.TabIndex = 0;
            Btn_AddNew.Text = "New";
            Btn_AddNew.TextImageRelation = TextImageRelation.ImageBeforeText;
            Btn_AddNew.UseVisualStyleBackColor = false;
            Btn_AddNew.Click += Btn_AddNew_Click;
            // 
            // DGV_Users
            // 
            DGV_Users.AllowUserToAddRows = false;
            DGV_Users.AllowUserToDeleteRows = false;
            DGV_Users.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DGV_Users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_Users.Location = new Point(0, 0);
            DGV_Users.MultiSelect = false;
            DGV_Users.Name = "DGV_Users";
            DGV_Users.ReadOnly = true;
            DGV_Users.RowHeadersWidth = 51;
            DGV_Users.RowTemplate.Height = 29;
            DGV_Users.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGV_Users.Size = new Size(648, 450);
            DGV_Users.TabIndex = 2;
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(UserCRUDPanel);
            Controls.Add(DGV_Users);
            Name = "UsersForm";
            Text = "UsersForm";
            UserCRUDPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DGV_Users).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel UserCRUDPanel;
        private FontAwesome.Sharp.IconButton Btn_Delete;
        private FontAwesome.Sharp.IconButton Btn_Edit;
        private FontAwesome.Sharp.IconButton Btn_AddNew;
        private DataGridView DGV_Users;
    }
}