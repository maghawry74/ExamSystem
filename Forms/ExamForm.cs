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
    public partial class ExamForm : Form
    {
        ExamSystem.Models.User user;
        ExamSystemContext Db = new ExamSystemContext();
        public ExamForm(User _user)
        {
            InitializeComponent();
            DGV_Exams.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.user = Db.Users.Include(user => user.Courses).FirstOrDefault(user => user.Ssn == _user.Ssn);
            LoadAllExams();
        }
        private void Btn_AddNew_Click(object sender, EventArgs e)
        {
            ExamDetails Exam = new ExamDetails(user.Courses.ToList());
            Exam.ShowDialog();
            LoadAllExams();
        }
        void LoadAllExams()
        {
            var ExamList = Db.Exams.Include(E => E.Course).ToList();
            DGV_Exams.DataSource = ExamList.Where(E => user.Courses.Contains(E.Course))
                                           .Select(E => new { E.ExamId, E.Mark, E.Course.CourseName })
                                           .ToList();
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
