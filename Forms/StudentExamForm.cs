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

namespace ExamSystem;


public partial class StudentExamForm : Form
{
    Exam exam;
    User Student;
    List<Question> questions;
    Dictionary<int, string> StudentAnswers;
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
        StudentAnswers = new Dictionary<int, string>(questions.Count);
        DisplayQuestionWithAnswers();
    }
    private void Btn_Next_Click(object sender, EventArgs e)
    {
        getAnswers();
        QuestionCounter++;
        DisplayQuestionWithAnswers();
    }
    private void Btn_Prev_Click(object sender, EventArgs e)
    {
        getAnswers();
        QuestionCounter--;
        DisplayQuestionWithAnswers();
    }
    private void Btn_Submit_Click(object sender, EventArgs e)
    {
        getAnswers();
        int ExamId = exam.ExamId;
        string StudentId = Student.Ssn;
        foreach (var item in StudentAnswers)
        {
            Db.Database.ExecuteSql($"ExamAnswer {ExamId},{StudentId},{item.Key},{item.Value}");
        }
        Db.Database.ExecuteSql($"ExamCorection {Student.Ssn},{exam.ExamId}");
        MessageBox.Show("Exam Has Been Submitted Successfully");
        this.Close();
    }
    private void DisplayQuestionWithAnswers()
    {
        Btn_Prev.Visible = QuestionCounter > 0;
        Btn_Next.Visible = QuestionCounter < (questions.Count - 1);
        Btn_Submit.Visible = !(QuestionCounter < (questions.Count - 1));
        if (QuestionCounter < questions.Count && QuestionCounter >= 0)
        {
            string? checkedAnswer = StudentAnswers.GetValueOrDefault(questions[QuestionCounter].QuestionId);
            ChoicesGroup.Controls.Clear();
            Lbl_Question.Text = $"{QuestionCounter + 1}- {questions[QuestionCounter].Body}";
            for (int i = 0; i < questions[QuestionCounter].Answers.Count; i++)
            {
                RadioButton radioButton = new RadioButton();
                radioButton.Text = questions[QuestionCounter].Answers.ToList()[i].QuestionAnswer;
                radioButton.Font = new Font("Cairo", 10);
                radioButton.Height = 45;
                radioButton.Width = 200;
                radioButton.Top = 50 + i * 50;
                radioButton.Left = 20;
                radioButton.Checked = (questions[QuestionCounter].Answers.ToList()[i].QuestionAnswer) == checkedAnswer;
                ChoicesGroup.Controls.Add(radioButton);
            }
        }
    }
    void getAnswers()
    {
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
        StudentAnswers[QuestionId] = QuestionAnswer;
    }
}
