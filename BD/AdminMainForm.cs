using BLL.Services;
using System;
using System.Data;
using System.Windows.Forms;
using BLL;
using System.Collections.Generic;
using System.Linq;
using MoreLinq;
using MoreLinq.Extensions;
using System.Drawing;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace BD
{
    public partial class AdminMainForm : Form
    {
        //Boolean newAddingRow = false;
        public AdminMainForm()
        {
            InitializeComponent();


        }



        //public void ReloadDataForUsers()
        //{
        //    BD_connect db = new BD_connect();
        //    MySqlDataAdapter adapter = new MySqlDataAdapter();
        //    DataTable catalogTable = new DataTable();
        //    MySqlCommand command = new MySqlCommand("SELECT *, 'Delete' AS `Command` FROM `users`", db.GetConnection());
        //    adapter.SelectCommand = command;
        //    adapter.Fill(catalogTable);
        //    UserTable.DataSource = catalogTable;

        //    for (var i = 0; i < UserTable.Rows.Count; i++)
        //    {
        //        DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
        //        UserTable[5, i] = linkCell;
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            // ReloadDataForUsers();
        }

        //private void MainTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    BD_connect db = new BD_connect();
        //    if (e.ColumnIndex == 5)
        //    {
        //        var task = UserTable.Rows[e.RowIndex].Cells[5].Value.ToString();

        //        if (task == "Delete")
        //        {
        //            if (MessageBox.Show("Удалить выбранного пользователя?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //            {
        //                var userId = UserTable.Rows[e.RowIndex].Cells[0].Value.ToString();
        //                MySqlCommand command = new MySqlCommand("DELETE FROM `users` WHERE `users`.`id_user` = @uI", db.GetConnection());
        //                command.Parameters.Add("@uI", MySqlDbType.Int32).Value = userId;


        //                db.OpenConnection();
        //                if (command.ExecuteNonQuery() == 1)
        //                    MessageBox.Show("Пользователь был успешно удален");
        //                else
        //                    MessageBox.Show("Пользователь не был удален");
        //                db.CloseConnection();
        //                ReloadDataForUsers();
        //            }
        //        }
        //        else if (task == "Insert")
        //        {
        //            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`Name`, `Surname`, `Email`, `Password`) VALUES (@Name, @Surname, @Email, @Password);", db.GetConnection());
        //            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = UserTable.Rows[e.RowIndex].Cells[1].Value.ToString();
        //            command.Parameters.Add("@Surname", MySqlDbType.VarChar).Value = UserTable.Rows[e.RowIndex].Cells[2].Value.ToString();
        //            command.Parameters.Add("@Email", MySqlDbType.VarChar).Value = UserTable.Rows[e.RowIndex].Cells[3].Value.ToString();
        //            command.Parameters.Add("@Password", MySqlDbType.VarChar).Value = UserTable.Rows[e.RowIndex].Cells[4].Value.ToString();


        //            db.OpenConnection();
        //            if (command.ExecuteNonQuery() == 1)
        //                MessageBox.Show("Пользователь был успешно добавлен");
        //            else
        //                MessageBox.Show("Пользователь не был добавлен");
        //            db.CloseConnection();
        //            ReloadDataForUsers();
        //            newAddingRow = false;
        //        }
        //        else if (task == "Update")
        //        {
        //            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `Name` = @Name, `Surname` = @Surname, `Email` = @Email, `Password` = @Password WHERE `users`.`Id_user` = @id_user;", db.GetConnection());
        //            command.Parameters.Add("@id_user", MySqlDbType.VarChar).Value = UserTable.Rows[e.RowIndex].Cells[0].Value.ToString();
        //            command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = UserTable.Rows[e.RowIndex].Cells[1].Value.ToString();
        //            command.Parameters.Add("@Surname", MySqlDbType.VarChar).Value = UserTable.Rows[e.RowIndex].Cells[2].Value.ToString();
        //            command.Parameters.Add("@Email", MySqlDbType.VarChar).Value = UserTable.Rows[e.RowIndex].Cells[3].Value.ToString();
        //            command.Parameters.Add("@Password", MySqlDbType.VarChar).Value = UserTable.Rows[e.RowIndex].Cells[4].Value.ToString();

        //            db.OpenConnection();
        //            if (command.ExecuteNonQuery() == 1)
        //                MessageBox.Show("Пользователь был успешно изменен");
        //            else
        //                MessageBox.Show("пользователь не был изменен");
        //            db.CloseConnection();
        //            ReloadDataForUsers();
        //        }

        //    }
        //}

        //private void MainTable_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        //{
        //    if (newAddingRow == false)
        //    {
        //        newAddingRow = true;
        //        int lastRow = UserTable.Rows.Count - 2;
        //        DataGridViewRow row = UserTable.Rows[lastRow];
        //        DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
        //        UserTable[5, lastRow] = linkCell;
        //        UserTable[5, lastRow].Value = "Insert";
        //    }
        //}

        //private void MainTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (newAddingRow == false)
        //        UserTable.Rows[e.RowIndex].Cells[5].Value = "Update";
        //}




        private void ShowAllComponent_Click(object sender, EventArgs e)
        {

            if (panelButton.Visible == false)
            {
                UpPanelForTable.Visible = true;
                DTP_PC_AS.Visible = false;
                DTP_PC_AS2.Visible = false;
                LabelPo.Visible = false;
                labelS.Visible = false;
                FormReport.Visible = false;
                ExportForExcel.Visible = false;
                DG_ALL.Visible = false;
                Panel_for_down_button.Visible = false;
                PanelButtonReport.Hide();
                panelButton.Show();
                Logo.Hide();
            }
            else
            {
                UpPanelForTable.Visible = true;
                DG_ALL.Visible = false;
                Panel_for_down_button.Visible = false;
                panelButton.Hide();
                Logo.Show();
            }
        }

        private void ShowCase_PC_Click(object sender, EventArgs e)
        {
            Panel_for_down_button.Visible = true;
            UpPanelForTable.Visible = false;
            flag = "case_pc";
            DG_ALL.Visible = true;
            All_case_pc = cDB.GetCase_pc();
            BS_All.DataSource = All_case_pc;
            DG_ALL.DataSource = BS_All;

            DG_ALL.Columns["Id_case"].DisplayIndex = 0;
            DG_ALL.Columns["Name"].DisplayIndex = 1;
            DG_ALL.Columns["Max_height_cooler"].DisplayIndex = 2;
            DG_ALL.Columns["Integrated_power_supply"].DisplayIndex = 3;
            DG_ALL.Columns["Max_length_video"].DisplayIndex = 4;
            DG_ALL.Columns["Form_factor_2_5"].DisplayIndex = 5;
            DG_ALL.Columns["Form_factor_3_5"].DisplayIndex = 6;
            DG_ALL.Columns["Form_factor_mboard"].DisplayIndex = 7;
            DG_ALL.Columns["Price_rub"].DisplayIndex = 8;
            DG_ALL.Columns["Id_case"].Visible = false;
            DG_ALL.Columns["Name"].HeaderText = "Название";
            DG_ALL.Columns["Max_height_cooler"].HeaderText = "Макс. выс. куллера";
            DG_ALL.Columns["Integrated_power_supply"].HeaderText = "Мощность встроенного БП";
            DG_ALL.Columns["Max_length_video"].HeaderText = "Макс. длинна видеокарты";
            DG_ALL.Columns["Form_factor_2_5"].HeaderText = "Число внутр. отсеков 2.5";
            DG_ALL.Columns["Form_factor_3_5"].HeaderText = "Число внутр. отсеков 3.5";
            DG_ALL.Columns["Form_factor_mboard"].HeaderText = "Форм фактор мат. платы";
            DG_ALL.Columns["Price_rub"].HeaderText = "Цена";

        }

        private void ShowCooler_Click(object sender, EventArgs e)
        {
            Panel_for_down_button.Visible = true;
            UpPanelForTable.Visible = false;
            flag = "cooler";
            DG_ALL.Visible = true;
            All_cooler = cDB.GetCooler();
            BS_All.DataSource = All_cooler;
            DG_ALL.DataSource = BS_All;

            DG_ALL.Columns["Id__cooler"].DisplayIndex = 0;
            DG_ALL.Columns["Name"].DisplayIndex = 1;
            DG_ALL.Columns["Cooler_height"].DisplayIndex = 2;
            DG_ALL.Columns["Cooler_Max_TDP"].DisplayIndex = 3;
            DG_ALL.Columns["Cooler_Socket"].DisplayIndex = 4;
            DG_ALL.Columns["Price_rub"].DisplayIndex = 5;

            DG_ALL.Columns["Id__cooler"].Visible = false;
            DG_ALL.Columns["Name"].HeaderText = "Название";
            DG_ALL.Columns["Cooler_height"].HeaderText = "Высота куллера";
            DG_ALL.Columns["Cooler_Max_TDP"].HeaderText = "Макс. рассеиваемая мощность";
            DG_ALL.Columns["Cooler_Socket"].HeaderText = "Поддержка сокета";
            DG_ALL.Columns["Price_rub"].HeaderText = "Цена";
        }

        private void ShowDDR_Click(object sender, EventArgs e)
        {
            Panel_for_down_button.Visible = true;
            UpPanelForTable.Visible = false;
            DG_ALL.Visible = true;
            All_DDR = cDB.GetDDR();
            BS_All.DataSource = All_DDR;
            DG_ALL.DataSource = BS_All;
            flag = "DDR";

            DG_ALL.Columns["Id_DDR"].DisplayIndex = 0;
            DG_ALL.Columns["Name"].DisplayIndex = 1;
            DG_ALL.Columns["DDR_type"].DisplayIndex = 2;
            DG_ALL.Columns["DDR_frenquency"].DisplayIndex = 3;
            DG_ALL.Columns["DDR_quantity"].DisplayIndex = 4;
            DG_ALL.Columns["DDR_size"].DisplayIndex = 5;
            DG_ALL.Columns["DDR_rub"].DisplayIndex = 6;

            DG_ALL.Columns["Id_DDR"].Visible = false;
            DG_ALL.Columns["Name"].HeaderText = "Название";
            DG_ALL.Columns["DDR_type"].HeaderText = "Поколение памяти";
            DG_ALL.Columns["DDR_frenquency"].HeaderText = "Частота памяти, MHz";
            DG_ALL.Columns["DDR_quantity"].HeaderText = "Колличество модулей";
            DG_ALL.Columns["DDR_size"].HeaderText = "Объем комлекта памяти, GB";
            DG_ALL.Columns["DDR_rub"].HeaderText = "Цена";
        }

        private void ShowHDD_Click(object sender, EventArgs e)
        {
            Panel_for_down_button.Visible = true;
            UpPanelForTable.Visible = false;
            DG_ALL.Visible = true;
            All_HDD = cDB.GetHDD();
            BS_All.DataSource = All_HDD;
            DG_ALL.DataSource = BS_All;
            flag = "HDD";

            DG_ALL.Columns["Id_HDD"].DisplayIndex = 0;
            DG_ALL.Columns["Name"].DisplayIndex = 1;
            DG_ALL.Columns["HDD_volume"].DisplayIndex = 2;
            DG_ALL.Columns["HDD_read_speed"].DisplayIndex = 3;
            DG_ALL.Columns["HDD_write_speed"].DisplayIndex = 4;
            DG_ALL.Columns["Price_rub"].DisplayIndex = 5;


            DG_ALL.Columns["Id_HDD"].Visible = false;
            DG_ALL.Columns["Name"].HeaderText = "Название";
            DG_ALL.Columns["HDD_volume"].HeaderText = "Объем";
            DG_ALL.Columns["HDD_read_speed"].HeaderText = "Скорость чтения";
            DG_ALL.Columns["HDD_write_speed"].HeaderText = "Скорость записи";
            DG_ALL.Columns["Price_rub"].HeaderText = "Цена";


        }

        private void ShowSSD_Click(object sender, EventArgs e)
        {
            Panel_for_down_button.Visible = true;
            UpPanelForTable.Visible = false;
            DG_ALL.Visible = true;
            All_SSD = cDB.GetSSD();
            BS_All.DataSource = All_SSD;
            DG_ALL.DataSource = BS_All;
            flag = "SSD";

            DG_ALL.Columns["Id_SSD"].DisplayIndex = 0;
            DG_ALL.Columns["Name"].DisplayIndex = 1;
            DG_ALL.Columns["Form_factor"].DisplayIndex = 2;
            DG_ALL.Columns["SSD_read_speed"].DisplayIndex = 3;
            DG_ALL.Columns["SSD_write_speed"].DisplayIndex = 4;
            DG_ALL.Columns["SSD_connection_interface"].DisplayIndex = 5;
            DG_ALL.Columns["SSD_volume"].DisplayIndex = 6;
            DG_ALL.Columns["Price_rub"].DisplayIndex = 7;


            DG_ALL.Columns["Id_SSD"].Visible = false;
            DG_ALL.Columns["Name"].HeaderText = "Название";
            DG_ALL.Columns["Form_factor"].HeaderText = "Форм фактор";
            DG_ALL.Columns["SSD_read_speed"].HeaderText = "Скорость чтения";
            DG_ALL.Columns["SSD_write_speed"].HeaderText = "Скорость записи";
            DG_ALL.Columns["SSD_connection_interface"].HeaderText = "Интерфейс подключения";
            DG_ALL.Columns["SSD_volume"].HeaderText = "Объем";
            DG_ALL.Columns["Price_rub"].HeaderText = "Цена";
        }

        private void ShowMboard_Click(object sender, EventArgs e)
        {
            Panel_for_down_button.Visible = true;
            UpPanelForTable.Visible = false;
            DG_ALL.Visible = true;
            All_Motherboard = cDB.GetMotherboard();
            BS_All.DataSource = All_Motherboard;
            DG_ALL.DataSource = BS_All;
            flag = "Mboard";

            DG_ALL.Columns["Id_mboard"].DisplayIndex = 0;
            DG_ALL.Columns["Name"].DisplayIndex = 1;
            DG_ALL.Columns["Mboard_size"].DisplayIndex = 2;
            DG_ALL.Columns["Mboard_DDR"].DisplayIndex = 3;
            DG_ALL.Columns["Mboard_max_DDR"].DisplayIndex = 4;
            DG_ALL.Columns["Mboard_max_frenquency_DDR"].DisplayIndex = 5;
            DG_ALL.Columns["Mboard_socket"].DisplayIndex = 6;
            DG_ALL.Columns["Mboard_M2"].DisplayIndex = 7;
            DG_ALL.Columns["Mboard_Sata_III"].DisplayIndex = 8;
            DG_ALL.Columns["Price_rub"].DisplayIndex = 9;


            DG_ALL.Columns["Id_mboard"].Visible = false;
            DG_ALL.Columns["Name"].HeaderText = "Название";
            DG_ALL.Columns["Mboard_size"].HeaderText = "Размер платы";
            DG_ALL.Columns["Mboard_DDR"].HeaderText = "	Поколение DDR, которая поддерживает мат. плата";
            DG_ALL.Columns["Mboard_max_DDR"].HeaderText = "Количество слотов DDR";
            DG_ALL.Columns["Mboard_max_frenquency_DDR"].HeaderText = "	Максимальная частота DDR";
            DG_ALL.Columns["Mboard_socket"].HeaderText = "Сокет";
            DG_ALL.Columns["Mboard_M2"].HeaderText = "Количество слотов M2";
            DG_ALL.Columns["Mboard_Sata_III"].HeaderText = "Количество слотов Sata III";
            DG_ALL.Columns["Price_rub"].HeaderText = "Цена";
        }

        private void ShowPowSup_Click(object sender, EventArgs e)
        {
            Panel_for_down_button.Visible = true;
            UpPanelForTable.Visible = false;
            DG_ALL.Visible = true;
            All_power_supply = cDB.GetPower_supply();
            BS_All.DataSource = All_power_supply;
            DG_ALL.DataSource = BS_All;
            flag = "PowSup";


            DG_ALL.Columns["Id__power_supply"].DisplayIndex = 0;
            DG_ALL.Columns["Name"].DisplayIndex = 1;
            DG_ALL.Columns["Power_supply__power"].DisplayIndex = 2;
            DG_ALL.Columns["Power_supply_PCI_E"].DisplayIndex = 3;
            DG_ALL.Columns["Price_rub"].DisplayIndex = 4;


            DG_ALL.Columns["Id__power_supply"].Visible = false;
            DG_ALL.Columns["Name"].HeaderText = "Название";
            DG_ALL.Columns["Power_supply__power"].HeaderText = "Мощность блока питания";
            DG_ALL.Columns["Power_supply_PCI_E"].HeaderText = "Количество разъемов 6+2-pin PCI-E";
            DG_ALL.Columns["Price_rub"].HeaderText = "Цена";

        }

        private void ShowProc_Click(object sender, EventArgs e)
        {
            Panel_for_down_button.Visible = true;
            UpPanelForTable.Visible = false;
            DG_ALL.Visible = true;
            All_processor = cDB.GetProcessor();
            BS_All.DataSource = All_processor;
            DG_ALL.DataSource = BS_All;
            flag = "Proc";

            //DG_ALL.Columns["Id_mboard"].DisplayIndex = 0;
            //DG_ALL.Columns["Name"].DisplayIndex = 1;
            //DG_ALL.Columns["Mboard_size"].DisplayIndex = 2;
            //DG_ALL.Columns["Mboard_DDR"].DisplayIndex = 3;
            //DG_ALL.Columns["Mboard_max_DDR"].DisplayIndex = 4;
            //DG_ALL.Columns["Mboard_max_frenquency_DDR"].DisplayIndex = 5;
            //DG_ALL.Columns["Mboard_socket"].DisplayIndex = 6;
            //DG_ALL.Columns["Mboard_M2"].DisplayIndex = 7;
            //DG_ALL.Columns["Mboard_Sata_III"].DisplayIndex = 8;
            //DG_ALL.Columns["Price_rub"].DisplayIndex = 9;


            //DG_ALL.Columns["Id_mboard"].Visible = false;
            //DG_ALL.Columns["Name"].HeaderText = "Название";
            //DG_ALL.Columns["Mboard_size"].HeaderText = "Размер платы";
            //DG_ALL.Columns["Mboard_DDR"].HeaderText = "	Поколение DDR, которая поддерживает мат. плата";
            //DG_ALL.Columns["Mboard_max_DDR"].HeaderText = "Количество слотов DDR";
            //DG_ALL.Columns["Mboard_max_frenquency_DDR"].HeaderText = "	Максимальная частота DDR";
            //DG_ALL.Columns["Mboard_socket"].HeaderText = "Сокет";
            //DG_ALL.Columns["Mboard_M2"].HeaderText = "Количество слотов M2";
            //DG_ALL.Columns["Mboard_Sata_III"].HeaderText = "Количество слотов Sata III";
            //DG_ALL.Columns["Price_rub"].HeaderText = "Цена";
        }

        private void ShowVideo_Click(object sender, EventArgs e)
        {
            Panel_for_down_button.Visible = true;
            UpPanelForTable.Visible = false;
            DG_ALL.Visible = true;
            All_videocard = cDB.GetVideocard();
            BS_All.DataSource = All_videocard;
            DG_ALL.DataSource = BS_All;
            flag = "Video";
        }

        private void ShowUser_Click(object sender, EventArgs e)
        {
            Panel_for_down_button.Visible = true;
            UpPanelForTable.Visible = false;
            DG_ALL.Visible = true;
            All_users = cDB.GetUsers();
            BS_All.DataSource = All_users;
            DG_ALL.DataSource = BS_All;
            flag = "User";
            PanelButtonReport.Visible = false;
            panelButton.Visible = false;


        }
        private void Assembly_users_Click(object sender, EventArgs e)
        {
            Panel_for_down_button.Visible = true;
            UpPanelForTable.Visible = false;
            DG_ALL.Visible = true;
            All_pc_Assembly = cDB.GetPc_Assemblies();
            BS_All.DataSource = All_pc_Assembly;
            DG_ALL.DataSource = BS_All;
            flag = "Assembly_users";
            PanelButtonReport.Visible = false;
            panelButton.Visible = false;
        }

        private void ShowReport_Click(object sender, EventArgs e)
        {
            if (PanelButtonReport.Visible == false)
            {
                UpPanelForTable.Visible = true;
                DTP_PC_AS.Visible = false;
                DTP_PC_AS2.Visible = false;
                LabelPo.Visible = false;
                labelS.Visible = false;
                FormReport.Visible = false;
                ExportForExcel.Visible = false;
                Panel_for_down_button.Visible = false;
                DG_ALL.Visible = false;
                panelButton.Hide();
                PanelButtonReport.Show();
                Logo.Show();


            }
            else
            {
                Panel_for_down_button.Visible = false;
                UpPanelForTable.Visible = true;
                DG_ALL.Visible = false;
                PanelButtonReport.Hide();

            }


        }




        private void Add_Click(object sender, EventArgs e)
        {
            if (flag == "case_pc")
            {
                Add_case_pc c_p = new Add_case_pc();

                All_case_pc = cDB.GetCase_pc().ToList();

                var All_case_pc2 = new List<case_pcModel>();

                //Boolean coteints = false;

                List<string> case_pc_Form_factor_mboard = new List<string>
                     {
                "mATX","ATX","Mini-ITX"
                     };

                //foreach (case_pcModel case1 in All_case_pc)
                //{
                //    All_case_pc2.ForEach(case2 =>
                //    {
                //        if (case2.Form_factor_mboard == case1.Form_factor_mboard)
                //            coteints = true;
                //    });
                //    if (!coteints)
                //    {
                //        All_case_pc2.Add(case1);
                //        coteints = false;
                //    }

                //}

                //var All_case_pc = cDB.GetCase_pc().Select(c => new { c.Form_factor_mboard }).Distinct().ToList();


                c_p.comboBox1.DataSource = case_pc_Form_factor_mboard;
                //c_p.comboBox1.DisplayMember = "Form_factor_mboard";
                //c_p.comboBox1.ValueMember = "Id_case";

                //var query = All_case_pc.DistinctBy(s => new { s.Id_case, s.Integrated_power_supply });
                //All_case_pc = All_case_pc.DistinctBy1(i => new { i.Form_factor_mboard });




                DialogResult result = c_p.ShowDialog(this);
                if (result == DialogResult.Cancel)
                    return;

               
                if (c_p.textBox1.Text == "")
                {
                    MessageBox.Show("Поле на заполнено");
                    return;
                }
                if (c_p.textBox2.Text == "")
                {
                    MessageBox.Show("Поле на заполнено");
                    return;
                }
                if (c_p.textBox3.Text == "")
                {
                    MessageBox.Show("Поле на заполнено");
                    return;
                }
                if (c_p.textBox4.Text == "")
                {
                    MessageBox.Show("Поле на заполнено");
                    return;
                }
                if (c_p.textBox5.Text == "")
                {
                    MessageBox.Show("Поле на заполнено");
                    return;
                }
                if (c_p.textBox6.Text == "")
                {
                    MessageBox.Show("Поле на заполнено");
                    return;
                }
                if (c_p.comboBox1.Text == "")
                {
                    MessageBox.Show("Поле на заполнено");
                    return;
                }
                if (c_p.textBox7.Text == "")
                {
                    MessageBox.Show("Поле на заполнено");
                    return;
                }

                //var TypeOfForm_factor_mboard = All_case_pc.Where(i => i.Id_case == (long)c_p.comboBox1.SelectedValue).Select(i => new { i.Form_factor_mboard }).FirstOrDefault();
                // case_pc.Form_factor_mboard = TypeOfForm_factor_mboard.Form_factor_mboard.ToString();
                case_pc.Name = c_p.textBox1.Text;
                case_pc.Max_height_cooler = Convert.ToInt32(c_p.textBox2.Text);
                case_pc.Integrated_power_supply = Convert.ToInt32(c_p.textBox3.Text);
                case_pc.Max_length_video = Convert.ToInt32(c_p.textBox4.Text);
                case_pc.Form_factor_2_5 = Convert.ToInt32(c_p.textBox5.Text);
                case_pc.Form_factor_3_5 = Convert.ToInt32(c_p.textBox6.Text);
                case_pc.Form_factor_mboard = c_p.comboBox1.Text;
                case_pc.Price_rub = Convert.ToInt32(c_p.textBox7.Text);


                cDB.CreateCase_pc(case_pc);
                All_case_pc = cDB.GetCase_pc();
                BS_All.DataSource = All_case_pc;
                MessageBox.Show("Новый объект добавлен");
                DG_ALL.Refresh();

            }
            if (flag == "Assembly_users")
            {

            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (flag == "case_pc")
            {
                int index = getSelectedRow(DG_ALL);
                if (index != -1)
                {
                    int id = 0;
                    bool converted = Int32.TryParse(DG_ALL[0, index].Value.ToString(), out id);
                    if (converted == false)
                        return;
                    cDB.DeleteCase_PC(id);
                    BS_All.DataSource = cDB.GetCase_pc();
                }
            }
        }


        private int getSelectedRow(DataGridView dataGridView)
        {
            int index = -1;
            if (dataGridView.SelectedRows.Count > 0 || dataGridView.SelectedCells.Count == 1)
            {
                if (dataGridView.SelectedRows.Count > 0)
                    index = dataGridView.SelectedRows[0].Index;
                else index = dataGridView.SelectedCells[0].RowIndex;
            }
            return index;
        }


        private void Update_Click(object sender, EventArgs e)
        {
            if (flag == "case_pc")
            {
                int index = getSelectedRow(DG_ALL);
                if (index != -1)
                {
                    int id = 0;
                    bool converted = Int32.TryParse(DG_ALL[0, index].Value.ToString(), out id);
                    if (converted == false)
                        return;

                    case_pcModel c_p = All_case_pc.Where(i => i.Id_case == id).FirstOrDefault();
                    if (c_p != null)
                    {
                        Add_case_pc f = new Add_case_pc();
                        All_case_pc = cDB.GetCase_pc().ToList();
                        var All_case_pc2 = new List<case_pcModel>();

                        List<string> case_pc_Form_factor_mboard = new List<string>
                    {
                        "mATX","ATX","Mini-ITX"
                    };

                        f.comboBox1.DataSource = case_pc_Form_factor_mboard;

                        f.textBox1.Text = c_p.Name;
                        f.textBox2.Text = c_p.Max_height_cooler.ToString();
                        f.textBox3.Text = c_p.Integrated_power_supply.ToString();
                        f.textBox4.Text = c_p.Max_length_video.ToString();
                        f.textBox5.Text = c_p.Form_factor_2_5.ToString();
                        f.textBox6.Text = c_p.Form_factor_3_5.ToString();
                        f.comboBox1.Text = c_p.Form_factor_mboard;
                        f.textBox7.Text = c_p.Price_rub.ToString();

                        DialogResult result = f.ShowDialog(this);

                        if (result == DialogResult.Cancel)
                            return;

                        c_p.Name = f.textBox1.Text;
                        c_p.Max_height_cooler = Convert.ToInt32(f.textBox2.Text);
                        c_p.Integrated_power_supply = Convert.ToInt32(f.textBox3.Text);
                        c_p.Max_length_video = Convert.ToInt32(f.textBox4.Text);
                        c_p.Form_factor_2_5 = Convert.ToInt32(f.textBox5.Text);
                        c_p.Form_factor_3_5 = Convert.ToInt32(f.textBox6.Text);
                        c_p.Form_factor_mboard = f.comboBox1.Text;
                        c_p.Price_rub = Convert.ToInt32(f.textBox7.Text);
                        cDB.UpdateCase_PC(c_p);
                        MessageBox.Show("Объект обновлен");
                        All_case_pc = cDB.GetCase_pc();
                        BS_All.DataSource = All_case_pc;
                        DG_ALL.DataSource = BS_All;
                    }
                }
                else

                    MessageBox.Show("Ни один объект не выбран!");
            }
        }
















        private void ReportAsForDate_Click(object sender, EventArgs e)
        {
            UpPanelForTable.Visible = true;

            DTP_PC_AS.Visible = true;
            DTP_PC_AS2.Visible = true;
            LabelPo.Visible = true;
            labelS.Visible = true;
            FormReport.Visible = true;
            ExportForExcel.Visible = true;


        }



        string flag = "";

        case_pcModel case_pc = new case_pcModel();
        CDB cDB = new CDB();

        List<Pc_assemblyModel> All_pc_Assembly;
        List<case_pcModel> All_case_pc = new List<case_pcModel>();
        List<coolerModel> All_cooler;
        List<DDRModel> All_DDR;
        List<HDDModel> All_HDD;
        List<MotherboardModel> All_Motherboard;
        List<power_supplyModel> All_power_supply;
        List<processorModel> All_processor;
        List<SSDModel> All_SSD;
        List<usersModel> All_users;
        List<videocardModel> All_videocard;
        string buttontooltip = "Отображает пользователей, которым была сформирована сборка в выбранный диапазон дат";


        private void ReportForAssForUsers_MouseHover(object sender, EventArgs e)
        {
            //"Отображает пользователей, которым была сформирована сборка в выбранный диапазон дат"
            toolTip1.OwnerDraw = true;
            toolTip1.Draw += new DrawToolTipEventHandler(toolTip1_Draw);
            toolTip1.Popup += new PopupEventHandler(toolTip1_Popup);
            // toolTip1.BackColor = Color.DarkSlateGray;
            toolTip1.SetToolTip(ReportForAssForUsers, buttontooltip);

        }



        private void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            Bitmap image = new Bitmap(@"D:\Download\Browser\1213.png");
            System.Drawing.Font f = new System.Drawing.Font("Comic Sans MS", 12.0f);
            e.DrawBackground();
            e.DrawBorder();
            buttontooltip = e.ToolTipText;
            e.Graphics.DrawImage(image, 2, 2);
            e.Graphics.DrawString(e.ToolTipText, f, Brushes.LightGray, new PointF(25, -1));


        }
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            e.ToolTipSize = TextRenderer.MeasureText(buttontooltip, new System.Drawing.Font("Comic Sans MS", 12.1f));
        }

        private void ExportForExel(object sender, EventArgs e)
        {
            Excel.Application Excel = new Excel.Application();
            Workbook wb = Excel.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)Excel.ActiveSheet;
            Excel.Visible = true;
            ws.Cells[1, 1] = "Id пользователя";
            ws.Cells[1, 2] = "Имя и фамилия пользователя";
            ws.Cells[1, 3] = "Дата, когда была собрана сборка";
            ws.Cells[1, 4] = "Email";
            ws.Cells[1, 5] = "Цена всей сборки";

            for (int j = 2; j <= DG_ALL.Rows.Count; j++)
            {
                for (int i = 1; i <= 5; i++)
                {
                    ws.Cells[j, i] = DG_ALL.Rows[j - 2].Cells[i - 1].Value;

                }

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            BS_All.DataSource = ReportPCA.GetReportPcAssembly(DTP_PC_AS.Value, DTP_PC_AS2.Value);
            DG_ALL.DataSource = BS_All;
            DG_ALL.Visible = true;
            DG_ALL.Columns["Id"].HeaderText = "Id пользователя";
            DG_ALL.Columns["Name_user2"].HeaderText = "Имя и фамилия пользователя";
            DG_ALL.Columns["Email"].HeaderText = "Email";
            DG_ALL.Columns["Date"].HeaderText = "Дата, когда была собрана сборка";
            DG_ALL.Columns["Price_end"].HeaderText = "Цена всей сборки";
        }
    }
}





















