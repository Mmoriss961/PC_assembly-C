using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace BD
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CGUI GUIobj = new CGUI(this);
            //GUIobj.button1_Click();
            if (CDBObj_ == null) return;

            CDBObj_.SetUser(Login.Text);
            CDBObj_.SetPass(Password.Text);
            var venAuthorizationWindowType = CDBObj_.Authorization();
            string sUserName = CDBObj_.GetUserName();
            string sUserSurname = CDBObj_.GetUserSurname();


            if (venAuthorizationWindowType == BLL.Services.CDB.enAuthtorizationWindowType.Unknow)
                MessageBox.Show("Такой пользователь не найден.Проверьте правильность вводимых данных и повторите попытку.");

            if (venAuthorizationWindowType == BLL.Services.CDB.enAuthtorizationWindowType.AdminWindow)
            {

                this.Hide();
                AdminMainForm adminMainForm = new AdminMainForm();
                adminMainForm.Username.Text = "Здравствуйте," + "  " + sUserName + "  " + sUserSurname;
                adminMainForm.Show();


            }

            else if (venAuthorizationWindowType == BLL.Services.CDB.enAuthtorizationWindowType.ClienWindow)
            {
                this.Hide();
                ClienMainForm clienMainForm = new ClienMainForm();
                clienMainForm.Show();


            }

        }
    

        private void Register_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(OpenForm1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void Login_Enter(object sender, EventArgs e)
        {
            if (Login.Text == "Введите Email")
            {
                Login.Text = "";
                Login.ForeColor = Color.LightGray;
            }
        }


        private void Login_Leave(object sender, EventArgs e)
        {
            if (Login.Text == "")
            {
                Login.Text = "Введите Email";
                Login.ForeColor = Color.DimGray;
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password.Text == "")
            {
                Password.Text = "Введите пароль";
                Password.ForeColor = Color.DimGray;
                Password.UseSystemPasswordChar = false;
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (Password.Text == "Введите пароль")
            {
                Password.Text = "";
                Password.ForeColor = Color.LightGray;
                Password.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.ForeColor = Color.LightGray;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.DimGray;
        }

        private void Register_MouseLeave(object sender, EventArgs e)
        {
            Register.ForeColor = Color.DimGray;
        }

        private void Register_MouseMove(object sender, MouseEventArgs e)
        {
            Register.ForeColor = Color.LightGray;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                Password.UseSystemPasswordChar = false;

            else
                Password.UseSystemPasswordChar = true;
        }
        private void OpenForm1(object obj)
        {
            Application.Run(new ForgotPassword());
        }
        private void OpenForm(object obj)
        {
            Application.Run(new RegisterForm());
        }
    private BLL.Services.CDB CDBObj_ = new BLL.Services.CDB();
    private Thread th;
    }
}
