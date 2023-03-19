using ExamSystem.Models;
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
    public partial class QuestionDetails : Form
    {
        int QuestionId;
        ExamSystemContext Db = new();
        public QuestionDetails(List<Course> courses)
        {
            InitializeComponent();
            QuestionId = Db.Questions.Max(x => x.QuestionId) + 1;
            Cb_QCourse.DataSource= courses;
            Cb_QCourse.DisplayMember = "CourseName";
            Cb_QCourse.ValueMember = "CourseId";
            Cb_Qtype.Items.Add("TF");
            Cb_Qtype.Items.Add("MCQ");
            Cb_Qtype.SelectedIndex = 0;
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (!checkInputs())
            {
                MessageBox.Show("Please Fill All Fields");
                return;
            }
            List<Answer> answers;
            Question newQuestion = new()
            {
                Body = Txt_QBody.Text,
                CourseId = ((Course)Cb_QCourse.SelectedItem).CourseId,
                ModelAnswer = Txt_QModelAnswer.Text,
                Grade = int.Parse(Num_QGrade.Value.ToString()),
                Type = Cb_Qtype.SelectedItem.ToString(),
            };
            if (Cb_Qtype.SelectedItem.ToString() == "TF")
            {
                answers = new List<Answer>()
                {
                    new Answer()
                    {
                        QuestionId= QuestionId,
                        QuestionAnswer="True"
                    },
                    new Answer()
                    {
                        QuestionId= QuestionId,
                        QuestionAnswer="False"
                    },
                };
            }
            else
            {
                answers = new List<Answer>()
                {
                    new Answer()
                    {
                        QuestionId= QuestionId,
                        QuestionAnswer=Txt_Answer1.Text
                    },
                    new Answer()
                    {
                        QuestionId= QuestionId,
                        QuestionAnswer=Txt_Answer2.Text
                    },
                    new Answer()
                    {
                        QuestionId= QuestionId,
                        QuestionAnswer=Txt_Answer3.Text
                    },
                    new Answer()
                    {
                        QuestionId= QuestionId,
                        QuestionAnswer=Txt_Answer4.Text
                    },
                };
            }
            newQuestion.Answers = answers;
            Db.Questions.Add(newQuestion);
            Db.SaveChanges();
            this.Close();
        }
        private bool checkInputs()
        {
            return Txt_QBody.Text != "" && Txt_QModelAnswer.Text != "" && Txt_Answer1.Text != ""
                    && Txt_Answer2.Text != "" && Txt_Answer3.Text != "" && Txt_Answer4.Text != ""
                    && Txt_Answer1.Text != "";
        }

        private void Cb_Qtype_SelectedValueChanged(object sender, EventArgs e)
        {
            if(Cb_Qtype.SelectedItem.ToString() == "TF")
            {
                Txt_Answer1.Enabled = false;
                Txt_Answer2.Enabled = false;
                Txt_Answer3.Enabled = false;
                Txt_Answer4.Enabled = false;
            }
            else
            {
                Txt_Answer1.Enabled = true;
                Txt_Answer2.Enabled = true;
                Txt_Answer3.Enabled = true;
                Txt_Answer4.Enabled = true;
            }
        }
    }
}
