using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using BLL.Services;


namespace BD
{
    public partial class ClienMainForm : Form
    {

        public ClienMainForm()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClienMainForm_Load(object sender, EventArgs e)
        {
            processorModels = cDB.GetProcessor();
            comboBox1.DataSource = processorModels;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id_proc";

            motherboardModels = cDB.GetMotherboard();
            comboBox2.DataSource = motherboardModels;
            comboBox2.DisplayMember = "Name";
            comboBox2.ValueMember = "Id_mboard";

            case_PcModels = cDB.GetCase_pc();
            comboBox3.DataSource = case_PcModels;
            comboBox3.DisplayMember = "Name";
            comboBox3.ValueMember = "Id_case";

            comboBox1.Visible = true;
            label1.Visible = true;
            //coolerModels = cDB.GetCooler();
            //comboBox4.DataSource = coolerModels;
            //comboBox4.DisplayMember = "Name";
            //comboBox4.ValueMember = "Id_cooler";
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            //bunifuCustomDataGrid1.Columns["Id_proc2"].Visible = false;
            //bunifuCustomDataGrid1.Columns["Id_mboard2"].Visible = false;
            //bunifuCustomDataGrid1.Columns["Id_case2"].Visible = false;

            

            Pc_assemblyModel sborkaPC = new Pc_assemblyModel();
            processorModel processorModel = new processorModel();
            MotherboardModel motherboardModel = new MotherboardModel();
            case_pcModel case_PcModel = new case_pcModel();

            int ID = Convert.ToInt32(comboBox1.SelectedValue);//Присваиваю ID proc
            string socket = ReportPCA.GetSocketProc(ID);//Получаю сокет
            comboBox2.SelectedValue = ReportPCA.GetFinMboard(socket);//Нахожу мат. плату 

            //sborkaPC.Id_case_pc2 = Convert.ToInt32(comboBox3.SelectedValue);
            //MessageBox.Show(socket);

            int ID_mboard = Convert.ToInt32(comboBox2.SelectedValue);//присваиваю ID мат.
            string size = ReportPCA.GetSizeMboard(ID_mboard);//находим форм.фактор метери
            comboBox3.SelectedValue = ReportPCA.GetFinCasePC(size);//Нахожу корпус   
            
            //int ID_case = Convert.ToInt32(comboBox3.SelectedValue);//Присваиваю Id корпуса.
            //int CoolerHeingtonCase = ReportPCA.GetMaxcoolerCasePC(ID_case);//находит макс. выс. кул.в корп.
            //comboBox4.SelectedValue = ReportPCA.GetFinCooler(CoolerHeingtonCase,socket);//нах. выс. кул.

            sborkaPC.Id_proc2 = Convert.ToInt32(comboBox1.SelectedValue);//Добавление в БД
            sborkaPC.Id_mboard2 = Convert.ToInt32(comboBox2.SelectedValue);//Добавление в БД
            sborkaPC.Id_case2 = Convert.ToInt32(comboBox3.SelectedValue);//Добавление в БД
/*          sborkaPC.Id_cooler2 = Convert.ToInt32(comboBox4.SelectedValue);*///Добавление в БД
           
            cDB.CreateSborka(sborkaPC);
            BSAssemblyPC.DataSource = cDB.GetPc_Assemblies();
            
            bunifuCustomDataGrid1.DataSource = BSAssemblyPC;
            bunifuCustomDataGrid1.Columns[0].Visible = false;
            bunifuCustomDataGrid1.Columns[1].Visible = false;
            bunifuCustomDataGrid1.Columns[2].Visible = false;
            bunifuCustomDataGrid1.Columns[3].Visible = false;
            bunifuCustomDataGrid1.Columns[4].Visible = false;
            bunifuCustomDataGrid1.Columns[5].Visible = false;

            bunifuCustomDataGrid1.Columns[6].HeaderText = "Наименование мат. платы";
            bunifuCustomDataGrid1.Columns[7].HeaderText = "Наименование корпуса";
            bunifuCustomDataGrid1.Columns[8].HeaderText = "Наименование процессора";
            bunifuCustomDataGrid1.Columns[9].HeaderText = "Цена";
            bunifuCustomDataGrid1.Refresh();

        }

        CDB cDB = new CDB();
        //List<SborkaPC> SborkaPC;
        List<processorModel> processorModels;
        List<MotherboardModel> motherboardModels;
        List<case_pcModel> case_PcModels;
        List<coolerModel> coolerModels;


        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }


}
