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

namespace ExamSystem
{
    public partial class InstructorForm : Form
    {
        ExamSystem.Models.User user;
        ExamSystemContext Db = new ExamSystemContext();
        public InstructorForm(ExamSystem.Models.User user)
        {
            InitializeComponent();
            DGV_Exams.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.user = user;
            Lbl_InsName.Text = $"Welcome\n{user.FirstName}";
            LoadAllExams();
        }

        private void Btn_AddNew_Click(object sender, EventArgs e)
        {
            ExamForm Exam = new ExamForm();
            Exam.ShowDialog();
            LoadAllExams();
        }
        void LoadAllExams()
        {
            var CourseList = Db.Exams.Include(E => E.Course).Select(E => new { E.ExamId, E.Mark, E.Course.CourseName }).ToList();
            DGV_Exams.DataSource = CourseList;
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (DGV_Exams.SelectedRows.Count > 0)
            {
                int Exam_Id = int.Parse(DGV_Exams.SelectedRows[0].Cells[0].Value.ToString());
                Db.Exams.Remove(new Exam() { ExamId = Exam_Id });
                Db.SaveChanges();
                LoadAllExams();
            }
        }
    }
}
