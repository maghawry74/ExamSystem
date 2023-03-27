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
    public partial class CourseDetails : Form
    {
        ExamSystemContext Db = new ExamSystemContext();
        int? id;
        Course? course;
        public CourseDetails(int? id)
        {
            InitializeComponent();
            if (id != null)
            {
                this.id = id;
                course = Db.Courses.FirstOrDefault(crs => crs.CourseId == id);
                Txt_CourseId.Text = course.CourseId.ToString();
                Txt_CourseName.Text = course.CourseName;
                Txt_CourseDuarion.Text = course.Duration.ToString();
            }
            else
            {
                Txt_CourseId.Text = (Db.Courses.Max(crs => crs.CourseId) + 1).ToString();
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (Txt_CourseDuarion.Text == "" || Txt_CourseDuarion.Text=="")
            {
                MessageBox.Show("Please Fill All The Fields");
                return;
            }
            if (id != null)
            {
                course.Duration = int.Parse(Txt_CourseDuarion.Text);
                course.CourseName = Txt_CourseName.Text;
                Db.SaveChanges();
            }
            else
            {
                Db.Courses.Add(new Course()
                {
                    Duration= int.Parse(Txt_CourseDuarion.Text),
                    CourseName= Txt_CourseName.Text,
                });
                Db.SaveChanges();
            }
            this.Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
