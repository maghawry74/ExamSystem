using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamSystem
{

    public partial class Admin : Form
    {
        Form? ActiveForm;
        Button? currentButton;
        public Admin()
        {
            InitializeComponent();
            Btn_Dept_Click(Btn_Dept, null);
        }
        void ActiveButton(object sender)
        {
            if ((Button)sender != currentButton)
            {
                DisableButton();
                currentButton = sender as Button;
                currentButton.BackColor = Color.Red;
            }
        }
        void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(51, 52, 78);
            }
        }

        private void Btn_Dept_Click(object sender, EventArgs e)
        {
            LoadChildForm(new DepartmentForm(), sender);
        }

        private void Btn_Users_Click(object sender, EventArgs e)
        {
            LoadChildForm(new UsersForm(), sender);
        }
        private void Btn_Course_Click(object sender, EventArgs e)
        {
            LoadChildForm(new CourseForm(), sender);
        }
        void LoadChildForm(Form childForm, object sender)
        {
            if (ActiveForm != null)
                ActiveForm.Close();
            ActiveButton(sender);
            ActiveForm = childForm;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            DesktopPanel.Controls.Add(ActiveForm);
            DesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            HeaderLabel.Text = childForm.Name;

        }


    }
}
