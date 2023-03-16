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
    public partial class UsersForm : Form
    {
        ExamSystemContext Db = new();

        public UsersForm()
        {
            InitializeComponent();
            DGV_Users.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            LoadAllUsers();
        }

        private void Btn_AddNew_Click(object sender, EventArgs e)
        {
            UserDetails userDetails = new UserDetails(null);
            userDetails.ShowDialog();
            LoadAllUsers();
        }

        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            string Ssn = DGV_Users?.SelectedRows[0]?.Cells[0]?.Value?.ToString();
            UserDetails userDetails = new UserDetails(Ssn);
            userDetails.ShowDialog();
            LoadAllUsers();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            string UserName = DGV_Users.SelectedRows[0].Cells[1].Value.ToString() ?? "Na";
            string UserId = DGV_Users.SelectedRows[0].Cells[0].Value.ToString() ?? "Na";
            if (MessageBox.Show($"Are You Sure To Delete USer {UserName}", "Alert", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                var DeletedUser = Db.Users.FirstOrDefault(user => user.Ssn == UserId);
                Db.Users.Remove(DeletedUser);
                Db.SaveChanges();
                LoadAllUsers();
            }
        }
        void LoadAllUsers()
        {
            var list = Db.Users.Include(user => user.Department).Select(user => new
            {
                user.Ssn,
                Name = $"{user.FirstName} {user.LastName}",
                user.Age,
                Department = user.Department.DepartmentName ?? "Na",
                user.Role,
                user.Password
            }).ToList();
            DGV_Users.DataSource = list;
        }
    }
}
