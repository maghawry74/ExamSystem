using ExamSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamSystem
{
    public partial class UserDetails : Form
    {
        ExamSystemContext Db = new();
        string? SSn;
        User? User;
        public UserDetails(string? id)
        {
            InitializeComponent();
            CB_UserDept.DataSource = Db.Departments.ToList();
            CB_UserDept.DisplayMember = "DepartmentName";
            CB_UserDept.ValueMember = "DepartmentId";
            Cb_UserRole.Items.Add("Ins");
            Cb_UserRole.Items.Add("Std");
            Cb_UserRole.SelectedIndex = 0;
            if (id != null)
            {
                this.SSn = id;
                User = Db.Users.Include(u => u.Department).FirstOrDefault(user => user.Ssn == id);
                Txt_UserSSN.Text = User?.Ssn;
                Txt_UserFname.Text = User?.FirstName;
                Txt_UserLname.Text = User?.LastName;
                Txt_UserPassword.Text = User?.Password;
                Txt_UserAge.Text = User?.Age.ToString();
                Cb_UserRole.SelectedItem = User?.Role;
                CB_UserDept.SelectedItem = User?.Department;
            }
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (User == null)
            {
                Db.Users.Add(new User()
                {
                    Age = int.Parse(Txt_UserAge.Text),
                    FirstName = Txt_UserFname.Text,
                    LastName = Txt_UserLname.Text,
                    Password = Txt_UserPassword.Text,
                    Role = Cb_UserRole.SelectedItem?.ToString(),
                    Ssn=Txt_UserSSN.Text,
                    DepartmentId=((Department)CB_UserDept.SelectedValue).DepartmentId
                });
            }
            else
            {
                User.Age = int.Parse(Txt_UserAge.Text);
                User.FirstName = Txt_UserFname.Text;
                User.LastName = Txt_UserLname.Text;
                User.Password = Txt_UserPassword.Text;
                User.Role = Cb_UserRole.SelectedItem?.ToString();
                User.Ssn = Txt_UserSSN.Text;
                User.DepartmentId = ((Department)CB_UserDept.SelectedValue).DepartmentId;
            }
                Db.SaveChanges();
                this.Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
