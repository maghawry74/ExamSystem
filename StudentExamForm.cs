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

    public partial class StudentExamForm : Form
    {
        Exam exam;
        User Student;
        List<Question> questions;
        int QuestionCounter = 0;
        ExamSystemContext Db = new();
        public StudentExamForm(Exam exam, User Student)
        {
            this.exam = exam;
            this.Student = Student;
            InitializeComponent();
            this.Lbl_Exam.Text = $"{exam?.Course?.CourseName} Exam";
            Lbl_StudentName.Text = $"{Student.FirstName} {Student.LastName}";
            questions = exam.Questions.ToList();
            DisplayQuestionWithAnswers();
        }
        private void Btn_Next_Click(object sender, EventArgs e)
        {
            int ExamId = exam.ExamId;
            string StudentId = Student.Ssn;
            int QuestionId = questions[QuestionCounter].QuestionId;
            string QuestionAnswer = "";
            foreach (RadioButton ite in ChoicesGroup.Controls)
            {
                if (ite.Checked)
                {
                    QuestionAnswer = ite.Text;
                    ite.Checked = false;
                }
            }

            Db.Database.ExecuteSql($"ExamAnswer {ExamId},{StudentId},{QuestionId},{QuestionAnswer}");
            QuestionCounter++;
            DisplayQuestionWithAnswers();
        }
        private void DisplayQuestionWithAnswers()
        {
            if (QuestionCounter < questions.Count && QuestionCounter >= 0)
            {

                Lbl_Question.Text = questions[QuestionCounter].Body;
                if (questions[QuestionCounter].Type == "MCQ")
                {
                    Answer_1.Text = questions[QuestionCounter].Answers.ToList()[0].QuestionAnswer;
                    Answer_2.Text = questions[QuestionCounter].Answers.ToList()[1].QuestionAnswer;
                    Answer_3.Text = questions[QuestionCounter].Answers.ToList()[2].QuestionAnswer;
                    Answer_4.Text = questions[QuestionCounter].Answers.ToList()[3].QuestionAnswer;
                }
                else
                {
                    Answer_1.Text = questions[QuestionCounter].Answers.ToList()[0].QuestionAnswer;
                    Answer_2.Text = questions[QuestionCounter].Answers.ToList()[1].QuestionAnswer;
                    Answer_3.Visible = false;
                    Answer_4.Visible = false;
                }
            }
            else
            {
                Btn_Next.Visible = false;
                Btn_Submit.Visible = true;
            }
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            Db.Database.ExecuteSql($"ExamCorection {Student.Ssn},{exam.ExamId}");
        }
    }
}
