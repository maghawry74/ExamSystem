using ExamSystem.Models;

namespace ExamSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            Txt_SSN_Enter(null, null);
        }


        private void Btn_Login_Click(object sender, EventArgs e)
        {
            string? SSN = Txt_SSN.Text;
            string? Password = Txt_Password.Text;
            if (SSN == "" || Password == "")
            {
                MessageBox.Show("Please Enter Your credentials");
                return;
            }
            using (ExamSystemContext Db = new ExamSystemContext())
            {
                var LoginResult = Db.Users.FirstOrDefault(user => (user.Ssn == SSN) && user.Password == Password);
                if (LoginResult == null)
                {
                    MessageBox.Show("Wrong credentials");
                }
                else
                {
                    switch (LoginResult.Role)
                    {
                        case "Admin":
                            Admin newAdmin = new Admin();
                            this.Hide();
                            newAdmin.ShowDialog();
                            this.Show();
                            break;
                        case "Ins":
                            InstructorForm newInstructor = new InstructorForm(LoginResult);
                            this.Hide();
                            newInstructor.ShowDialog();
                            this.Show();
                            break;
                        default:
                            this.Hide();
                            new StudentWelcome(LoginResult).ShowDialog();
                            this.Show();
                            break;
                    }
                }
            }
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_SSN_Enter(object? sender, EventArgs? e)
        {
            PasswordPanel.BackColor = SystemColors.Control;
            Txt_Password.BackColor = SystemColors.Control;
            UserPanel.BackColor = Color.White;
            Txt_SSN.BackColor = Color.White;
        }

        private void Txt_Password_Enter(object sender, EventArgs e)
        {
            UserPanel.BackColor = SystemColors.Control;
            Txt_SSN.BackColor = SystemColors.Control;
            Txt_Password.BackColor = Color.White;
            PasswordPanel.BackColor = Color.White;
        }

        private void panel2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Btn_Login_Click(sender, e);
            }
        }
    }
}