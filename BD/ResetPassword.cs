using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
using System.Drawing;
using BLL.Services;

namespace BD
{

    public partial class ResetPassword : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        string username = ForgotPassword.to;
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtResetPass.Text == TxtResetPassVer.Text)
            {
                BD_connect db = new BD_connect();
                MySqlCommand command = new MySqlCommand($"UPDATE `users` SET  `Password` = { TxtResetPassVer.Text }  Where Email = '{ username }'", db.GetConnection());
                command.Parameters.Add("@Password", MySqlDbType.VarChar).Value = TxtResetPassVer.Text;

                db.OpenConnection();
                if (command.ExecuteNonQuery() == 1)
                    MessageBox.Show("Пароль был успешно изменен");
                db.CloseConnection();
            }
            else
            {
                MessageBox.Show("Пароли не совпадают, повторите попытку");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm ();
            loginForm.Show();

        }

        private void TxtResetPass_Enter(object sender, EventArgs e)
        {
            if (TxtResetPass.Text == "Введите новый пароль")
            {
                TxtResetPass.Text = "";
                TxtResetPass.ForeColor = Color.LightGray;
                TxtResetPass.UseSystemPasswordChar = true;
            }
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.ForeColor = Color.LightGray;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.DimGray;
        }

        private void TxtResetPass_Leave(object sender, EventArgs e)
        {
            if (TxtResetPass.Text == "")
            {
                TxtResetPass.Text = "Введите новый пароль";
                TxtResetPass.ForeColor = Color.DimGray;
                TxtResetPass.UseSystemPasswordChar = false;
            }
        }

        private void TxtResetPassVer_Leave(object sender, EventArgs e)
        {
            if (TxtResetPassVer.Text == "")
            {
                TxtResetPassVer.Text = "Подтвердите новый пароль";
                TxtResetPassVer.ForeColor = Color.DimGray;
                TxtResetPassVer.UseSystemPasswordChar = false;
            }
        }

        private void TxtResetPassVer_Enter(object sender, EventArgs e)
        {
            if (TxtResetPassVer.Text == "Подтвердите новый пароль")
            {
                TxtResetPassVer.Text = "";
                TxtResetPassVer.ForeColor = Color.LightGray;
                TxtResetPassVer.UseSystemPasswordChar = true;
            }
        }

        private void ResetPassword_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                TxtResetPass.UseSystemPasswordChar = false;

            else
                TxtResetPass.UseSystemPasswordChar = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
                TxtResetPassVer.UseSystemPasswordChar = false;

            else
                TxtResetPassVer.UseSystemPasswordChar = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
