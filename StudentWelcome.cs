using ExamSystem.Models;
using Microsoft.EntityFrameworkCore;
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
    public partial class StudentWelcome : Form
    {
        User student;
        public StudentWelcome(User Student)
        {
            this.student = Student;
            InitializeComponent();
            this.Lbl_Welcome.Text = $"Welcome {Student.FirstName}";
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            int ExamId;
            if (int.TryParse(Txt_ExamId.Text, out ExamId))
            {
                using (ExamSystemContext Db = new ExamSystemContext())
                {
                    Exam exam = Db.Exams.Include(Ex=>Ex.Course).Include(Ex=>Ex.Questions).ThenInclude(Q=>Q.Answers).FirstOrDefault(Ex=>Ex.ExamId==ExamId);
                    if (exam == null)
                    {
                        MessageBox.Show("Exam Number isn't Found", "Alert", MessageBoxButtons.OK);
                    }
                    else
                    {
                        this.Hide();
                        new StudentExamForm(exam,student).ShowDialog();
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Only Numbers Are Allowed");
            }
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
