using ExamSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamSystem;

public partial class InstructorForm : Form
{
    Form? ActiveForm;
    Button? currentButton;
    ExamSystem.Models.User user;
    ExamSystemContext Db = new ExamSystemContext();
    public InstructorForm(ExamSystem.Models.User _user)
    {
        InitializeComponent();
        this.user = Db.Users.Include(user => user.Courses).FirstOrDefault(user => user.Ssn == _user.Ssn);
        Lbl_InsName.Text = $"Welcome\n{user.FirstName}";
        Btn_Exams_Click(Btn_Exams, null);
    }

    private void Btn_Exams_Click(object sender, EventArgs e)
    {
        LoadChildForm(new ExamForm(user), sender);
    }

    private void Btn_Questions_Click(object sender, EventArgs e)
    {
        LoadChildForm(new QuestionForm(user), sender);
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
