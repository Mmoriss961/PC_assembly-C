using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BD
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            ////Application.Run(new LoginForm());
            //Application.Run(new AdminMainForm());
            Config cfg;
            cfg = new Config(Application.StartupPath + @"\Config.ini");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (!File.Exists(Application.StartupPath + @"\Config.ini"))
                cfg.Write("Config", "StartForm", "False");
            bool StartForm = bool.Parse(cfg.Read("Config", "StartForm"));
            if (!StartForm)
            {
                Application.Run(new About());
                cfg.Write("Config", "StartForm", "True");
            }
            if (StartForm)
                Application.Run(new LoginForm());
        }
    }
}
