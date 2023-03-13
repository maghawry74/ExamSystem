using ExamSystem.Models;

namespace ExamSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
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
                    MessageBox.Show($"Welcome {LoginResult.FirstName}");
                }
            }
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Txt_SSN_Enter(object sender, EventArgs e)
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
    }
}