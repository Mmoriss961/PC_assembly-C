using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD
{
    public partial class About : Form
    {
        private Thread th;
        Config cfg;
        public About()
        {
            InitializeComponent();
            cfg = new Config(Application.StartupPath + @"\Config.ini");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            { 
            cfg.Write("Config", "StartForm", "true");
            Application.Restart();
            }
            else
            {
               
                this.Close();
                th = new Thread(OpenForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                cfg.Write("Config", "StartForm", "false");
            }
        }
        private void OpenForm(object obj)
        {
            Application.Run(new LoginForm());
        }


    }
}
