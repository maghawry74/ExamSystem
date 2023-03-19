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
    public partial class QuestionForm : Form
    {
        List<Course> courses;
        ExamSystemContext Db = new();
        public QuestionForm(User user)
        {
            courses = user.Courses.ToList();
            InitializeComponent();
            loadAllQuestions();
            DGV_Questions.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Btn_AddNew_Click(object sender, EventArgs e)
        {
            var QuestionDetails=new QuestionDetails(courses).ShowDialog();
            loadAllQuestions();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {

        }
        void loadAllQuestions()
        {
            var Ques = Db.Questions.Include(q => q.Course).Where(q => courses.Contains(q.Course)).ToList();
            DGV_Questions.DataSource = Ques.Select(q=>new
            {
               q.QuestionId,
               q.Body,
               q.Grade,
               q.Course.CourseName,
               q.ModelAnswer,
               q.Type
            }).ToList();
        }
    }
}
