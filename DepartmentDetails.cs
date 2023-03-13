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
    public partial class DepartmentDetails : Form
    {
        ExamSystemContext Db = new ExamSystemContext();
        int? id;
        Department? department;
        public DepartmentDetails(int? id)
        {
            InitializeComponent();
           
            if (id != null)
            {
                this.id = id;
                department = Db.Departments.FirstOrDefault(dept => dept.DepartmentId == id);
                Txt_DeptId.Text = department?.DepartmentId.ToString();
                Txt_DeptName.Text = department?.DepartmentName;
                Db.SaveChanges();
            }
            else
            {
                Txt_DeptId.Text = (Db.Departments.Max(dept => dept.DepartmentId) + 1).ToString();
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (Txt_DeptName.Text == "")
            {
                MessageBox.Show("Please Fill All The Fields");
                return;
            }
            if (id == null)
            {
                Db.Departments.Add(new Department()
                {
                    DepartmentName = Txt_DeptName.Text,
                });
                Db.SaveChanges();

            }
            else
            {
                department.DepartmentName=Txt_DeptName.Text.ToString();
                Db.SaveChanges();

            }
            this.Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            Db.SaveChanges();
            this.Close();
        }
    }
}
