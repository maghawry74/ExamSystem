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
    public partial class CourseForm : Form
    {
        ExamSystemContext Db = new();
        public CourseForm()
        {
            InitializeComponent();
            DGV_Course.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadAllCourse();
        }



        void LoadAllCourse()
        {
            var CourseList = Db.Courses.FromSqlInterpolated($"Course_Select").AsEnumerable().Select(crs => new { crs.CourseId, crs.CourseName, crs.Duration }).ToList();
            DGV_Course.DataSource = CourseList;
        }

        private void Btn_AddNew_Click(object sender, EventArgs e)
        {
            CourseDetails form = new CourseDetails(null);
            form.ShowDialog();
            LoadAllCourse();
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            int id = int.Parse(DGV_Course.SelectedRows[0].Cells[0].Value.ToString());
            CourseDetails form = new CourseDetails(id);
            form.ShowDialog();
            LoadAllCourse();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            string CourseName = DGV_Course.SelectedRows[0].Cells[1].Value.ToString() ?? "Na";
            int CourseId = int.Parse(DGV_Course.SelectedRows[0].Cells[0].Value.ToString() ?? "Na");
            if (MessageBox.Show($"Are You Sure To Delete Department {CourseName}", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                var removedCourse = Db.Courses.FirstOrDefault(crs => crs.CourseId == CourseId);
                Db.Courses.Remove(removedCourse);
                Db.SaveChanges();
                LoadAllCourse();
            }
        }
    }
}
