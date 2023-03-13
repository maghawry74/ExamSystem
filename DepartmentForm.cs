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
using System.Windows.Documents;
using System.Windows.Forms;

namespace ExamSystem
{
    public partial class DepartmentForm : Form
    {
        ExamSystemContext Db = new();
        public DepartmentForm()
        {
            InitializeComponent();
            DGV_Department.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadAllDept();
        }

        private void Btn_AddNew_Click(object sender, EventArgs e)
        {
            DepartmentDetails departmentDetails = new(null);
            departmentDetails.ShowDialog();
            LoadAllDept();
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            if(DGV_Department.SelectedRows.Count > 0)
            {
                int id;
                if(int.TryParse(DGV_Department.SelectedRows[0].Cells[0].Value.ToString(),out id))
                {
                DepartmentDetails departmentDetails = new(id);
                departmentDetails.ShowDialog();
                };
            }
            LoadAllDept();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            string DeptName = DGV_Department.SelectedRows[0].Cells[1].Value.ToString()??"Na";
            int DeptId = int.Parse(DGV_Department.SelectedRows[0].Cells[0].Value.ToString()?? "Na");
          if(MessageBox.Show($"Are You Sure To Delete Department {DeptName}", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)==DialogResult.OK)
            {
                Db.Departments.Remove(new Department()
                {
                    DepartmentId = DeptId,
                    DepartmentName= DeptName
                });
                Db.SaveChanges();
                LoadAllDept() ;
            }
        }
        void LoadAllDept()
        {
            var list = Db.Departments.FromSqlInterpolated($"Department_Select").AsEnumerable().Select(d=>new {d.DepartmentId,d.DepartmentName}).ToList();
            DGV_Department.DataSource = list;
        }
    }
}
