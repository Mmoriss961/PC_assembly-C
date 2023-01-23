using BLL.Services;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BD
{
    public partial class RegisterForm : Form
    {
        BD_connect db = new BD_connect();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void NameField_Enter(object sender, EventArgs e)
        {
            if (NameField.Text == "Введите имя")
            {
                NameField.Text = "";
                NameField.ForeColor = Color.LightGray;
            }
        }

        private void NameField_Leave(object sender, EventArgs e)
        {
            if (NameField.Text == "")
            {
                NameField.Text = "Введите имя";
                NameField.ForeColor = Color.DimGray;
            }


        }

        private void SurnameField_Enter(object sender, EventArgs e)
        {
            if (SurnameField.Text == "Введите фамилию")
            {
                SurnameField.Text = "";
                SurnameField.ForeColor = Color.LightGray;
            }
        }

        private void SurnameField_Leave(object sender, EventArgs e)
        {
            if (SurnameField.Text == "")
            {
                SurnameField.Text = "Введите фамилию";
                SurnameField.ForeColor = Color.DimGray;
            }
        }

        private void EmailField_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailField_Enter(object sender, EventArgs e)
        {
            if (EmailField.Text == "Введите Email")
            {
                EmailField.Text = "";
                EmailField.ForeColor = Color.LightGray;
            }
        }

        private void EmailField_Leave(object sender, EventArgs e)
        {
            if (EmailField.Text == "")
            {
                EmailField.Text = "Введите Email";
                EmailField.ForeColor = Color.DimGray;
            }
        }

        private void PasswordField_Enter(object sender, EventArgs e)
        {
            if (PasswordField.Text == "Введите пароль")
            {
                PasswordField.Text = "";
                PasswordField.ForeColor = Color.LightGray;
                PasswordField.UseSystemPasswordChar = true;
            }
        }

        private void PasswordField_Leave(object sender, EventArgs e)
        {
            if (PasswordField.Text == "")
            {
                PasswordField.Text = "Введите пароль";
                PasswordField.ForeColor = Color.DimGray;
                PasswordField.UseSystemPasswordChar = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (NameField.Text == "Введите имя")
            {
                MessageBox.Show("Введите имя");
                return;
            }
            if (SurnameField.Text == "Введите фамилию")
            {
                MessageBox.Show("Введите фамилию");
                return;
            }
            if (EmailField.Text == "Введите Email")
            {
                MessageBox.Show("Введите Email");
                return;
            }
            if (PasswordField.Text == "Введите пароль")
            {
                MessageBox.Show("Введите пароль");
                return;
            }

            if (isEmailExists())
                return;


            BD_connect db = new BD_connect();
            MySqlCommand command = new MySqlCommand(" INSERT INTO `users` (Name, Surname, Email, Password, Root) VALUES ( @Name, @Surname, @Email, @Password, @Root)", db.GetConnection());
            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = NameField.Text;
            command.Parameters.Add("@Surname", MySqlDbType.VarChar).Value = SurnameField.Text;
            command.Parameters.Add("@Email", MySqlDbType.VarChar).Value = EmailField.Text;
            command.Parameters.Add("@Password", MySqlDbType.VarChar).Value = PasswordField.Text;
            command.Parameters.Add("@Root", MySqlDbType.Int32).Value = 0;

            db.OpenConnection();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Пользователь был успешно добавлен");
            else
                MessageBox.Show("Пользователь не был добавлен");
            db.CloseConnection();

        }
        public Boolean isEmailExists()
        {
            BD_connect db = new BD_connect();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `Email` = @uL", db.GetConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = EmailField.Text;
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой Email уже зарегестрирован, введите другой Email");
                return true;

            }
            else
                return false;
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void RegisterLabel_MouseMove(object sender, MouseEventArgs e)
        {
            RegisterLabel.ForeColor = Color.LightGray;
        }

        private void RegisterLabel_MouseLeave(object sender, EventArgs e)
        {
            RegisterLabel.ForeColor = Color.DimGray;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void RegisterForm_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                PasswordField.UseSystemPasswordChar = false;

            else
                PasswordField.UseSystemPasswordChar = true;

        }
    }

}
