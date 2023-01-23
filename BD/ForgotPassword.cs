using System;
using System.Data;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
using System.Drawing;
using BLL.Services;

namespace BD
{
    public partial class ForgotPassword : Form
    {
        string randomCode;
        public static string to;
        int timeLeft = 15;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public ForgotPassword()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BD_connect db = new BD_connect();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Email` = @uL", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = TxtEmail.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                string from, pass, messageBody;
                Random rand = new Random();
                randomCode = (rand.Next(999999)).ToString();
                MailMessage message = new MailMessage();
                to = (TxtEmail.Text).ToString();
                from = "916131@gapps.ispu.ru";
                pass = "isq010103";
                messageBody = "Ваш код восстановления пароля " + randomCode;
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messageBody;
                message.Subject = "Код восстановления пароля";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                //timer
                timer1.Start();

                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Код успешно отправлен.В течении заданного времени введите его.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
                MessageBox.Show("Email не найден, пожалуйста, зарегистрируйтесь");

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (TxtVerCode.Text != "")
                if (randomCode == (TxtVerCode.Text).ToString())
                {
                    to = TxtEmail.Text;
                    ResetPassword resetPassword = new ResetPassword();
                    this.Hide();
                    resetPassword.Show();
                }
                else
                    MessageBox.Show("Неверный Код");
            else
                MessageBox.Show("Введите Код");


        }

        private void timer1_Tick(object sender, EventArgs e)

        {
            
            if (timeLeft >= 0)
            {
               label1.Text = timeLeft.ToString() + " сек.";
                timeLeft -= 1;
                button1.Enabled = false;
                label1.Visible = true;
                label2.Visible = true;
            }

            if (timeLeft < 0)
            {
                timer1.Enabled = false;
                timer1.Stop();
                label1.Visible = false;
                label2.Visible = false;
                button1.Enabled = true;
                Random rand = new Random();
                randomCode = "";
                timeLeft = 15;

            }

        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

            label1.Visible = false;
            label2.Visible = false;
        }

        private void TxtEmail_Enter(object sender, EventArgs e)
        {
            if (TxtEmail.Text == "Введите Email")
            {
                TxtEmail.Text = "";
                TxtEmail.ForeColor = Color.LightGray;
            }
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            if (TxtEmail.Text == "")
            {
                TxtEmail.Text = "Введите Email";
                TxtEmail.ForeColor = Color.DimGray;
            }
        }

        private void TxtVerCode_Leave(object sender, EventArgs e)
        {
            if (TxtVerCode.Text == "")
            {
                TxtVerCode.Text = "Введите проверочный код";
                TxtVerCode.ForeColor = Color.DimGray;
            }
        }

        private void TxtVerCode_Enter(object sender, EventArgs e)
        {
            if (TxtVerCode.Text == "Введите проверочный код")
            {
                TxtVerCode.Text = "";
                TxtVerCode.ForeColor = Color.LightGray;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void ForgotPassword_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
