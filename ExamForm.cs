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
        ExamSystemContext Db = new ExamSystemContext();
        public ExamForm()
        {
            InitializeComponent();
            CB_Course.DataSource = Db.Courses.Include(crs => crs.Questions).ToList();
            CB_Course.DisplayMember = "CourseName";
            CB_Course.ValueMember = "CourseId";
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (MCQNum.Value == 0 && TFNum.Value == 0)
            {
                MessageBox.Show("Please Select Number Of Questions");
            }
            else
            {
                int NumMCQ = (int)MCQNum.Value;
                int NumTF = (int)TFNum.Value;
                int CrsID = ((Course)CB_Course.SelectedItem).CourseId;
                Db.Database.ExecuteSql($"GenerateExam {CrsID}, {NumMCQ}, {NumTF}");
                Db.SaveChanges();
                this.Close();
            }
        }

        private void CB_Course_SelectedIndexChanged(object sender, EventArgs e)
        {
            Course SelectedCrs = (Course)CB_Course.SelectedItem;
            MCQNum.Maximum = SelectedCrs.Questions.Count(q => q.Type == "MCQ");
            TFNum.Maximum = SelectedCrs.Questions.Count(q => q.Type == "TF");
        }
    }
}
